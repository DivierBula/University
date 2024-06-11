using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataAccess.Entityframework
{
    public class AsignacionEstudiantil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdAsignacionEstudiantil { get; set; }
        public long IdProfesor { get; set; }
        public long IdPrograma { get; set; }

        [ForeignKey(nameof(IdProfesor))]
        public virtual Profesor Profesor { get; set; }

        [ForeignKey(nameof(IdPrograma))]
        public virtual Programa Programa { get; set; }
    }
}
