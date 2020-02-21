using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class ConsultaPlano : Consulta
    {
        public int PlanoId { get; set; }
        public virtual Plano Plano { get; set; }
    }
}
