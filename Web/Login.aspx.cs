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


public partial class Login : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {   
        if (rbtnGuest.Checked)
        {
            FormsAuthentication.SetAuthCookie("guest", false);
            Response.Redirect(@"~/Guest/Default.aspx");
        }
        if (rbtnStudent.Checked)
        {   Student student = new Student();
            student.ValidStudentLogin(UserName.Text, Password.Text);
        }
        if (rbtnTeacher.Checked)
        {
            Teacher teacher = new Teacher();
            teacher.ValidTeacherLogin(UserName.Text, Password.Text);
        }
        if (rbtnDept.Checked)
        { 
            Department department = new Department();
            department.ValidDepartMentLogin(UserName.Text, Password.Text);
        }
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.close();history.go(-1)</script>");
    }

}
