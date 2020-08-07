using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mapping
{
    public class MunicipioMap : IEntityTypeConfiguration<MunicipioEntity>
    {
        public void Configure(EntityTypeBuilder<MunicipioEntity> builder)
        {
            builder.ToTable("Municipio");
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.CodIbge);
            builder.Property(p => p.Nome).IsRequired();
            builder.HasOne(u => u.Uf).WithMany(m => m.Municipios);
        }
    }
}
