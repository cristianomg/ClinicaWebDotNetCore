using System;
using System.Collections.Generic;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Contracts;
using Unit.ProjetoCodeFirst.Clinica.Domain.Contracts.Repositories;
using Unit.ProjetoCodeFirst.Clinica.Infrastructure.Context;
using Unit.ProjetoCodeFirst.Clinica.Infrastructure.Repositories;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClinicaDbContext _context;

        public UnitOfWork(ClinicaDbContext context)
        {
            _context = context;
        }
        // repositories
        private IAtendimentoRepository atendimentoRepository;
        private IConsultaRepository consultaRepository;
        private IDiaSemanaRepository diaSemanaRepository;
        private IEnderecoRepository enderecoRepository;
        private IEspecialidadeRepository especialidadeRepository;
        private IEstadoRepository estadoRepository;
        private IExameRepository exameRepository;
        private IMedicoRepository medicoRepository;
        private IPacienteRepository pacienteRepository;
        private IPlanoRepository planoRepository;
        private IPrescricaoMedicamento prescricaoMedicamentoRepository;
        private IRequisicaoExameRepository requisicaoExameRepository;


        public IAtendimentoRepository AtendimentoRepository
        {
            get 
            { 
                if (atendimentoRepository == null)
                {
                    atendimentoRepository = new AtendimentoRepository(_context);
                } 
                return atendimentoRepository; 
            }
        }

        public IConsultaRepository ConsultaRepository
        {
            get
            {
                if (consultaRepository == null)
                {
                    consultaRepository = new ConsultaRepository(_context);
                }
                return consultaRepository;
            }
        }

        public IDiaSemanaRepository DiaSemanaRepository
        {
            get
            {
                if (diaSemanaRepository == null)
                {
                    diaSemanaRepository = new DiaSemanaRepository(_context);
                }
                return diaSemanaRepository;
            }
        }

        public IEnderecoRepository EnderecoRepository
        {
            get
            {
                if (enderecoRepository == null)
                {
                    enderecoRepository = new EnderecoRepository(_context);
                }
                return enderecoRepository;
            }
        }

        public IEspecialidadeRepository EspecialidadeRepository
        {
            get
            {
                if (especialidadeRepository == null)
                {
                    especialidadeRepository = new EspecialidadeRepository(_context);
                }
                return especialidadeRepository;
            }
        }

        public IEstadoRepository EstadoRepository
        {
            get
            {
                if (estadoRepository == null)
                {
                    estadoRepository = new EstadoRepository(_context);
                }
                return estadoRepository;
            }
        }

        public IExameRepository ExameRepository
        {
            get
            {
                if (exameRepository == null)
                {
                    exameRepository = new ExameRepository(_context);
                }
                return exameRepository;
            }
        }

        public IMedicoRepository MedicoRepository
        {
            get
            {
                if (medicoRepository == null)
                {
                    medicoRepository = new MedicoRepository(_context);
                }
                return medicoRepository;
            }
        }

        public IPacienteRepository PacienteRepository
        {
            get
            {
                if (pacienteRepository == null)
                {
                    pacienteRepository = new PacienteRepository(_context);
                }
                return pacienteRepository;
            }
        }

        public IPlanoRepository PlanoRepository
        {
            get
            {
                if (planoRepository == null)
                {
                    planoRepository = new PlanoRepository(_context);
                }
                return planoRepository;
            }
        }

        public IPrescricaoMedicamento PrescricaoMedicamentoRepository
        {
            get
            {
                if (prescricaoMedicamentoRepository == null)
                {
                    prescricaoMedicamentoRepository = new PrescricaoMedicamentoRepository(_context);
                }
                return prescricaoMedicamentoRepository;
            }
        }

        public IRequisicaoExameRepository RequisicaoExameRepository
        {
            get
            {
                if (requisicaoExameRepository == null)
                {
                    requisicaoExameRepository = new RequisicaoExameRepository(_context);
                }
                return requisicaoExameRepository;
            }
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            AtendimentoRepository.Dispose();
            ConsultaRepository.Dispose();
            DiaSemanaRepository.Dispose();
            EnderecoRepository.Dispose();
            EspecialidadeRepository.Dispose();
            EstadoRepository.Dispose();
            ExameRepository.Dispose();
            MedicoRepository.Dispose();
            PacienteRepository.Dispose();
            PlanoRepository.Dispose();
            PrescricaoMedicamentoRepository.Dispose();
            RequisicaoExameRepository.Dispose();
        }
    }
}
