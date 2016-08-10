using System;

namespace WebAppTeste
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello from Default.aspx.<br>");
        }
    }
}