using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    /// <summary>
    /// done
    /// </summary>
    public class Medico : Entity
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public int EspecialidadeId { get; set; }

        public Especialidade Especialidade { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
        public virtual ICollection<MedicoPlano> MedicoPlanos { get; set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
