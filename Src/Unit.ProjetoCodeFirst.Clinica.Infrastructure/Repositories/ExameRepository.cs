﻿using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Contracts.Repositories;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;
using Unit.ProjetoCodeFirst.Clinica.Infrastructure.Context;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Repositories
{
    public class ExameRepository : Repository<Exame>, IExameRepository
    {
        public ExameRepository(ClinicaDbContext context) : base(context)
        {

        }
    }
}