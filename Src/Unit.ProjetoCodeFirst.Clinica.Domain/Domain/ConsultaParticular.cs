using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class ConsultaParticular : Consulta
    {
        public float Valor { get; set; }
        public string FormaPagamento { get; set; }

    }
}
