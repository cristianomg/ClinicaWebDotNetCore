using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Especialidade : Entity
    {
        public string Descricao { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
