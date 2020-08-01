using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class Obra
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string CodigoObra { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreObra { get; set; }
        [Required]

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaCreacion { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreCliente { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string IdPersonalCliente { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreOferente { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string IdPersonalOferente { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string RegistroProfesional { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        public string Direccion { get; set; }



        [Column(TypeName = "int")]
        public int IdProvincia { get; set; }

        [Column(TypeName = "int")]
        public int IdCiudad { get; set; }

        //Relacion con otras tablas

    }
}
