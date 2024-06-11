using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataProviderAccess.DataAccessObject
{
    public class StudentDAO
    {
        public long IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public List<ProgramDAO> Programas { get; set; }
    }
}
