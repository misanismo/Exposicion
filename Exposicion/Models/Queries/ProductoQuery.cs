using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exposicion.Models.Queries
{
    public class ProductoQuery
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }
        
    }
}