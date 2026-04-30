using System.Text.Json;
using CemrePortfolio.Models;



namespace CemrePortfolio.Data
{
    public class JsonDataService
    {
        private readonly string _dataPath;

        public JsonDataService(IWebHostEnvironment env)
        {
            _dataPath = Path.Combine(env.WebRootPath, "data");

        }

        public List<Project> GetProjects()
        {
            var json = File.ReadAllText(Path.Combine(_dataPath, "projects.json"));
            return JsonSerializer.Deserialize<List<Project>>(json) ?? new();
        }

        public List<BlogPost> GetBlogPosts()
        {
            var json = File.ReadAllText(Path.Combine(_dataPath, "blog.json"));
            return JsonSerializer.Deserialize<List<BlogPost>>(json) ?? new();
        }
    }
}
