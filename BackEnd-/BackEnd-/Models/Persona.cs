using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Identificacion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string RegistroProfesional { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreCompleto { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Direccion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Telefono1 { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Telefono2 { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public Boolean Estado { get; set; }

        //Relaciones con tablas

        public GeneralCab GeneralCab { get; set; }
        public int GeneralCabId { get; set; }
    }
}
