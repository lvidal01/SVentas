using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Vendedores
    {
        public int Idvendedores { get; set; }
        public int? CodCarticulos { get; set; }
        public int? Idempleados { get; set; }
        public int? Idpuestotrabajo { get; set; }
    }
}
