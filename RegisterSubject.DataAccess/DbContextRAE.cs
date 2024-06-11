using Microsoft.EntityFrameworkCore;
using RegisterSubject.DataAccess.Entityframework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataAccess
{
    public class DbContextRAE : DbContext
    {
        public DbContextRAE(DbContextOptions<DbContextRAE> options) :base(options)
        {
               
        }
        
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Profesor> Estudiantes { get; set; }
        public DbSet<Profesor> Programas { get; set; }
        public DbSet<AsignacionEstudiantil> AsignacionDeEstudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profesor>().ToTable("Profesor");
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");
            modelBuilder.Entity<Programa>().ToTable("Programa");
            modelBuilder.Entity<AsignacionEstudiantil>().ToTable("AsignacionEstudiantil");

        }
    }
}
