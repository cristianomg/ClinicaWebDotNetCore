using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Plano : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<PlanoExame> PlanosExame { get; set; }
        public virtual ICollection<ConsultaPlano> ConsultasPlano { get; set; }
        public virtual ICollection<MedicoPlano> MedicoPlanos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
    