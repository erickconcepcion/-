using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Identificacion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string NombreUsuario { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Usuarios { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Clave { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime FechaCreacion { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime FechaExpiracion { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public Boolean Estado { get; set; }

        public Persona Persona { get; set; }
        public int PersonaId { get; set; }
    }
}
