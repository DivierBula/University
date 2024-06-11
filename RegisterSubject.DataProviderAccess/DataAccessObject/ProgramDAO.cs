using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegisterSubject.DataProviderAccess.DataAccessObject
{
    public class ProgramDAO
    {
        public long IdPrograma { get; set; }
        public string Nombre { get; set; }
        public string Creditos { get; set; }
        public string DuracionEnDias { get; set; }
        public long? IdProfesor { get; set; }

        public TeacherDAO Profesor { get; set; }
    }
}
