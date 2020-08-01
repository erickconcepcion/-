using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class Elemento
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "int")]
        public int TipoElemento { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Unidad { get; set; }

        [Column(TypeName = "numeric(18,2)")]
        public decimal TipoGrupo { get; set; }
    }
}
