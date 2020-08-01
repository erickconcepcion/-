using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class ElementoPrecio
    {
        [Key]
        public int IdElementoPrecio { get; set; }
        [Required]

        [Column(TypeName = "datetime")]
        public DateTime FechaInicial { get; set; }
        [Required]

        [Column(TypeName = "datetime")]
        public DateTime FechaFinal { get; set; }

        //[Column(TypeName = "int")]
        public int Valor { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string DistanciaKm { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string CostoKmXm3 { get; set; }
        [Required]

        [Column(TypeName = "datetime")]
        public DateTime FechaIngMod { get; set; }

        //Relaciones con otras tablas

        public Elemento Elemento { get; set; }
        public int ElementoId { get; set; }

        public GeneralCab GeneralCab { get; set; }
        public int GeneralCabId { get; set; }
    }
}
