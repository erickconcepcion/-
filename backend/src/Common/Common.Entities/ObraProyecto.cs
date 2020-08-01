using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class ObraProyecto
    {
        [Key]
        public int IdObraProyecto { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Observacion { get; set; }

        [Column(TypeName = "money")]
        public int Moneda { get; set; }
        [Required]

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacionProyecto { get; set; }


        //Relacion con otras tablas

        public Proyecto Proyecto { get; set; }
        public int ProyectoId { get; set; }

        public Obra Obra { get; set; }
        public int ObraId { get; set; }
    }
}
