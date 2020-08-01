using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class General
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Observacion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Auxiliar { get; set; }

        //Relacion de otras tablas

        public GeneralCab GeneralCab { get; set; }
        public int GeneraCablId { get; set; }
    }
}
