using Microsoft.EntityFrameworkCore;

namespace WebCRUDSQLServer.Models
{
    public class Contexto : DbContext
    { 
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
