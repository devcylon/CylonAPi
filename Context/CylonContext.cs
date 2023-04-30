using CylonApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace CylonApi.Contexts
{
    public class CylonContext : DbContext{
        public CylonContext()
        {
        }
        public CylonContext(DbContextOptions<CylonContext> options) : base(options)
        {  
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("User ID=sa;Password=464972006;" + "Server=localhost\\CYLON;" + "Database=CylonApi;Trusted_Connection=True;");
            }
        }
        public DbSet<Projeto> Projetos {get; set;}
    }
}