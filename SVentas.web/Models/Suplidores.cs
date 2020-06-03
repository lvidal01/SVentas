using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Suplidores
    {
        public int Idsuplidores { get; set; }
        public string Nombre { get; set; }
        public int? Idempresas { get; set; }
    }
}
