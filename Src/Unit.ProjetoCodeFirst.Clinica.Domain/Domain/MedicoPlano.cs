using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class MedicoPlano
    {
        public int MedicoId { get; set; }
        public int PlanoId { get; set; }

        public virtual Medico Medico { get; set; }
        public virtual Plano Plano { get; set; }
    }
}
