using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class PrescricaoMedicamentoMapping : IEntityTypeConfiguration<PrescricaoMedicamento>
    {
        public void Configure(EntityTypeBuilder<PrescricaoMedicamento> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Medicamento).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FormaUso).IsRequired().HasMaxLength(250);

            builder.HasOne(x => x.Consulta)
                .WithMany(x => x.PrescricaoMedicamentos)
                .HasForeignKey(x => x.ConsultaId);


        }
    }
}
