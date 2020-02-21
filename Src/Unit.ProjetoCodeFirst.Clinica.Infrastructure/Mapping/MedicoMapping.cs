using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(150);
            builder.Property(x => x.EspecialidadeId).IsRequired();
            builder.Property(x => x.EnderecoId).IsRequired();
            builder.Property(x => x.Crm).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(11);

            builder.HasOne(x => x.Especialidade)
                .WithMany(x => x.Medicos)
                .HasForeignKey(x => x.EspecialidadeId);

            builder.HasOne(x => x.Endereco);
        }
    }
}
