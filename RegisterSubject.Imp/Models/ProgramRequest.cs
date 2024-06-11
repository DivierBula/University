using RegisterSubject.DataProviderAccess.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.Imp.Models
{
    [DataContract]
    public class ProgramRequest
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int DuracionEnDiás { get; set; }
        [DataMember]
        public int Creditos { get; set; }
        [DataMember]
        public long IdProfesor { get; set; }
    }
}
