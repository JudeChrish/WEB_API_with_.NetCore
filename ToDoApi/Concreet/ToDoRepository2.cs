using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Abstract;
using ToDoApi.Models;

namespace ToDoApi.Concreet
{
    public class ToDoRepository2 : IToDoRepository
    {
        private readonly MvcWebApiContext apiContext;

        public ToDoRepository2(MvcWebApiContext webApiContext)
        {
            apiContext = webApiContext;
        }

        public IEnumerable<ToDoItem> TodoItems
        {
            get
            {
                return apiContext.ToDoItems.Where(w => w.Category == "MEN").OrderBy(o => o.Productid).Take(5);
            }

        }
    }
}
