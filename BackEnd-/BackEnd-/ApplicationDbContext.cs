using BackEnd_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rubro> Rubro { get; set; }
        public DbSet<RubroElemento> RubroElemento { get; set; }
        public DbSet<ProyectoRubro> ProyectoRubro { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Obra> Obra { get; set; }
        public DbSet<ObraProyecto> ObraProyecto { get; set; }
        public DbSet<GeneralCab> GeneralCab { get; set; }
        public DbSet<General> General { get; set; }
        public DbSet<Elemento> Elemento { get; set; }
        public DbSet<ElementoPrecio> ElementoPrecio { get; set; }
    }
}
