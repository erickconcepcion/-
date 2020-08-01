﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_.Models
{
    public class GeneralCab
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "int")]
        public int IdItemCab { get; set; }
        [Column(TypeName = "int")]
        public int IdTipo { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Descripcion { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string Observacion { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public Boolean IdEstado { get; set; }
    }
}
