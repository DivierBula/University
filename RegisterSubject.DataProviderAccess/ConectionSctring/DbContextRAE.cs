using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RegisterSubject.DataProviderAccess
{
    public partial class DbContextRAE : DbContext
    {
        public DbContextRAE()
            : base("name=EntityFramework")
        {
        }

        public virtual DbSet<AsignacionEstudiantil> AsignacionesDeEstudiantes { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Profesor> Profesores { get; set; }
        public virtual DbSet<Programa> Programas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profesor>().ToTable("Profesor");
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");
            modelBuilder.Entity<Programa>().ToTable("Programa");
            modelBuilder.Entity<AsignacionEstudiantil>().ToTable("AsignacionEstudiantil");


            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.Creditos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Programa>()
                .Property(e => e.DuracionEnDias)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
