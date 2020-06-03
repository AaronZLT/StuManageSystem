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

public partial class Student_StudentMasterPage : System.Web.UI.MasterPage
{
    private Common common;
    protected void Page_Load(object sender, EventArgs e)
    {
        common = new Common();
        this.lblLoginWel.Text = common.GetUseWelInf(HttpContext.Current.User.Identity.Name) + "欢迎您使用现代教务管理系统!";
    }
}
