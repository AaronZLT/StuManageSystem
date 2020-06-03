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

public partial class Department_SetChooseCourse : System.Web.UI.Page
{
    private Course course = new Course();
    private Speciality speciality = new Speciality();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            course.BindCoursList(ddlCourseList);
            course.BindCRList(ddlClassRoomList);
            course.BindTeacherList(HttpContext.Current.User.Identity.Name, ddlTeacherList);
            speciality.BindSpecialityList(HttpContext.Current.User.Identity.Name, ddlSpeciality);
        }
    }
    protected void btnAddChooseCourse_Click(object sender, EventArgs e)
    {
        CourseInf courseInf = new CourseInf(ddlCourseList.SelectedValue, ddlSpeciality.SelectedValue,ddlTeacherList.SelectedValue, ddlClassRoomList.SelectedValue, ddlLearnYear.SelectedValue, Convert.ToInt32(ddlLearnTerm.SelectedValue), ddlStartWeek.SelectedValue.Trim() + "-" + ddlEndWeek.SelectedValue.Trim(), Convert.ToInt32(ddlPersonCount.SelectedValue), ddlDay.SelectedValue.Trim() + " " + ddlTurn.SelectedValue+","+ddlWeektoo.SelectedValue+" "+ddlDaytoo.SelectedValue, txtRemark.Text.Trim());
        course.AddChooseCourse(courseInf, lblMessage);
    }
}