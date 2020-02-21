using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit.ProjetoCodeFirst.Clinica.Domain.Domain;
using Unit.ProjetoCodeFirst.Clinica.Infrastructure.Mapping;

namespace Unit.ProjetoCodeFirst.Clinica.Infrastructure.Context
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Atendimento> Atendimentos{ get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<ConsultaParticular> ConsultaParticulares{ get; set; }
        public DbSet<ConsultaPlano> ConsultaPlanos { get; set; }
        public DbSet<DiaSemana> DiaSemanas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<MedicoPlano> MedicosPlanos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PlanoExame> PlanosExames { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<PrescricaoMedicamento> PrescricaoMedicamentos { get; set; }
        public DbSet<RequisicaoExame> RequisicaoExames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e=> e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.ApplyConfiguration(new AtendimentoMapping());
            modelBuilder.ApplyConfiguration(new ConsultaMapping());
            modelBuilder.ApplyConfiguration(new ConsultaParticularMapping());
            modelBuilder.ApplyConfiguration(new ConsultaPlanoMapping());
            modelBuilder.ApplyConfiguration(new DiaSemanaMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new EspecialidadeMapping());
            modelBuilder.ApplyConfiguration(new EstadoMapping());
            modelBuilder.ApplyConfiguration(new ExameMapping());
            modelBuilder.ApplyConfiguration(new MedicoMapping());
            modelBuilder.ApplyConfiguration(new MedicoPlanoMapping());
            modelBuilder.ApplyConfiguration(new PacienteMapping());
            modelBuilder.ApplyConfiguration(new PlanoExameMapping());
            modelBuilder.ApplyConfiguration(new PlanoMapping());
            modelBuilder.ApplyConfiguration(new PrescricaoMedicamentoMapping());
            modelBuilder.ApplyConfiguration(new RequisicaoExameMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
