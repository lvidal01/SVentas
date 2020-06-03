using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class TiposDeDocumentos
    {
        public int Iddocumento { get; set; }
        public int? Tipodocumento { get; set; }
        public string Nombre { get; set; }
    }
}
