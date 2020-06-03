using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using StudentManager.BLL;
public partial class Teacher_Default : System.Web.UI.Page
{
    Affiche affiche = new Affiche();
    protected void Page_Load(object sender, EventArgs e)
    {
        affiche.BindAffiches(gdvAffiche);
    }
}
