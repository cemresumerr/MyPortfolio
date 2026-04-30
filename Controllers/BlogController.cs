using CemrePortfolio.Data;
using CemrePortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace CemrePortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly JsonDataService _data;

        public BlogController(JsonDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<List<BlogPost>> GetAll() => Ok(_data.GetBlogPosts());

        [HttpGet("{id}")]
        public ActionResult<BlogPost> GetById(int id)
        {
            var post = _data.GetBlogPosts().FirstOrDefault(p => p.Id == id);
            return post == null ? NotFound() : Ok(post);
        }
    }
}