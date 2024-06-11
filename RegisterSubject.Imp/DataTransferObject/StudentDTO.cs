using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RegisterSubject.Imp
{
    [DataContract]
    public class StudentDTO
    {
        [DataMember]
        public long IdEstudiante { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public long Telefono { get; set; }

        [DataMember]
        public List<ProgramDTO> Programa { get; set; }
    }
}
