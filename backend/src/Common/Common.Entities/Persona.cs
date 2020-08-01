using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    public class Persona: BaseEntity
    {
        public string Nombre { get; set; }
        public string Gustos { get; set; }
        public string Comentarios { get; set; }
    }
}
