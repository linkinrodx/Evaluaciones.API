using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proyecto.Evaluacion.API.Models;

namespace Proyecto.Evaluacion.API.Infraestructure.Context
{
    public partial class EvaluacionContext : DbContext
    {
        public EvaluacionContext()
        {
        }

        public EvaluacionContext(DbContextOptions<EvaluacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Evaluacion> Evaluacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Models.Evaluacion>(entity =>
            {
                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}