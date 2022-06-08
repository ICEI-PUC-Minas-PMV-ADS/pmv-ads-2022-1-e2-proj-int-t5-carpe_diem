using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoAulaBackEnd.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options)
        { }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Image> Image { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string cns = "Server=(localdb)\\mssqllocaldb;Database=DBCarpeDiemEdu;Trusted_Connection=True;";
            cns += "MultipleActiveResultSets=true;";
            optionsBuilder
           .UseSqlServer(cns,
            c => { });
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(ImageMap.Create());
        }
    }
}
