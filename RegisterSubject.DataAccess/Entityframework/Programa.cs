using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSubject.DataAccess.Entityframework
{
    public class Programa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdPrograma { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int DuracionEnDias { get; set; }
        public long IdProfesor { get; set; }
        
        [ForeignKey(nameof(IdProfesor))]
        public virtual Profesor Profesor { get; set; }
    }
}
