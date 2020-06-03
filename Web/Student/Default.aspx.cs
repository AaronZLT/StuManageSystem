using System;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using StudentManager.BLL;

public partial class Student_Controls_Default : System.Web.UI.Page
{

    private Affiche affiche = new Affiche();
    protected void Page_Load(object sender, EventArgs e)
    {
        affiche.BindAffiches(gdvAffiche);
    }

}
