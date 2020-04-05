using LucasTecnologiaServices.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Repository.Config
{
    public class PFConfiguration : IEntityTypeConfiguration<PF>
    {
        public void Configure(EntityTypeBuilder<PF> builder)
        {
            throw new NotImplementedException();
        }
    }
}
