namespace RegisterSubject.DataProviderAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdEstudiante { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public long Telefono { get; set; }
    }
}
