using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Marcas
    {
        public int Codmarcas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? Idsuplidores { get; set; }
    }
}
