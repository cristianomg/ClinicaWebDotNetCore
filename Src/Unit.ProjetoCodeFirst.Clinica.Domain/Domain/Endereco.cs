using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Endereco : Entity
    {
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
