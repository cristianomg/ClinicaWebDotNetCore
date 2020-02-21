using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class PlanoExame 
    {
        public int PlanoId { get; set; }
        public int ExameId { get; set; }

        public virtual Plano Plano { get; set; }
        public virtual Exame Exame { get; set; }

    }
}
