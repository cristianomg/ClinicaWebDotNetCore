using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping
{
    public class ConsultaParticularMapping : IEntityTypeConfiguration<ConsultaParticular>
    {
        public void Configure(EntityTypeBuilder<ConsultaParticular> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.FormaPagamento).IsRequired();

            builder.HasBaseType<Consulta>();
        }
    }
}
