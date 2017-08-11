using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApi.ErrorHelper;

namespace WebAPI.Filters
{

    public class AuthorizeRoleFilter : ActionFilterAttribute
    {
        private string _actionOn;
        private string _actionType;

        /// <summary>
        /// If this action is allowed in the role assigned to the employee : Allow employe to perform action.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="actionType"></param>
        public AuthorizeRoleFilter(string actionOn, string actionType)
        {
            _actionOn = actionOn;
            _actionType = actionType;
        }
        public override void OnActionExecuting(HttpActionContext filterContext)
        {
            if (AuthTokenExists(filterContext))
            {
                string token = filterContext.Request.Headers.GetValues("Token").First();
                var provider = filterContext.ControllerContext.Configuration.DependencyResolver.GetService(typeof(IAuthorizeService)) as IAuthorizeService;
                if (provider != null)
                {
                    bool isValid = provider.AuthorizeAccess(token, _actionOn, _actionType);
                    if (!isValid)
                    {
                        filterContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    }
                }
            }
            else
            {
                filterContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }

            // bool accessAllowed = authorizeService.IsEmployeeAuthorized(token,_actionOn,_actionType)
        }
        public bool AuthTokenExists(HttpActionContext filterContext)
        {
            IEnumerable<string> token;
            return filterContext.Request.Headers.TryGetValues("Token", out token);
        }

    }

}