using Microsoft.EntityFrameworkCore;
using MvcRepsetiory.Models;

namespace MvcRepsetiory.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {


        }
        public DbSet<Product> products { get; set; }
    }
}
