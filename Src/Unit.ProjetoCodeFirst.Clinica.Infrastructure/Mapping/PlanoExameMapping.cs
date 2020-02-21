using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class PlanoExameMapping : IEntityTypeConfiguration<PlanoExame>
    {
        public void Configure(EntityTypeBuilder<PlanoExame> builder)
        {
            builder.HasKey(x => new { x.ExameId, x.PlanoId });

            builder.HasOne(x => x.Exame)
                .WithMany(x => x.PlanosExame)
                .HasForeignKey(x => x.ExameId);

            builder.HasOne(x => x.Plano)
                .WithMany(x => x.PlanosExame)
                .HasForeignKey(x => x.PlanoId);
        }
    }
}
