using RegisterSubject.DataProviderAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.Imp.Models
{
    public class StudentAssociationDTO
    {
        public long IdAsignacionEstudiantil { get; set; }
        public long IdEstudiante { get; set; }
        public long IdPrograma { get; set; }
        public StudentDTO Estudiante { get; set; }
        public ProgramDTO Programa { get; set; }
    }
}
