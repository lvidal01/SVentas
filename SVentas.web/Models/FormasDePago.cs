using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class FormasDePago
    {
        public int Idpago { get; set; }
        public int? Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
