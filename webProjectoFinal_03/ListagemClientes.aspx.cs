using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webProjectoFinal_03
{
    public partial class ListagemClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdNovoCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DadosCliente.aspx?id=0");
        }
    }
}