using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.DataProviderAccess
{
    public class StudentAccess : IStudentProvider<StudentDAO>
    {
        private readonly DbContextRAE _context;

        #region Ctor
        public StudentAccess()
        {
            _context = new DbContextRAE();
        }
        #endregion

        public List<StudentDAO> Get(int top = 0)
        {
            var res = top == 0 ? _context.Estudiantes.ToList() : _context.Estudiantes.Take(top).ToList();
            return res.Mapper<StudentDAO, Estudiante>();
        }

        public StudentDAO GetId(long Id)
        {
            var res = _context.Estudiantes.ToList().FirstOrDefault(x => x.IdEstudiante == Id);
            return res.Mapper<StudentDAO, Estudiante>();
        }

        public void Insert(StudentDAO studentDAO)
        {
            _context.Estudiantes.Add(studentDAO.Mapper<Estudiante, StudentDAO> ());
            _context.SaveChanges();
        }

        public void Update(StudentDAO studentDAO)
        {
            var entidadAActualizar = _context.Estudiantes.ToList().FirstOrDefault(x => x.IdEstudiante == studentDAO.IdEstudiante);

            if (entidadAActualizar != null)
            {
                entidadAActualizar.IdEstudiante = studentDAO.IdEstudiante;
                entidadAActualizar.Nombre = studentDAO.Nombre;
                entidadAActualizar.Telefono = studentDAO.Telefono;
                    
            }
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var entidadAEliminar = _context.Estudiantes.ToList().FirstOrDefault(x => x.IdEstudiante == id);

            if (entidadAEliminar != null)
                _context.Estudiantes.Remove(entidadAEliminar);

            _context.SaveChanges();
        }

        #region recicle
        public StudentDAO GetProgramsxStudent(long Id)
        {
            throw new NotImplementedException();
        }
        public StudentDAO GetStudentsxPrograms(long Id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
