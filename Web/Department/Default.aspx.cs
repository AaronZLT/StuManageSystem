using System;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using StudentManager.BLL;

public partial class Department_Default : System.Web.UI.Page
{
    Affiche affiche = new Affiche();   
    protected void Page_Load(object sender, EventArgs e)
    {
        affiche.BindAffiches(gdvAffiche);
    }
    protected void gdvAffiche_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        
    }
    protected void gdvAffiche_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gdvAffiche_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        affiche.DelAffiche(Convert.ToInt32(gdvAffiche.DataKeys[e.RowIndex].Values[0]), HttpContext.Current.User.Identity.Name);
        affiche.BindAffiches(gdvAffiche);                
    }
    protected void gdvAffiche_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        
    }
}
