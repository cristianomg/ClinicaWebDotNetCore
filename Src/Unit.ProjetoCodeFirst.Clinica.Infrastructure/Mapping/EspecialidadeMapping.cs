using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class EspecialidadeMapping : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(150);

        }
    }
}
