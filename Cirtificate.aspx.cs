using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cirtificate : System.Web.UI.Page
{
    string sub,name;

    protected void Page_Load(object sender, EventArgs e)
    {

        //string user = User.Identity.Name;
        //string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
       name = Session["Name"].ToString();
       Label1.Text = name;
       sub = Session["Subject"].ToString();
       Label2.Text = sub;



    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Visible = false;
    }
}