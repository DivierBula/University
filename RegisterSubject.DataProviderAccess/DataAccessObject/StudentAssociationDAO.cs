using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataProviderAccess.DataAccessObject
{
    public class StudentAssociationDAO
    {
        public long IdAsignacionEstudiantil { get; set; }
        public long IdEstudiante { get; set; }
        public long IdPrograma { get; set; }

        public Estudiante Estudiante { get; set; }
        public Programa Programa { get; set; }
    }
}
