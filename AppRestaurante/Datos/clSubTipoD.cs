using AppRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AppRestaurante.Datos
{
    public class clSubTipoD
    {
        public List<clSubTipoE> mtdListarSubTipo(string Validar)
        {
            string sql = "SELECT * FROM sudTipo WHERE idComida like '" + Validar + "%'";
            clConexion objConecion = new clConexion();
            DataTable tblSubTipo = new DataTable();
            tblSubTipo = objConecion.mtdDesconectado(sql);

            List<clSubTipoE> ListaSubTipo = new List<clSubTipoE>();
            int cantReg = tblSubTipo.Rows.Count;

            for (int i = 0; i < cantReg; i++)
            {
                clSubTipoE objDatosSubTipo = new clSubTipoE();
                objDatosSubTipo.idSubTipo = int.Parse(tblSubTipo.Rows[i]["idSubTipo"].ToString());
                objDatosSubTipo.nombre = tblSubTipo.Rows[i]["nombre"].ToString();
                objDatosSubTipo.precio = float.Parse(tblSubTipo.Rows[i]["precio"].ToString());
                objDatosSubTipo.descripcion = tblSubTipo.Rows[i]["descripcion"].ToString();
                objDatosSubTipo.idComida = int.Parse(tblSubTipo.Rows[i]["idComida"].ToString());
                
                ListaSubTipo.Add(objDatosSubTipo);
            }
            return ListaSubTipo;
        }
    }
}