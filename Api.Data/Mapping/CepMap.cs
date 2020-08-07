using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mapping
{
    public class CepMap : IEntityTypeConfiguration<CepEntity>
    {
        public void Configure(EntityTypeBuilder<CepEntity> builder)
        {
            builder.ToTable("Cep");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Cep);
            builder.HasOne(m => m.Municipio).WithMany(c => c.Ceps);
        }
    }
}
