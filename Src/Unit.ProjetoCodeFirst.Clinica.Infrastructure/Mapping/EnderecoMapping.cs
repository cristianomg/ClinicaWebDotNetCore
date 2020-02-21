using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(50);
            builder.Property(x => x.EstadoId).IsRequired();
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(11);

            builder.HasOne(x => x.Estado)
                .WithMany(x => x.Enderecos)
                .HasForeignKey(x => x.EstadoId)
                .IsRequired();
        }
    }
}
