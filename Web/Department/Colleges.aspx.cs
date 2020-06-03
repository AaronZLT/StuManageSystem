using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using StudentManager.BLL;

public partial class Department_Collegesaspx : System.Web.UI.Page
{
    private Department dept = new Department();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dept.BindColleges(gvColleges);
        }
    }
    protected void gvColleges_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        dept.DeleteDept(HttpContext.Current.User.Identity.Name, e.CommandArgument.ToString());
    }
}
