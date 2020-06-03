using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Clientes
    {
        public int Idclientes { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaDnacimiento { get; set; }
        public int? Telefono { get; set; }
        public string Email { get; set; }
        public int? Idempresas { get; set; }
    }
}
