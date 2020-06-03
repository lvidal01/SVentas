using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Monedas
    {
        public int Idmonedas { get; set; }
        public int? Tipo { get; set; }
        public string Nombre { get; set; }
        public int? Idpago { get; set; }
    }
}
