using BlazorSanbox.Classes;
using Microsoft.EntityFrameworkCore;

namespace BlazorSanbox.DataBase
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> otions) : base(otions)
        {

        }

        public DbSet<Country> Country { get;set; }
    }
}
