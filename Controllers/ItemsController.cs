using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webapi_antiforgery.Controllers
{

    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
    private TodoRepository repository;
    
    public ItemsController (TodoRepository repo)
    {
      repository = repo;
    }
        // GET api/items
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return repository.GetItems();
        }

        // POST api/values
        [ValidateAntiForgeryTokenAttribute]
        [HttpPost]
        public void Post([FromBody]TodoItem item)
        {
            repository.Add(item);
        }

    }
}
