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

public partial class Department_Classes : System.Web.UI.Page
{
    #region 定义变量
    private Department dept = new Department();
    private Speciality speciality = new Speciality();
    private StuClass stu_class = new StuClass();
    private string collegeSelect = "";
    private int collegeSelectIndex = 0;
    private int specialitySelectIndex = -1;
    private string specialitySelect = "";
    private string collegeSelectText = "";
    private string specialitySelectText = "";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.SelectedIndex = collegeSelectIndex;

        try
        {
            speciality.BindSpecialityList(collegeSelect, ddlSpeciality);
            ddlSpeciality.SelectedIndex = specialitySelectIndex;
            stu_class.BindeClasses(collegeSelectText, specialitySelectText, gvClasses);
        }
        catch
        {
            ddlCollege.SelectedIndex = 0;
            ddlSpeciality.SelectedIndex = -1;

        }
    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        collegeSelect = ddlCollege.SelectedValue;
        collegeSelectIndex = ddlCollege.SelectedIndex;
    }
    protected void ddlSpeciality_DataBinding(object sender, EventArgs e)
    {
        specialitySelect = ddlSpeciality.SelectedValue;
        specialitySelectIndex = ddlSpeciality.SelectedIndex;
        if (ddlSpeciality.SelectedItem == null)
        {
            specialitySelectText = "";
        }
        else
        {
            specialitySelectText = ddlSpeciality.SelectedItem.Text;
        }
    }
    protected void gvClasses_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        dept.DeleteCL(HttpContext.Current.User.Identity.Name, e.CommandArgument.ToString());
    }
}
