using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using BusinessServices;
using AttributeRouting;
using AttributeRouting.Web.Http;
using WebAPI.Filters;
using WebAPI.ActionFilters;
using WebApi.ErrorHelper;

namespace WebAPI.Controllers
{
    [AuthorizationRequired]
    public class ProductController : ApiController
    {

        private readonly IProductServices _productServices;

        #region Public Constructor

        /// <summary>  
        /// Public constructor to initialize product service instance  
        /// </summary> 

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;  

        }

        #endregion
        
        // GET api/product  
        public HttpResponseMessage Get()
        {
            var products = _productServices.GetAllProducts();
            if (products != null)
            {
                var productEntities = products as List<ProductEntity> ?? products.ToList();
                if (productEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, productEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }

        // GET api/product/5 

        public HttpResponseMessage Get(int id)
        {
            if (id != null)
            {
                var product = _productServices.GetProductById(id);
                if (product != null)
                    return Request.CreateResponse(HttpStatusCode.OK, product);

                throw new ApiDataException(1001, "No product found for this id.", HttpStatusCode.NotFound);
            }
            throw new ApiException() { ErrorCode = (int)HttpStatusCode.BadRequest, ErrorDescription = "Bad Request..." };
        }  

        // POST api/product 
        public int Post([FromBody] ProductEntity productEntity)
        {
            return _productServices.CreateProduct(productEntity);
        }

        // PUT api/product/5  
        public bool Put(int id, [FromBody]ProductEntity productEntity)
        {
            if (id > 0)
            {
                return _productServices.UpdateProduct(id, productEntity);
            }
            return false;
        }

        // DELETE api/product/5  
        public bool Delete(int id)
        {
            if (id > 0)
                return _productServices.DeleteProduct(id);
            return false;
        }
    }
}
