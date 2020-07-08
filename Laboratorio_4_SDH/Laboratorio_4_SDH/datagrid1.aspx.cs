using CapaDatos;
using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_4_SDH
{
    public partial class datagrid1 : System.Web.UI.Page
    {
        GestionBD objBD;
        List<Facturas> auxListado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargaDatosgrid();
            }

        }

        void cargaDatosgrid()
        {
            objBD = new GestionBD();
            auxListado = objBD.listadoFacturero();
            gridDetalleFact.DataSource = auxListado;
            gridDetalleFact.DataBind();

        }

        protected void gridDetalleFact_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridDetalleFact, "Select$" + e.Row.RowIndex);
            }
        }

        protected void gridDetalleFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridDetalleFact.Rows)
            {
                if(fila.RowIndex == gridDetalleFact.SelectedIndex)
                {
                    txtIdFactura.Text = fila.Cells[0].Text;
                    txtnumLinea.Text = fila.Cells[1].Text;
                    txtCodigo.Text = fila.Cells[2].Text;
                    txtProducto.Text = fila.Cells[3].Text;
                    txtCantidad.Text = fila.Cells[4].Text;
                    txtCosto.Text = fila.Cells[5].Text;
                    txtTotal.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }

            cargaDatosgrid();
        }
    }
}