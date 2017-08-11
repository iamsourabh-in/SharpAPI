using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using WebApi.ErrorHelper;
namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserServices _userServices;

        #region Public Constructor

        /// <summary>  
        /// Public constructor to initialize product service instance  
        /// </summary> 

        public UserController(IUserServices userService)
        {
            _userServices = userService;

        }

        #endregion

        // GET api/product  
        public HttpResponseMessage Get()
        {
            var users = _userServices.GetAllUsers();
            if (users != null)
            {
                var userEntities = users as List<UserEntity> ?? users.ToList();
                if (userEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, userEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }

        // GET api/product/5 

        public HttpResponseMessage Post(UserEntity user)
        {
            if (user != null)
            {
                var product = _userServices.CreateUser(user);
                if (product != null)
                    return Request.CreateResponse(HttpStatusCode.OK, product);

                throw new ApiDataException(1001, "No user found for this id.", HttpStatusCode.NotFound);
            }
            throw new ApiException() { ErrorCode = (int)HttpStatusCode.BadRequest, ErrorDescription = "Bad Request..." };
        }
    }
}
