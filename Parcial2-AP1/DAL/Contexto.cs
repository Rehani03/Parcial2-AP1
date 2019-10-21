using Parcial2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial2_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Servicio> Categorias {get; set;}
        public DbSet<Venta> Venta { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
