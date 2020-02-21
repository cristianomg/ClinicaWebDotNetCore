using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Exame : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }

        public virtual ICollection<PlanoExame> PlanosExame { get; set; }
        public virtual ICollection<RequisicaoExame> RequisicaoExames{ get; set; }


        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
