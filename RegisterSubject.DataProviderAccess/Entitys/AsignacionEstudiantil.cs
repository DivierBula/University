namespace RegisterSubject.DataProviderAccess
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AsignacionEstudiantil")]
    public partial class AsignacionEstudiantil
    {
        [Key]
        public long IdAsignacionEstudiantil { get; set; }

        public long? IdEstudiante { get; set; }

        public long? IdPrograma { get; set; }

        
        public virtual Estudiante Estudiante { get; set; }
        
        public virtual Programa Programa { get; set; }
    }
}
