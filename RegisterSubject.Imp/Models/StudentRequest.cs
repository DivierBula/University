using System;
using System.Runtime.Serialization;

namespace RegisterSubject.Imp.Models
{
    [DataContract]
    public class StudentRequest
    {
        [DataMember]
        public long IdEstudiante { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public long Telefono { get; set; }
    }
}
