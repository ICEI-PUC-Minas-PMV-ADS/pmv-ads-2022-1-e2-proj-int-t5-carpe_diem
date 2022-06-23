using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoAulaBackEnd.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<Hospede> Hospedes { get; set; }

        public DbSet<Imovel> Imoveis { get; set; }
    }
}