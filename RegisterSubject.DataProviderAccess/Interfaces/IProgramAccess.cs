using RegisterSubject.DataProviderAccess.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataProviderAccess.Interfaces
{
    public interface IProgramAccess
    {
        List<ProgramDAO> Get(int top = 0);
        ProgramDAO GetId(long Id);
        void Insert(ProgramDAO programDAO);
        List<ProgramDAO> GetProgramxProfesor(long Id);
    }
}
