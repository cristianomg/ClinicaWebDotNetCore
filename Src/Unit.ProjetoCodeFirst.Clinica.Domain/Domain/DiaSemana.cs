using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class DiaSemana : Entity
    {
        public string Nome { get; set; }

        public virtual ICollection<Atendimento> Atendimentos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
