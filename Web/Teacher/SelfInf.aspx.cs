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

public partial class Teacher_SelfInf : System.Web.UI.Page
{
    private Teacher teacher = new Teacher();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            teacher.DisplayTeacherDetailsInf(HttpContext.Current.User.Identity.Name, lblTEID, LblTeName, lblTeCollege, lblTeXueli, lblTeZhicheng, lblTeSex, lblTeIdentity, lblTeSp, lblTeAddress, lblZZFace, lblTeMinzu, lblTeTel, lblTeBirthday, lblTeTime, lblTePro, txtRemark);
        }
    }
}
