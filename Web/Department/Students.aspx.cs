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

public partial class Department_Students : System.Web.UI.Page
{
    #region ±äÁ¿ÉùÃ÷
    private Department dept = new Department();
    private Speciality speciality = new Speciality();
    private Student student = new Student();
    private StuClass studentClass = new StuClass();
    private Common common = new Common();
    private string collegeSelect = "";
    private int collegeSelectIndex = 0;
    private int specialitySelectIndex =-1;
    private int ClassSelectIndex =-1;
    private string classSelectValue = "";
    private string specialitySelect = "";
    private string collegeSelectText = "";
    private string specialitySelectText = "";
    private string classSelectText = "";

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.SelectedIndex = collegeSelectIndex;

        try
        {
            speciality.BindSpecialityList(collegeSelect, ddlSpeciality);
            ddlSpeciality.SelectedIndex = specialitySelectIndex;
            studentClass.BindClassList(specialitySelect, ddlClassList);
            ddlClassList.SelectedIndex = ClassSelectIndex;
            student.BindStudent(collegeSelectText, specialitySelectText, classSelectText, gvStudents);
        }
        catch
        {
            ddlCollege.SelectedIndex = 0;
            ddlSpeciality.SelectedIndex = -1;
            ddlClassList.SelectedIndex = -1;
        }

    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        collegeSelect = ddlCollege.SelectedValue;
        collegeSelectIndex = ddlCollege.SelectedIndex;
        if (ddlCollege.SelectedItem == null)
        {
            classSelectText = "";
        }
        else
        {
            classSelectText = ddlCollege.SelectedItem.Text;
        }
        
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
    protected void ddlClassList_DataBinding(object sender, EventArgs e)
    {
        classSelectValue = ddlClassList.SelectedValue;
        ClassSelectIndex = ddlClassList.SelectedIndex;
        if (ddlClassList.SelectedItem == null)
        {
            classSelectText = "";
        }
        else
        {
            classSelectText = ddlClassList.SelectedItem.Text;
        }
            

    }
}
