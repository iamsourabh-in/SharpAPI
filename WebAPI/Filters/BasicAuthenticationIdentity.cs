using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace WebAPI.Filters
{
    /// <summary>  
    /// Basic Authentication identity  
    /// </summary>  
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        /// <summary>  
        /// Get/Set for word  
        /// </summary>  
        public string Password
        {
            get;
            set;
        }
        /// <summary>  
        /// Get/Set for UserName  
        /// </summary>  
        public string UserName
        {
            get;
            set;
        }
        /// <summary>  
        /// Get/Set for UserId  
        /// </summary>  
        public long EmployeeId
        {
            get;
            set;
        }

        /// <summary>  
        /// Basic Authentication Identity Constructor  
        /// </summary>  
        /// <param name="userName"></param>  
        /// <param name="word"></param>  
        public BasicAuthenticationIdentity(string userName, string password)
            : base(userName, "Basic")
        {
            Password = password;
            UserName = userName;
        }
    }  
}