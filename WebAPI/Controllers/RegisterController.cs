using AttributeRouting.Web.Http;
using BusinessEntities;
using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.ErrorHelper;
using BusinessServices.Models;

namespace WebAPI.Controllers
{
    public class RegisterController : ApiController
    {

        private readonly IEmployeeService _employeeServices;
        private readonly IDBExecutor _db;

        #region Public Constructor

        /// <summary>  
        /// Public constructor to initialize product service instance  
        /// </summary> 

        public RegisterController(IEmployeeService employeeServices, IDBExecutor db)
        {
            _employeeServices = employeeServices;
            _db = db;

        }
        #endregion
        /// <summary>  
        /// Register Employee
        /// </summary>  
        /// <returns></returns>  
        [Route("api/register/employee")]
        public HttpResponseMessage Employee([FromBody] EmployeeEntity employeeEntity)
        {
            if (employeeEntity != null)
            {
                long empId = _employeeServices.CreateEmployee(employeeEntity);
                return Request.CreateResponse(HttpStatusCode.OK, empId);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Company not found");


        }
        [HttpGet]
        [Route("api/register/company")]
        public HttpResponseMessage all()
        {
            _db.Execute();
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Company not found");

        }


    }
}
