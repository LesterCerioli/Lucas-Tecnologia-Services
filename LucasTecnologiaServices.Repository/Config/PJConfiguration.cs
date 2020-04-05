using LucasTecnologiaServices.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LucasTecnologiaServices.Repository.Config
{
    public class PJConfiguration : IEntityTypeConfiguration<PJ>
    {
        public void Configure(EntityTypeBuilder<PJ> builder)
        {
            throw new NotImplementedException();
        }
    }
}
