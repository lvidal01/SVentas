using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class PuestosDeTrabajo
    {
        public int Idpuestotrabajo { get; set; }
        public int? Idempleados { get; set; }
        public string Nombre { get; set; }
    }
}
