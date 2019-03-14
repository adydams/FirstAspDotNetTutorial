using AspDotNet_Tutorial.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AspDotNet_Tutorial.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}