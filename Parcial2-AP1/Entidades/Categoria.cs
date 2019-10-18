using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_AP1.Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {

        }
    }
}
