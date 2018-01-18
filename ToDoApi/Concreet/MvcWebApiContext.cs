using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoApi.Concreet
{
    public class MvcWebApiContext : DbContext
    {
     
        public MvcWebApiContext(DbContextOptions<MvcWebApiContext> options)
            : base(options)
        {       
         
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

    }
}
