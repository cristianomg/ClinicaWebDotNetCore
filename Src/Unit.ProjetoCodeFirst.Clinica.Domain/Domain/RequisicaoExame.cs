using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class RequisicaoExame : Entity
    {
        public DateTime DataRequisicao { get; set; }
        public int Situacao { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int ExameId { get; set; }
        public int ConsultaId { get; set; }

        public virtual Exame Exame { get; set; }
        public virtual Consulta Consulta { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
