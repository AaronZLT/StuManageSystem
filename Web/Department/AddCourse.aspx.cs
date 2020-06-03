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
using StudentManager.Model;
using StudentManager.Common;

public partial class Department_AddCourse : System.Web.UI.Page
{

    private Department dept = new Department();
    private Course course = new Course();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            course.BindCourseType(ddlCourseType);
            dept.BindCollegeForDll(ddlCollege);
            ddlCollege.Items[0].Enabled = false;
            
        }
    }
    protected void btnAddStudent_Click(object sender, EventArgs e)
    {
        CourseInf courseInf = new CourseInf(txtCourseNumber.Text, ddlCollege.SelectedValue, txtCourseName.Text,Convert.ToSingle(txtXueFen.Text), ddlCourseType.SelectedValue, Convert.ToInt32(txtCourseTime.Text),ddlIsPublic.SelectedValue, txtCourseRemark.Text);
        course.AddCourse(courseInf, lblMessage);
    }
}
