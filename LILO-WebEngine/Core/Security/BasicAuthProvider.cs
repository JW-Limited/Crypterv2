using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Security
{
    /// <summary>
    /// Provides Basic HTTP Authentication for the web server
    /// </summary>
    public class BasicAuthProvider : IAuthenticationProvider
    {
        private readonly Dictionary<string, UserCredentials> _users = new Dictionary<string, UserCredentials>();
        private readonly HashSet<string> _protectedPaths = new HashSet<string>();
        private readonly object _syncLock = new object();
        
        /// <summary>
        /// Creates a new basic authentication provider
        /// </summary>
        public BasicAuthProvider() 
        {
            // Protected paths by default
            _protectedPaths.Add("/admin");
            _protectedPaths.Add("/config");
            _protectedPaths.Add("/api/logs");
            _protectedPaths.Add("/api/events");
            _protectedPaths.Add("/api/state");
            _protectedPaths.Add("/settings");
        }
        
        /// <summary>
        /// Authenticates a request using the Basic Authentication scheme
        /// </summary>
        public Task<AuthenticationResult> AuthenticateAsync(HttpListenerRequest request)
        {
            // Get the Authorization header
            string authHeader = request.Headers["Authorization"];
            
            // If there's no Authorization header, authentication fails
            if (string.IsNullOrEmpty(authHeader))
            {
                return Task.FromResult(new AuthenticationResult
                {
                    IsAuthenticated = false,
                    ErrorMessage = "No authorization header present"
                });
            }
            
            // Check if it's Basic authentication
            if (!authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(new AuthenticationResult
                {
                    IsAuthenticated = false,
                    ErrorMessage = "Only Basic authentication is supported"
                });
            }
            
            try
            {
                // Extract the credentials
                string encodedCredentials = authHeader.Substring("Basic ".Length).Trim();
                string decodedCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials));
                
                // Split username and password
                int colonIndex = decodedCredentials.IndexOf(':');
                if (colonIndex < 0)
                {
                    return Task.FromResult(new AuthenticationResult
                    {
                        IsAuthenticated = false,
                        ErrorMessage = "Invalid credentials format"
                    });
                }
                
                string username = decodedCredentials.Substring(0, colonIndex);
                string password = decodedCredentials.Substring(colonIndex + 1);
                
                // Verify credentials
                if (VerifyCredentials(username, password, out string[] roles))
                {
                    // Authentication successful
                    return Task.FromResult(new AuthenticationResult
                    {
                        IsAuthenticated = true,
                        User = new WebUser(username, roles)
                    });
                }
                else
                {
                    // Authentication failed
                    return Task.FromResult(new AuthenticationResult
                    {
                        IsAuthenticated = false,
                        ErrorMessage = "Invalid username or password"
                    });
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(new AuthenticationResult
                {
                    IsAuthenticated = false,
                    ErrorMessage = $"Authentication error: {ex.Message}"
                });
            }
        }
        
        /// <summary>
        /// Determines if a path requires authentication
        /// </summary>
        public bool RequiresAuthentication(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }
            
            path = path.TrimEnd('/').ToLowerInvariant();
            
            lock (_syncLock)
            {
                foreach (var protectedPath in _protectedPaths)
                {
                    if (path.StartsWith(protectedPath, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        
        /// <summary>
        /// Adds a protected path that requires authentication
        /// </summary>
        public void AddProtectedPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }
            
            path = path.TrimEnd('/').ToLowerInvariant();
            
            lock (_syncLock)
            {
                _protectedPaths.Add(path);
            }
        }
        
        /// <summary>
        /// Removes a protected path
        /// </summary>
        public void RemoveProtectedPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            
            path = path.TrimEnd('/').ToLowerInvariant();
            
            lock (_syncLock)
            {
                _protectedPaths.Remove(path);
            }
        }
        
        /// <summary>
        /// Adds a user with the specified credentials
        /// </summary>
        public void AddUser(string username, string password, string[] roles = null)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }
            
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password));
            }
            
            // Hash the password for storage
            string hashedPassword = HashPassword(password);
            
            lock (_syncLock)
            {
                _users[username] = new UserCredentials
                {
                    HashedPassword = hashedPassword,
                    Roles = roles ?? new string[0]
                };
            }
        }
        
        /// <summary>
        /// Removes a user
        /// </summary>
        public void RemoveUser(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return;
            }
            
            lock (_syncLock)
            {
                _users.Remove(username);
            }
        }
        
        private bool VerifyCredentials(string username, string password, out string[] roles)
        {
            roles = Array.Empty<string>();
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            
            lock (_syncLock)
            {
                if (_users.TryGetValue(username, out var credentials))
                {
                    string hashedPassword = HashPassword(password);
                    if (string.Equals(hashedPassword, credentials.HashedPassword))
                    {
                        roles = credentials.Roles;
                        return true;
                    }
                }
            }
            
            return false;
        }
        
        private string HashPassword(string password)
        {
            // Note: In a production environment, use a secure password hashing algorithm 
            // like BCrypt or PBKDF2 instead of a simple hash
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
    
    /// <summary>
    /// Stores user credentials
    /// </summary>
    internal class UserCredentials
    {
        public string HashedPassword { get; set; }
        public string[] Roles { get; set; }
    }
} 