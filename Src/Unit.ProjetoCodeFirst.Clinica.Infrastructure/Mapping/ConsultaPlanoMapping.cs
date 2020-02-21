using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class ConsultaPlanoMapping : IEntityTypeConfiguration<ConsultaPlano>
    {
        public void Configure(EntityTypeBuilder<ConsultaPlano> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.PlanoId);
            builder.HasOne(x => x.Plano)
                .WithMany(x => x.ConsultasPlano)
                .HasForeignKey(x => x.PlanoId);
        }
    }
}
