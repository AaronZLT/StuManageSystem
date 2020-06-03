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

public partial class Department_Teachers : System.Web.UI.Page
{
    private Department dept = new Department();
    private Teacher teacher = new Teacher();
    private int collegeSelectIndex = 0;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.SelectedIndex = collegeSelectIndex;
        if (ddlCollege.SelectedItem.Text == "所有学院")
        {
            teacher.BindeTeachers("",gvTeachers);
        }
        else
        {
            teacher.BindeTeachers(ddlCollege.SelectedItem.Text,gvTeachers);
        }
    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        collegeSelectIndex = ddlCollege.SelectedIndex;
    }
}
