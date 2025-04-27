using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;

namespace LILO_WebEngine.Core.Security
{
    /// <summary>
    /// Result of an authentication attempt
    /// </summary>
    public class AuthenticationResult
    {
        /// <summary>
        /// Whether authentication was successful
        /// </summary>
        public bool IsAuthenticated { get; set; }
        
        /// <summary>
        /// The authenticated user (if successful)
        /// </summary>
        public IPrincipal User { get; set; }
        
        /// <summary>
        /// Error message (if authentication failed)
        /// </summary>
        public string ErrorMessage { get; set; }
    }
    
    /// <summary>
    /// Interface for authentication providers
    /// </summary>
    public interface IAuthenticationProvider
    {
        /// <summary>
        /// Authenticates a request
        /// </summary>
        Task<AuthenticationResult> AuthenticateAsync(HttpListenerRequest request);
        
        /// <summary>
        /// Determines if a path requires authentication
        /// </summary>
        bool RequiresAuthentication(string path);
    }
    
    /// <summary>
    /// Simple implementation of IPrincipal for HTTP authentication
    /// </summary>
    public class WebUser : IPrincipal
    {
        /// <summary>
        /// The user's identity
        /// </summary>
        public IIdentity Identity { get; }
        
        /// <summary>
        /// The user's roles
        /// </summary>
        public string[] Roles { get; }
        
        /// <summary>
        /// Creates a new web user
        /// </summary>
        public WebUser(string userName, string[] roles)
        {
            Identity = new WebIdentity(userName);
            Roles = roles ?? new string[0];
        }
        
        /// <summary>
        /// Checks if the user is in a role
        /// </summary>
        public bool IsInRole(string role)
        {
            if (string.IsNullOrEmpty(role) || Roles == null)
            {
                return false;
            }
            
            foreach (var userRole in Roles)
            {
                if (userRole.Equals(role, System.StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
    
    /// <summary>
    /// Simple implementation of IIdentity for HTTP authentication
    /// </summary>
    public class WebIdentity : IIdentity
    {
        /// <summary>
        /// Authentication type
        /// </summary>
        public string AuthenticationType => "Basic";
        
        /// <summary>
        /// Whether the user is authenticated
        /// </summary>
        public bool IsAuthenticated => !string.IsNullOrEmpty(Name);
        
        /// <summary>
        /// The user's name
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Creates a new web identity
        /// </summary>
        public WebIdentity(string name)
        {
            Name = name;
        }
    }
} 