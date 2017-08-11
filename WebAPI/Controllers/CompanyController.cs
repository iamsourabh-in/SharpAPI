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
    public class CompanyController : ApiController
    {


        private readonly ICompanyService _companyServices;
        private readonly IDBExecutor _db;

        #region Public Constructor

        /// <summary>  
        /// Public constructor to initialize product service instance  
        /// </summary> 

        public CompanyController(ICompanyService companyServices, IDBExecutor db)
        {
            _companyServices = companyServices;
            _db = db;

        }

        #endregion

        // GET api/company
        //[AuthorizeRoleFilter("Company", "Read")]
        public HttpResponseMessage Get()
        {
            var companies = _companyServices.GetAllCompany();
            if (companies != null)
            {
                var companyEntities = companies as List<CompanyEntity> ?? companies.ToList();
                
                if (companyEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, companyEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No companies found");
        }

        // GET api/company/5 
        [AuthorizeRoleFilter("Company", "Read")]
        public HttpResponseMessage Get(long id)
        {

            var company = _companyServices.GetCompanyById(id);
            if (company != null)
            {
                var companyEntities = company as CompanyEntity ?? company;
                if (companyEntities != null)
                    return Request.CreateResponse(HttpStatusCode.OK, companyEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Company not found");
        }

        // POST api/company 
        [AuthorizeRoleFilter("Company", "Create")]
        public long Post([FromBody] CompanyEntity companyEntity)
        {
            return _companyServices.CreateCompany(companyEntity);
        }

        // PUT api/company/5 
        [AuthorizeRoleFilter("Company", "Update")]
        public bool Put(long id, [FromBody]CompanyEntity companyEntity)
        {
            if (id > 0)
            {
                return _companyServices.UpdateCompany(id, companyEntity);
            }
            return false;
        }

        // DELETE api/company/5 
        [AuthorizeRoleFilter("Company", "Remove")]
        public bool Delete(long id)
        {
            if (id > 0)
                return _companyServices.DeleteCompany(id);
            return false;
        }

    }
}
