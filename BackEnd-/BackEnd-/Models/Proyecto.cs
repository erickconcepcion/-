using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreProyecto { get; set; }

        [Column(TypeName = "int")]
        public int NumeroVivienda { get; set; }

        //[Column(TypeName = "int")]
        //public int IdObra { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string CodigoObra { get; set; }

        //Relacion con otras tablas

        public ObraProyecto ObraProyecto { get; set; }

    }
}
