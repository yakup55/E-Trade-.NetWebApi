using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Presentation.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetAllCategoryList()
        {
            return Ok(service.GetCategoriesList());
        }
        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryDto categoryDto)
        {
            service.AddCategory(categoryDto);
            return Ok(categoryDto);
        }
        [HttpGet("{id}")]
        public IActionResult GetOneCategory([FromRoute(Name = "id")] int id)
        {
            var category = service.GetCategoryById(id);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            service.DeleteCategory(id);
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateCategory([FromRoute] int id, [FromBody] Category category)
        {
            return Accepted(service.UpdateCategory(category, id));
        }
        [HttpGet("getlastcategory")]
        public IActionResult GetLastCategory()
        {
            return Ok(service.LastCategory());
        }
        [HttpGet("popularcategory")]
        public IActionResult PopularCategory()
        {
            return Ok(service.GetCategoriesList().Where(x => x.CategoryId == 8 || x.CategoryId == 1 || x.CategoryId == 5 || x.CategoryId == 6).ToList());
        }
    }
}
