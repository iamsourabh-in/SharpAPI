using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;

namespace WebAPI.Filters
{
    /// <summary>  
    /// Custom Authentication Filter Extending basic Authentication  
    /// </summary>  
    public class APIAuthenticationFilter : GenericAuthenticationFilter
    {
        /// <summary>  
        /// Default Authentication Constructor  
        /// </summary>  
        public APIAuthenticationFilter() { }

        /// <summary>  
        /// AuthenticationFilter constructor with isActive parameter  
        /// </summary>  
        /// <param name="isActive"></param>  
        public APIAuthenticationFilter(bool isActive) : base(isActive) { }

        /// <summary>  
        /// Protected overriden method for authorizing user  
        /// </summary>  
        /// <param name="username"></param>  
        /// <param name="word"></param>  
        /// <param name="actionContext"></param>  
        /// <returns></returns>  
        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            actionContext.Request.Headers.Add("Access-Control-Allow-Origin", "*");
            var provider = actionContext.ControllerContext.Configuration.DependencyResolver.GetService(typeof(IEmployeeService)) as IEmployeeService;
            if (provider != null)
            {
                var userId = provider.Authenticate(username, password);
                if (userId > 0)
                {
                    var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
                    if (basicAuthenticationIdentity != null) basicAuthenticationIdentity.EmployeeId = userId;
                    return true;
                }
            }
            return false;
        }
    }

}