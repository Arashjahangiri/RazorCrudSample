using Microsoft.EntityFrameworkCore;
using RazorCrudSample.Model.Entities;

namespace RazorCrudSample.Model.Context
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {
                
        }

        public DbSet<Product>  Products{ get; set; }


    }
}
