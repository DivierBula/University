using RegisterSubject.DataProviderAccess.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RegisterSubject.Imp
{
    [DataContract]
    public class ProgramDTO
    {
        [DataMember]
        public long IdPrograma { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int DuracionEnDias { get; set; }
        [DataMember]
        public int Creditos { get; set; }
        [DataMember]
        public long IdProfesor { get; set; }
        [DataMember]
        public TeacherDTO Profesor { get; set; }
    }
}

