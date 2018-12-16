using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        inversoGrupal i = new inversoGrupal();
        protected void Page_Load(object sender, EventArgs e)
        {
            inverso.Text = "hola";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            inverso.Text = i.cifrarInverso("", textoPlano.Text);
        }

        protected void textoPlano_DataBinding(object sender, EventArgs e)
        {

            inverso.Text = i.cifrarInverso("", textoPlano.Text);
        }
    }
}