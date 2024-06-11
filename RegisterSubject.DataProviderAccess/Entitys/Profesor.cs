namespace RegisterSubject.DataProviderAccess
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesor")]
    public partial class Profesor
    {
        public Profesor()
        {
            Programas = new HashSet<Programa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdProfesor { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public long Telefono { get; set; }

        
        public virtual ICollection<Programa> Programas { get; set; }
    }
}
