using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    public class Consulta : Entity
    {
        /// <summary>
        /// done
        /// </summary>
        public DateTime Data { get; set; }
        public int PacienteId { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public virtual ICollection<RequisicaoExame> RequisicaoExames { get; set; }
        public virtual ICollection<PrescricaoMedicamento> PrescricaoMedicamentos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
