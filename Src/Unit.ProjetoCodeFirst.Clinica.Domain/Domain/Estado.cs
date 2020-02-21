using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Estado : Entity
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
