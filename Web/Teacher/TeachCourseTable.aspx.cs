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

public partial class Teacher_TeachCourseTable : System.Web.UI.Page
{
    #region 变量声明
    private Course course = new Course();
    private string te_id = HttpContext.Current.User.Identity.Name;
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        course.TecherTeachCourses(te_id, gv_TeachCoures);
    }
    #endregion

    #region 查看选课学生
    protected void gv_TeachCoures_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        Response.Redirect("ViewStudentChoose.aspx?pc_id=" + e.CommandArgument.ToString());
    }
    #endregion

}
