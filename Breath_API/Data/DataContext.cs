using Breath_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Breath_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users {get;set;}
    }
}