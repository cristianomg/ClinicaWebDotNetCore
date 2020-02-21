using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class MedicoPlanoMapping : IEntityTypeConfiguration<MedicoPlano>
    {
        public void Configure(EntityTypeBuilder<MedicoPlano> builder)
        {
            builder.HasKey(x => new { x.MedicoId, x.PlanoId });

            builder.HasOne(x => x.Medico)
                .WithMany(x => x.MedicoPlanos)
                .HasForeignKey(x => x.MedicoId);

            builder.HasOne(x => x.Plano)
                .WithMany(x => x.MedicoPlanos)
                .HasForeignKey(x => x.PlanoId);

        }
    }
}
