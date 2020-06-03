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

public partial class Student_SelfInf : System.Web.UI.Page
{
    private Student student = new Student();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            student.DisplayStudentDetialsInf(HttpContext.Current.User.Identity.Name, lblId, LblName, lblSex, lblBirthday, lblMinZu, lblIdentity, lblTel, lblPro, lblFace, lblAddress, lblClass, lblSp, lblGrade, lblCollege, txtRemark);
        }
    }
}
