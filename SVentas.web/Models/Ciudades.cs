using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Ciudades
    {
        public int Idciudades { get; set; }
        public string Nombre { get; set; }
        public int? Idpaises { get; set; }
        public int? Idempresas { get; set; }
    }
}
