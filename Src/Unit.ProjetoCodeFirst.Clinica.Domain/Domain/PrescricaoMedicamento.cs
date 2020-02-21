using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class PrescricaoMedicamento : Entity
    {
        public string Medicamento { get; set; }
        public string FormaUso { get; set; }
        public int ConsultaId { get; set; }

        public virtual Consulta Consulta { get; set; }


        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
