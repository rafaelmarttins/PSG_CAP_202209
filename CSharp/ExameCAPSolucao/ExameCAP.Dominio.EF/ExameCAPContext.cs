using ExameCAP.Dominio.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameCAP.Dominio.EF
{
    public partial class ExameCAPContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public DbSet<Passageiro> Passageiros { get; set; } = null!;
        public DbSet<Bilhete> Bilhetes { get; set; } = null!;

        public ExameCAPContext() : base()
        { }

        public ExameCAPContext(DbContextOptions<ExameCAPContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Aqui ficava a Connection StrinSg.
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

