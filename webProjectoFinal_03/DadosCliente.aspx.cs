using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace webProjectoFinal_03
{
    public partial class DadosCliente : System.Web.UI.Page
    {
        protected void EstadoInicial()
        {
            Painel.Enabled = false;
            cmdEditar.Visible = true;
            cmdEliminar.Visible = true;
            cmdGravarAlteracao.Visible = false;
            cmdGravarNovo.Visible = false;
        }

        protected void EstadoEditar()
        {
            Painel.Enabled = true;
            cmdEditar.Visible = false;
            cmdEliminar.Visible = false;
            cmdGravarAlteracao.Visible = true;
            cmdGravarNovo.Visible = false;
        }        

        protected void EstadoNovoCliente()
        {
            Painel.Enabled = true;
            cmdEditar.Visible = false;
            cmdEliminar.Visible = false;
            cmdGravarAlteracao.Visible = false;
            cmdGravarNovo.Visible = true;
        }        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {                
                int clienteID = Convert.ToInt32(Request.QueryString["id"]);

                if (clienteID != 0)
                {
                    EstadoInicial();

                    
                    dbEntities db = new dbEntities();

                    Cliente c = db.Cliente.Where(cl => cl.ClientePK == clienteID).First();

                    txtNome.Text = c.Nome;
                    txtRua.Text = c.Rua;
                    txtLocalidade.Text = c.Localidade;
                    txtCodigoPostal.Text = c.CodigoPostal;
                    txtPais.Text = c.Pais;
                    txtNIF.Text = c.NIF;
                    txtTelefone.Text = c.Telefone;


                   ImageMap1.ImageUrl="http://maps.googleapis.com/maps/api/staticmap?markers=markerStyles|" + txtRua.Text + ","+txtLocalidade.Text + "&zoom=15&size=400x400&sensor=false";


                }
                else
                {
                    EstadoNovoCliente();
                }
            }
        }

        protected void cmdEditar_Click(object sender, EventArgs e)
        {
            EstadoEditar();
        }

        protected void cmdGravarAlteracao_Click(object sender, EventArgs e)
        {
            dbEntities   db = new dbEntities();

            int clienteID = Convert.ToInt32(Request.QueryString["id"]);

            db.sp_EditaCliente( clienteID, txtNome.Text, txtRua.Text, txtLocalidade.Text, txtCodigoPostal.Text, txtPais.Text, txtNIF.Text, txtTelefone.Text);
            
            EstadoInicial();
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            dbEntities db = new dbEntities();

            int clienteID = Convert.ToInt32(Request.QueryString["id"]);

            db.sp_ApagaCliente(clienteID);
            Response.Redirect("~/ListagemClientes.aspx");

        }

        protected void cmdGravarNovo_Click(object sender, EventArgs e)
        {
            dbEntities db = new dbEntities();

            int clienteID = Convert.ToInt32(Request.QueryString["id"]);

            db.sp_AdicionaCliente(txtNome.Text, txtRua.Text, txtLocalidade.Text, txtCodigoPostal.Text, txtPais.Text, txtNIF.Text, txtTelefone.Text);
            Response.Redirect("~/ListagemClientes.aspx");
        }

    }
}