using AppRestaurante.Datos;
using AppRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRestaurante.Logica
{
    public class clSubTipoL
    {
        public List<clSubTipoE> mtdListarSubTipo(string Validar)
        {
            clSubTipoD objSubTipo = new clSubTipoD();
            List<clSubTipoE> ListarSubTipo = new List<clSubTipoE>();
            ListarSubTipo = objSubTipo.mtdListarSubTipo(Validar);
            return ListarSubTipo;
        }
    }
}