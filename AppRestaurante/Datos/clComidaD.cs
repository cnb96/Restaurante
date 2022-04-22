using AppRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppRestaurante.Datos
{
    public class clComidaD
    {
        public List<clComidaE> mtdListarComida()
        {
            string sql = "SELECT * FROM comida";
            clConexion objConecion = new clConexion();
            DataTable tblcomida = new DataTable();
            tblcomida = objConecion.mtdDesconectado(sql);

            List<clComidaE> Listacomida = new List<clComidaE>();
            int cantReg = tblcomida.Rows.Count;

            for (int i = 0; i < cantReg; i++)
            {
                clComidaE objDatosComida = new clComidaE();
                objDatosComida.idComida = int.Parse(tblcomida.Rows[i]["idComida"].ToString());
                objDatosComida.comida = tblcomida.Rows[i]["comida"].ToString();
                Listacomida.Add(objDatosComida);
            }
            return Listacomida;
        }
    }
}