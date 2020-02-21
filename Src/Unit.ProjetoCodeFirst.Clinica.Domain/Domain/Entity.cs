using System;
using System.Collections.Generic;
using System.Text;

namespace Unit.ProjetoCodeFirst.Clinica.Domain.Domain
{
    public abstract class Entity 
    {
        public int Id { get; set; }

        public abstract bool Validar();
    }
}
