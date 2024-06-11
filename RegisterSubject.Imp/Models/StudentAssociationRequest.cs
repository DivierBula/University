using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.Imp.Models
{
    [DataContract]
    public class StudentAssociationRequest
    {
        [DataMember]
        public long IdEstudiante { get; set; }

        [DataMember]
        public long IdProgram { get; set; }
    }
}
