using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {

        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PacienteId).IsRequired();
            builder.Property(x => x.Data).IsRequired();

            builder.HasDiscriminator<string>("TipoConsulta")
                .HasValue<Consulta>("Consulta")
                .HasValue<ConsultaPlano>("ConsultaPlano")
                .HasValue<ConsultaParticular>("ConsultaParticula");

            builder.HasOne(x => x.Paciente)
                .WithMany(x => x.Consultas)
                .HasForeignKey(x => x.PacienteId);

            builder.HasMany(x => x.RequisicaoExames)
                .WithOne(x => x.Consulta)
                .HasForeignKey(x => x.ConsultaId);

            builder.HasMany(x => x.PrescricaoMedicamentos)
                .WithOne(x => x.Consulta)
                .HasForeignKey(x => x.ConsultaId);

        }
    }
}
