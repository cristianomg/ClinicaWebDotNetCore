using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Paciente : Entity
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public int EnderecoId { get; set; }
        public int PlanoID { get; set; }

        public virtual Plano Plano { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
