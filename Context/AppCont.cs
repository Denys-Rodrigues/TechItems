using Microsoft.EntityFrameworkCore;
using TechItems.Models;

namespace TechItems.Context
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
