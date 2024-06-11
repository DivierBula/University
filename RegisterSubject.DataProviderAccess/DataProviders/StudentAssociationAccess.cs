using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.DataProviderAccess
{
    public class StudentAssociationAccess : IStudentAssociationProvider<StudentAssociationDAO> 
    {
        private readonly DbContextRAE _context;
        
        #region Ctor
        public StudentAssociationAccess()
        {
            _context = new DbContextRAE();
        }
        #endregion

        public List<StudentAssociationDAO> Get(int top = 0)
        {
            var res = top == 0 ? _context.AsignacionesDeEstudiantes.ToList() : _context.AsignacionesDeEstudiantes.Take(top).ToList();
            return res.Mapper<StudentAssociationDAO, AsignacionEstudiantil>();
        }

        public List<StudentAssociationDAO> GetProgramsxStudent(long Id)
        {
            var res = _context.AsignacionesDeEstudiantes.ToList().FindAll(x => x.IdEstudiante == Id);
            return res.Mapper<StudentAssociationDAO, AsignacionEstudiantil>(); ;
        }

        public List<StudentAssociationDAO> GetStudentsxPrograms(long Id)
        {
            var res = _context.AsignacionesDeEstudiantes.ToList().FindAll(x => x.IdPrograma == Id);
            return res.Mapper<StudentAssociationDAO, AsignacionEstudiantil>();
        }

        public void Insert(StudentAssociationDAO studentAssociationDAO)
        {
            _context.AsignacionesDeEstudiantes.Add(studentAssociationDAO.Mapper<AsignacionEstudiantil, StudentAssociationDAO>());
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var entidadAEliminar = _context.AsignacionesDeEstudiantes.ToList().FirstOrDefault(x => x.IdAsignacionEstudiantil == id);

            if (entidadAEliminar != null)
                _context.AsignacionesDeEstudiantes.Remove(entidadAEliminar);

            _context.SaveChanges();
        }
    }
}
