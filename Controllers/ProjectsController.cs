using CemrePortfolio.Data;
using CemrePortfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace CemrePortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly JsonDataService _data;

        public ProjectsController(JsonDataService data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<List<Project>> GetAll() => Ok(_data.GetProjects());

        [HttpGet("{id}")]
        public ActionResult<Project> GetById(int id)
        {
            var project = _data.GetProjects().FirstOrDefault(p => p.Id == id);
            return project == null ? NotFound() : Ok(project);
        }
    }
}