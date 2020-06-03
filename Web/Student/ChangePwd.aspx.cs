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
public partial class Student_ChangePwd : System.Web.UI.Page
{
    Student student = new Student();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        student.ChangePwd(HttpContext.Current.User.Identity.Name.ToString(), txtOldPwd.Text, txtNewPwd.Text, txtReNewPwd.Text, lblMessage);
    }
}
