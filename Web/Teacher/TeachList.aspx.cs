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

public partial class Teacher_TeachList : System.Web.UI.Page
{
    private Course course = new Course();
    protected void Page_Load(object sender, EventArgs e)
    {
        course.GetCourseList(HttpContext.Current.User.Identity.Name, gv_TeachList);
    }
    protected void gv_TeachCoures_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow drv = ((GridViewRow)(((LinkButton)(e.CommandSource)).Parent.Parent));
        int rowIndex = drv.RowIndex;
        Session["cb_id"] = gv_TeachList.DataKeys[rowIndex].Values[0].ToString();
        Session["pc_year"] = gv_TeachList.DataKeys[rowIndex].Values[1].ToString();
        Session["pc_term"] = gv_TeachList.DataKeys[rowIndex].Values[2].ToString();
        Response.Redirect("JoinScores.aspx");
    }
}
