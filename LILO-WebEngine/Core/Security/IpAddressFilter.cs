using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Linq;

namespace LILO_WebEngine.Core.Security
{
    /// <summary>
    /// Provides IP address filtering capabilities for controlling access to the server
    /// </summary>
    public class IpAddressFilter
    {
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();
        private readonly HashSet<IPAddress> _allowedAddresses = new HashSet<IPAddress>();
        private readonly HashSet<IPAddress> _blockedAddresses = new HashSet<IPAddress>();
        private readonly List<IPNetwork> _allowedNetworks = new List<IPNetwork>();
        private readonly List<IPNetwork> _blockedNetworks = new List<IPNetwork>();
        
        private FilterMode _filterMode = FilterMode.AllowAll;
        
        /// <summary>
        /// Configures the filtering mode
        /// </summary>
        public FilterMode Mode 
        { 
            get 
            {
                _lock.EnterReadLock();
                try
                {
                    return _filterMode;
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
            set 
            {
                _lock.EnterWriteLock();
                try
                {
                    _filterMode = value;
                }
                finally
                {
                    _lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Checks if the IP address is allowed based on the current filter rules
        /// </summary>
        public bool IsAllowed(IPAddress address)
        {
            _lock.EnterReadLock();
            try
            {
                // Check if explicitly blocked
                if (_blockedAddresses.Contains(address))
                {
                    return false;
                }
                
                // Check if in a blocked network
                foreach (var network in _blockedNetworks)
                {
                    if (network.Contains(address))
                    {
                        return false;
                    }
                }
                
                // Allow based on mode
                switch (_filterMode)
                {
                    case FilterMode.AllowAll:
                        return true;
                        
                    case FilterMode.BlockAll:
                        return false;
                        
                    case FilterMode.AllowSpecific:
                        // Must be explicitly allowed
                        if (_allowedAddresses.Contains(address))
                        {
                            return true;
                        }
                        
                        // Or in an allowed network
                        foreach (var network in _allowedNetworks)
                        {
                            if (network.Contains(address))
                            {
                                return true;
                            }
                        }
                        
                        return false;
                        
                    default:
                        return true;
                }
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        
        /// <summary>
        /// Adds an IP address to the allowed list
        /// </summary>
        public void AllowAddress(IPAddress address)
        {
            _lock.EnterWriteLock();
            try
            {
                _allowedAddresses.Add(address);
                _blockedAddresses.Remove(address);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        
        /// <summary>
        /// Adds an IP address to the blocked list
        /// </summary>
        public void BlockAddress(IPAddress address)
        {
            _lock.EnterWriteLock();
            try
            {
                _blockedAddresses.Add(address);
                _allowedAddresses.Remove(address);
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        
        /// <summary>
        /// Adds a network CIDR to the allowed list
        /// </summary>
        public void AllowNetwork(string cidr)
        {
            _lock.EnterWriteLock();
            try
            {
                var network = IPNetwork.Parse(cidr);
                _allowedNetworks.Add(network);
                
                // Remove from blocked networks if overlapping
                _blockedNetworks.RemoveAll(n => n.Overlaps(network));
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        
        /// <summary>
        /// Adds a network CIDR to the blocked list
        /// </summary>
        public void BlockNetwork(string cidr)
        {
            _lock.EnterWriteLock();
            try
            {
                var network = IPNetwork.Parse(cidr);
                _blockedNetworks.Add(network);
                
                // Remove from allowed networks if overlapping
                _allowedNetworks.RemoveAll(n => n.Overlaps(network));
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
        
        /// <summary>
        /// Clears all filter rules
        /// </summary>
        public void ClearFilters()
        {
            _lock.EnterWriteLock();
            try
            {
                _allowedAddresses.Clear();
                _blockedAddresses.Clear();
                _allowedNetworks.Clear();
                _blockedNetworks.Clear();
                _filterMode = FilterMode.AllowAll;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }
    
    /// <summary>
    /// IP address filter mode
    /// </summary>
    public enum FilterMode
    {
        AllowAll,       // Allow all IPs except explicitly blocked ones
        BlockAll,       // Block all IPs
        AllowSpecific   // Allow only specific IPs/networks
    }
    
    /// <summary>
    /// Represents an IP network with CIDR notation
    /// </summary>
    public class IPNetwork
    {
        public IPAddress NetworkAddress { get; }
        public IPAddress SubnetMask { get; }
        public int CIDR { get; }
        
        private IPNetwork(IPAddress networkAddress, int cidr)
        {
            NetworkAddress = networkAddress;
            CIDR = cidr;
            SubnetMask = CalculateSubnetMask(cidr, networkAddress.AddressFamily);
        }
        
        /// <summary>
        /// Parses a CIDR notation string (e.g. "192.168.1.0/24")
        /// </summary>
        public static IPNetwork Parse(string cidr)
        {
            var parts = cidr.Split('/');
            if (parts.Length != 2)
            {
                throw new FormatException("Invalid CIDR format. Expected format: x.x.x.x/n");
            }
            
            if (!IPAddress.TryParse(parts[0], out var networkAddress))
            {
                throw new FormatException("Invalid IP address format");
            }
            
            if (!int.TryParse(parts[1], out var prefix))
            {
                throw new FormatException("Invalid prefix length");
            }
            
            var maxPrefix = networkAddress.AddressFamily == AddressFamily.InterNetwork ? 32 : 128;
            if (prefix < 0 || prefix > maxPrefix)
            {
                throw new ArgumentOutOfRangeException(nameof(prefix), $"Prefix must be between 0 and {maxPrefix}");
            }
            
            return new IPNetwork(networkAddress, prefix);
        }
        
        /// <summary>
        /// Checks if the network contains the specified IP address
        /// </summary>
        public bool Contains(IPAddress address)
        {
            if (address.AddressFamily != NetworkAddress.AddressFamily)
            {
                return false;
            }
            
            byte[] addressBytes = address.GetAddressBytes();
            byte[] networkBytes = NetworkAddress.GetAddressBytes();
            byte[] maskBytes = SubnetMask.GetAddressBytes();
            
            for (int i = 0; i < addressBytes.Length; i++)
            {
                if ((addressBytes[i] & maskBytes[i]) != (networkBytes[i] & maskBytes[i]))
                {
                    return false;
                }
            }
            
            return true;
        }
        
        /// <summary>
        /// Checks if this network overlaps with another network
        /// </summary>
        public bool Overlaps(IPNetwork other)
        {
            if (NetworkAddress.AddressFamily != other.NetworkAddress.AddressFamily)
            {
                return false;
            }
            
            return Contains(other.NetworkAddress) || other.Contains(NetworkAddress);
        }
        
        private static IPAddress CalculateSubnetMask(int cidr, AddressFamily family)
        {
            int length = family == AddressFamily.InterNetwork ? 4 : 16;
            byte[] mask = new byte[length];
            
            // Calculate the subnet mask based on CIDR
            for (int i = 0; i < length; i++)
            {
                int remainingBits = cidr - (i * 8);
                
                if (remainingBits >= 8)
                {
                    mask[i] = 255;
                }
                else if (remainingBits > 0)
                {
                    mask[i] = (byte)(256 - (1 << (8 - remainingBits)));
                }
                else
                {
                    mask[i] = 0;
                }
            }
            
            return new IPAddress(mask);
        }
    }
} 