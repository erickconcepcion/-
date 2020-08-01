using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Entities
{
    public class Elemento
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }

        //[Column(TypeName = "int")]
        public int TipoElemento { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Unidad { get; set; }

        //[Column(TypeName = "numeric(18,2)")]
        public int TipoGrupo { get; set; }
    }
}
