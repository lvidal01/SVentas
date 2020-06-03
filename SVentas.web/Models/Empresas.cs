using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Empresas
    {
        public int Idempresas { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int? Telefono { get; set; }
        public string Email { get; set; }
    }
}
