using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webProjectoFinal_03
{
    public partial class NovoDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableLinhasFatura ls = new TableLinhasFatura();
            LinhaFatura l = new LinhaFatura();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}