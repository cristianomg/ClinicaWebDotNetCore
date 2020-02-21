using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class AtendimentoMapping : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.HoraInicio).IsRequired();
            builder.Property(x => x.HoraFim).IsRequired();
            builder.Property(x => x.MedicoId).IsRequired();
            builder.Property(x => x.ConsultaID).IsRequired();
            builder.Property(x => x.DiaSemanaId).IsRequired();

            builder.HasOne(a => a.Medico)
                .WithMany(m => m.Atendimentos)
                .HasForeignKey(x => x.MedicoId)
                .IsRequired();

            builder.HasOne(a => a.Consulta)
                .WithOne(c => c.Atendimento)
                .HasForeignKey<Atendimento>(x => x.ConsultaID)
                .IsRequired();

            builder.HasOne(a => a.DiaSemana)
                .WithMany(d => d.Atendimentos)
                .HasForeignKey(x => x.DiaSemanaId);

        }
    }
}
