using Microsoft.EntityFrameworkCore;


namespace ProjetoAulaBackEnd.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options)
        { }
        public DbSet<Hospede> Hospedes { get; set; }
    }
}
