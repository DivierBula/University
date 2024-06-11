namespace RegisterSubject.DataProviderAccess
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Programa")]
    public partial class Programa
    {
        public Programa()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdPrograma { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(2)]
        public string Creditos { get; set; }

        [Required]
        [StringLength(3)]
        public string DuracionEnDias { get; set; }

        public long? IdProfesor { get; set; }

        
        public virtual Profesor Profesor { get; set; }
    }
}
