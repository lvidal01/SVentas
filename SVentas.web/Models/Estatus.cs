using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Estatus
    {
        public int Idestatus { get; set; }
        public bool? Status { get; set; }
        public int? Idempresas { get; set; }
    }
}
