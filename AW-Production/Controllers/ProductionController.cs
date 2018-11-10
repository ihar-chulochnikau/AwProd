using AdventureWorks.Services.Productions;
using AW_Production.Filters;
using Serilog;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Web.Http;

namespace AW_Production.Controllers
{
    /// <summary>
    /// Production products controller
    /// </summary>
    [RoutePrefix("api/Products")]
    [SwaggerSchemaFilter(typeof(ProductFilter))]
    public class ProductionController : ApiController
    {
        private readonly IProductService _productService = new ProductService();

        /// <summary>
        /// List of products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            try
            {
                return Ok(_productService.GetProductInfos());
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id}/delete")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            try
            {
                return Ok(_productService.GetProduct(id));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Edit(Product product)
        {
            try
            {
                _productService.Edit(product);

                return Ok();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Create(Product product)
        {
            try
            {
                _productService.Create(product);

                return Ok(product);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                return BadRequest();
            }
        }
    }
}
