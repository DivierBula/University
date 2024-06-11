using System;
using System.Runtime.Serialization;

namespace RegisterSubject.Imp
{
    [DataContract]
    public class TeacherDTO
    {
        [DataMember]
        public long IdProfesor { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public long Telefono { get; set; }
    }
}
