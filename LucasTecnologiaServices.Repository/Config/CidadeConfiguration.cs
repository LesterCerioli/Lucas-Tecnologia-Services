using LucasTecnologiaServices.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Repository.Config
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cidade> builder)
        {
            throw new NotImplementedException();
        }
    }
}
