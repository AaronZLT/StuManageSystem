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

public partial class Teacher_Controls_Navigation : System.Web.UI.UserControl
{
    private Common common;
    protected void Page_Load(object sender, EventArgs e)
    {
        common = new Common();
        this.lblStudengInf.Text = common.GetUseWelInf(HttpContext.Current.User.Identity.Name) + "»¶Ó­Äú!";
    }
}
