using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRestaurante.Entidades
{
    public class clSubTipoE
    {
        public int idSubTipo { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public string descripcion { get; set; }
        public int idComida { get; set; }
    }
}