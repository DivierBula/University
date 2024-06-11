using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.Imp.Models
{
    [DataContract]
    public class TeacherRequest
    {
        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public long Telefono { get; set; }
    }
}
