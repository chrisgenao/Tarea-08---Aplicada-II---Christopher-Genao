using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SimpleAuth
{
    public partial class Default : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Hello, " + Context.User.Identity.Name;
        }

        public void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Logon.aspx");
        }
    }
}