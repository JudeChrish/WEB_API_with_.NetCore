using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Models;

namespace ToDoApi.Abstract
{
    public interface IToDoRepository
    {
      IEnumerable<ToDoItem> TodoItems { get; }
    }
}
