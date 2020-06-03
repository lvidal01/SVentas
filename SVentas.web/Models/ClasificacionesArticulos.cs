using System;
using System.Collections.Generic;

namespace SVentas.web.Models
{
    public partial class ClasificacionesArticulos
    {
        public int? Idarticulos { get; set; }
        public int CodCarticulos { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
