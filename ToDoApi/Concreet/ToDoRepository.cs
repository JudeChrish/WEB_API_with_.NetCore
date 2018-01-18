using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Abstract;
using ToDoApi.Models;

namespace ToDoApi.Concreet
{
    public class ToDoRepository : IToDoRepository
    {
        //private MvcWebApiContext mvcWebApiCONTEXT = new MvcWebApiContext();

        private readonly MvcWebApiContext mvcWebApiContext;
        public ToDoRepository(MvcWebApiContext apiContext)
        {
            mvcWebApiContext = apiContext;
        }

        public IEnumerable<ToDoItem> TodoItems
        {
            get
            {
                return mvcWebApiContext.ToDoItems.ToList();
            }
        }
    }
}
