using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exposicion.Models
{
    public class Auto
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Motor { get; set; }

        public string Cilindrada { get; set; }

        public string Año { get; set; }

        public string Traccion { get; set; }
    }
}