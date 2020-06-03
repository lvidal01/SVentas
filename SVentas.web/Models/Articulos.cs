using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class Articulos
    {
        public int Idarticulos { get; set; }
        public int? Codmarcas { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public int? Stock { get; set; }
    }
}
