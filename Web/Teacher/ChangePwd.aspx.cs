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

public partial class Teacher_ChangePwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        Teacher teacher = new Teacher();
        teacher.ChangePwd(HttpContext.Current.User.Identity.Name, txtOldPwd.Text, txtNewPwd.Text, txtReNewPwd.Text, lblMessage);
    }
}
