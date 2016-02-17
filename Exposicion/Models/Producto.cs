using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exposicion.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public string Precio { get; set; }
        public Categoria Categoria { get; set; }

    }
}