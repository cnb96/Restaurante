using AppRestaurante.Datos;
using AppRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppRestaurante.Logica
{
    public class clComidaL
    {
        public List<clComidaE> mtdListarComida()
        {
            clComidaD objComida = new clComidaD();
            List<clComidaE> ListarComida = new List<clComidaE>();
            ListarComida = objComida.mtdListarComida();
            return ListarComida;
        }
    }
}