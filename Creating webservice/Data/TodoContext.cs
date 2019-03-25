using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creating webservice.Data 
{
    public class TodoContext:DbContext

{
    public TodoContext(DbContextOptions<TodoContext>options)
        : base(options)
    {

    }
    public DbSet<TodoItem> ToDoItems { get; set; }

}
}
