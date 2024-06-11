using RegisterSubject.DataProviderAccess.DataAccessObject;
using RegisterSubject.DataProviderAccess.Helpers;
using RegisterSubject.DataProviderAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RegisterSubject.DataProviderAccess
{
    public class ProgramAccess : IProgramProvider<ProgramDAO>
    {
        private readonly DbContextRAE _context;

        #region Ctor
        public ProgramAccess()
        {
            _context = new DbContextRAE();
        }
        #endregion

        public List<ProgramDAO> Get(int top = 0)
        {
            var res = top == 0 ? _context.Programas.ToList() : _context.Programas.Take(top).ToList();
            return res.Mapper<ProgramDAO, Programa>();
        }

        public ProgramDAO GetId(long Id)
        {
            var res = _context.Programas.ToList().FirstOrDefault(x => x.IdPrograma == Id);
            return res.Mapper<ProgramDAO, Programa>();
        }

        public void Insert(ProgramDAO programDAO)
        {
            _context.Programas.Add(programDAO.Mapper<Programa, ProgramDAO>());
            _context.SaveChanges();
        }

        public List<ProgramDAO> GetProgramxProfesor(long Id)
        {
            var res = _context.Programas.ToList().FindAll(x => x.IdProfesor == Id);
            return res.Mapper<ProgramDAO, Programa>();
        }
    }
}
