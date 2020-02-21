using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class RequisicaoExameMapping : IEntityTypeConfiguration<RequisicaoExame>
    {
        public void Configure(EntityTypeBuilder<RequisicaoExame> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ExameId).IsRequired();
            builder.Property(x => x.DataAgendamento).IsRequired();
            builder.Property(x => x.DataRequisicao).IsRequired();
            builder.Property(x => x.ConsultaId).IsRequired();

            builder.HasOne(x => x.Consulta)
                .WithMany(x => x.RequisicaoExames)
                .HasForeignKey(x => x.ConsultaId);

            builder.HasOne(x => x.Exame)
                .WithMany(x => x.RequisicaoExames)
                .HasForeignKey(x => x.ExameId);
        }
    }
}
