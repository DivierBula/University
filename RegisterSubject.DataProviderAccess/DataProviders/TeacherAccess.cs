using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.DataProviderAccess
{
    public class TeacherAccess : ITeacherProvider<TeacherDAO>
    {
        private readonly DbContextRAE _context;

        #region Ctor
        public TeacherAccess()
        {
            _context = new DbContextRAE();
        }
        #endregion

        public List<TeacherDAO> Get(int top = 0)
        {
            var res = top == 0 ? _context.Profesores.ToList() : _context.Profesores.Take(top).ToList();
            return res.Mapper<TeacherDAO, Profesor>();
        }

        public TeacherDAO GetId(long Id)
        {
            var res = _context.Profesores.ToList().FirstOrDefault(x=> x.IdProfesor == Id);
            return res.Mapper<TeacherDAO, Profesor>();
        }

        public void Insert(TeacherDAO teacherDAO)
        {
            _context.Profesores.Add(teacherDAO.Mapper<Profesor, TeacherDAO>());
            _context.SaveChanges();
        }

    }
}
