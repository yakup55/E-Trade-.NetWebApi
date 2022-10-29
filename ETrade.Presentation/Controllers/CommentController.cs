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
    [Route("api/comments")]
    public class CommentController:ControllerBase
    {
        private readonly ICommentService service;

        public CommentController(ICommentService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult GetCommentList()
        {
            return Ok(service.GetCommentList());
        }
        [HttpGet("{id}")]
        public IActionResult GetOneComment([FromRoute(Name ="id")]int id)
        {
            return Ok(service.GetOneComment(id));
        }
        [HttpPost]
        public IActionResult AddComment([FromBody] CommentDto comment)
        {
            return Ok(service.AddComment(comment));
        }
        [HttpPut("{id}")]
        public IActionResult UpdateComment([FromBody]CommentDto comment,[FromRoute]int id)
        {
            return Ok(Accepted(service.UpdateComment(comment, id)));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteComment([FromRoute]int id)
        {
            service.DeleteComment(id);
            return NoContent();
        }
    }
}
