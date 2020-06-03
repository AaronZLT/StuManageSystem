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


public partial class Department_Courses : System.Web.UI.Page
{
    private Course course = new Course();
    private Department dept = new Department();
    private int collegeSelectIndex = 0;
    private string collegeSelectValue = "00";
    protected void Page_Load(object sender, EventArgs e)
    {
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.SelectedIndex = collegeSelectIndex;          

        course.BindCourses(ddlCollege.SelectedValue, gCourses);
    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        collegeSelectIndex = ddlCollege.SelectedIndex;
        collegeSelectValue = ddlCollege.SelectedValue;
    }

    protected void gCourses_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        dept.DeleteCourseLib(HttpContext.Current.User.Identity.Name, e.CommandArgument.ToString());
    }
}
