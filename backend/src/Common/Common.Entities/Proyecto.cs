using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class Proyecto
    {
        [Key]
        public int IdProyecto { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreProyecto { get; set; }

        [Column(TypeName = "int")]
        public int NumeroVivienda { get; set; }

        //[Column(TypeName = "int")]
        //public int IdObra { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string CodigoObra { get; set; }

        //Relacion con otras tablas
        [Required]
        public ObraProyecto ObraProyecto { get; set; }
    }
}
