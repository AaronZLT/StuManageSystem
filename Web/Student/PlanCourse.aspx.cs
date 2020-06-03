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

public partial class Student_PlanCourse : System.Web.UI.Page
{
    #region 变量声明
    private Course course = new Course();
    private string dp_Id = string.Empty;
    private string sp_Id = string.Empty;
    private string st_id = HttpContext.Current.User.Identity.Name;
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        course.BindStudentInf(HttpContext.Current.User.Identity.Name, lblTitle, ref dp_Id, ref sp_Id);
        course.GetPlanCourseTable(st_id, gv_PlanCourseTb);
    }
    #endregion

}
