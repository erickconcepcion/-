using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class ProyectoRubro
    {
        [Key]
        public int IdProyectosRubros { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Unidad { get; set; }

        [Column(TypeName = "int")]
        public int Cantidad { get; set; }

        [Column(TypeName = "money")]
        public int PrecioUnitario { get; set; }

        [Column(TypeName = "money")]
        public int PrecioTotal { get; set; }

        [Column(TypeName = "int")]
        public int Porcentaje { get; set; }

        //Relacion con otras tablas
        public Rubro Rubro { get; set; }
        public int RubroId { get; set; }

        public Proyecto Proyecto { get; set; }
        public int ProyectoId { get; set; }
    }
}
