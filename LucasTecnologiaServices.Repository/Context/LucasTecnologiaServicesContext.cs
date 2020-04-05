using LucasTecnologiaServices.Domain.Entidades;
using LucasTecnologiaServices.Repository.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Repository.Context
{
    public class LucasTecnologiaServicesContext : DbContext
    {


        public DbSet<Cidade> Cidades { get; set; }

        
        
        public LucasTecnologiaServicesContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());

        }
        



        
    }
}
