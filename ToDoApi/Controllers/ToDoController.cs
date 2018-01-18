using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Abstract;
using ToDoApi.Models;
using ToDoApi.Concreet;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly IToDoRepository toDoRepository;
        //private MvcWebApiContext _context;
        //public ToDoController(MvcWebApiContext context)
        //{
        //    _context = context;
        //}

        public ToDoController(IToDoRepository ToDoRepository)
        {
            toDoRepository = ToDoRepository;
        }

        //[HttpGet]
        //public IEnumerable<ToDoItem> GetAllItems()
        //{
        //    return _context.ToDoItems.ToList();
        //}

        [HttpGet]
        public IEnumerable<ToDoItem> GetAllItems()
        {
            return toDoRepository.TodoItems.ToList();
        }

        //[HttpGet]
        //public ToDoItem GetByID(int id)
        //{
        //    return toDoRepository.TodoItems.FirstOrDefault(f => f.Productid == id);
        //}

        // GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
