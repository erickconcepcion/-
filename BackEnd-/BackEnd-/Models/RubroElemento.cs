using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class RubroElemento
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Unidad { get; set; }

        [Column(TypeName = "int")]
        public int Cantidad { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Precio { get; set; }

        [Column(TypeName = "money")]
        public int CostoHora { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal Rendimiento { get; set; }

        [Column(TypeName = "money")]
        public int Costo { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string TipoElemento { get; set; }

        [Column(TypeName = "int")]
        public int Dias { get; set; }


        //Relacion con otras tablas
        public Rubro Rubro { get; set; }
        public int RubroId { get; set; }

        public Elemento Elemento { get; set; }
        public int ElementoId { get; set; }
    }
}
