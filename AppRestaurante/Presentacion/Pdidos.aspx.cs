using AppRestaurante.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppRestaurante.Presentacion
{
    public partial class Pdidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                clComidaL objComida = new clComidaL();
                ddlComida.DataSource = objComida.mtdListarComida();
                ddlComida.DataValueField = "idComida";
                ddlComida.DataTextField = "comida";
                ddlComida.DataBind();
                ddlComida.Items.Insert(0, new ListItem("Seleccion", "0"));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int idComida = int .Parse(ddlComida.SelectedValue.ToString());
            if (idComida > 0)
            {
                lblMensaje.Text = "Comida Aceptada";
            }
            else
            {
                lblMensaje.Text = "Seleccione comida";
            }
        }

        protected void ddlComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Validar = ddlComida.SelectedValue;
             
            clSubTipoL objSubTipoL = new clSubTipoL();
            dgvTabla.DataSource = objSubTipoL.mtdListarSubTipo(Validar);
        }

        
    }
}