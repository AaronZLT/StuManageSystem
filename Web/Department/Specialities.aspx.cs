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

public partial class Department_Specialities : System.Web.UI.Page
{
    private Speciality speciality = new Speciality();
    private Department dept = new Department();
    private int collegeSelectindex = 0;
    private string collegeSelectValue = "00";
    protected void Page_Load(object sender, EventArgs e)
    {
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.SelectedIndex = collegeSelectindex;
        if (!Page.IsPostBack)
        {
            speciality.BindSpecialityList(ddlCollege.SelectedValue, ddlGrade.SelectedValue, gvSpecialityList);
        }
    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        collegeSelectindex = ddlCollege.SelectedIndex;
        collegeSelectValue = ddlCollege.SelectedValue;

    }
    protected void gvSpecialityList_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        dept.DeleteSP(HttpContext.Current.User.Identity.Name, e.CommandArgument.ToString());
    }
}
