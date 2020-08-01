using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class Rubro
    {
        [Key]
        public int IdRubro { get; set; }

        [Column(TypeName = "int")]
        public int TipoRubro { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreRubro { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Observacion { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Unidad { get; set; }
        [Required]

        [Column(TypeName = "bit")]
        public Boolean Estado { get; set; }

        [Column(TypeName = "money")]
        public int PorcentajeTransporte { get; set; }

    }
}
