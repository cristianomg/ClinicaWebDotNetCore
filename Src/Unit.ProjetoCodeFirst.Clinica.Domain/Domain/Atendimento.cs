using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Atendimento : Entity
    {
        public DateTime HoraInicio{ get; set; }
        public DateTime HoraFim { get; set; }
        public bool AtendePlano { get; set; }
        public bool AtendeDia { get; set; }
        public int DiaSemanaId { get; set; }
        public int ConsultaID { get; set; }
        public int MedicoId { get; set; }

        public virtual Medico Medico { get; set; }
        public virtual Consulta Consulta { get; set; }
        public virtual DiaSemana DiaSemana { get; set; }
        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
