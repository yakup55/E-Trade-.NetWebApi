using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }
        [HttpGet("getlastproduct")]
        public IActionResult GetLastProduct()
        {
            
            return Ok(service.GetLastProduct().Where(x=>x.ProductStatus==true).ToList());
        }
        [HttpGet]
        public IActionResult GetProductList()
        {
            return Ok(service.GetProductList().Where(x=>x.ProductStatus==true).ToList());
        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDto product)
        {
            
            service.AddProduct(product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            service.DeleteProduct(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody] Product product, [FromRoute] int id)
        {
            return Accepted(service.UpdateProduct(product, id));
        }
        [HttpGet("{id}")]
        public IActionResult GetOneProduct([FromRoute(Name = "id")]int id )
        {
            var one =service.GetOneProduct(id);
            return Ok(one);
        }
        [HttpGet("getallproductwithdetaillist")]
        public IActionResult GetAllProductWithDetailList()
        {
            return Ok(service.GetAllProductWithDetailList().Where(x=>x.CategoryId==1).ToList());
        }
        [HttpGet("getoneproductwithdetail/{id:int}")]
        public IActionResult GetOneProductWithDetail([FromRoute(Name ="id")]int id)
        {
            return Ok(service.GetOneProductWithDetail(id));
        }
        [HttpGet("getonepcproductwithdetail/{id:int}")]
        public IActionResult GetOnePcProductWithDetail([FromRoute(Name ="id")]int id)
        {
            return Ok(service.GetOnePcProductWithDetail(id));
        }
        [HttpGet("productcategory/{id:int}")]
        public IActionResult ProductCategory([FromRoute()]int id)
        {
            return Ok(service.GetProductList().Where(x => x.CategoryId == id && x.ProductStatus==true));
        }
        [HttpGet("popularproduct")]
        public IActionResult PopularProduct()
        {
            return Ok(service.GetProductList().Where(x => x.ProductId ==18 || x.ProductId==15 || x.ProductId == 12 || x.ProductId == 21 || x.ProductId == 22 || x.ProductId == 30 &&x.ProductStatus==true).ToList());
        }
    }
}
