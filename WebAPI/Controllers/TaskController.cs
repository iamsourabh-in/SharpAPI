using BusinessEntities;
using BusinessServices;
using BusinessServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Filters;
using WebAPI.Extentions;

namespace WebAPI.Controllers
{
    public class TaskController : ApiController
    {
        private readonly ITaskService _taskService;

        #region Public Constructor

        /// <summary>  
        /// Public constructor to initialize product service instance  
        /// </summary> 

        public TaskController(ITaskService taskServices)
        {
            _taskService = taskServices;
        }

        #endregion

        // GET api/company
        //[AuthorizeRoleFilter("Company", "Read")]
        public HttpResponseMessage Get(long id)
        {
            try
            {
                var tasks = _taskService.GetAllTasks(id);
                if (tasks != null)
                {
                    var taskEntities = tasks as List<TaskEntity> ?? tasks.ToList();

                    if (taskEntities.Any())
                        return Request.CreateResponse(HttpStatusCode.OK, taskEntities);
                }
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No tasks found");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
