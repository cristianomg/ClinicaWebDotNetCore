using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class PacienteMapping : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nascimento).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PlanoID).IsRequired();
            builder.Property(x => x.Sexo).IsRequired().HasMaxLength(1);
            builder.Property(x => x.EnderecoId).IsRequired();

            builder.HasOne(x => x.Endereco);
        }
    }
}
