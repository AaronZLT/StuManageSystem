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

public partial class Department_AddTeacher : System.Web.UI.Page
{
    private Common common = new Common();
    private Department dept = new Department();
    private Teacher teacher = new Teacher();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            common.BindLearnList(ddlXueLi);
            dept.BindCollegeForDll(ddlDepartment);
            ddlDepartment.Items.RemoveAt(0);
            common.BindZhiChengList(ddlZhiCheng);
            common.BindZZList(ddlFace);
            common.BindMZList(ddlMingZu);
            common.BindProvinceList(ddlProvince);
        }
    }

    protected void btnAddTeacher_Click(object sender, EventArgs e)
    {
        DateTime te_Birthday;
        DateTime te_Teachtime;
        try
        {
            te_Birthday=Convert.ToDateTime(txtBirthday.Text);
            te_Teachtime=Convert.ToDateTime(txtWorkTime.Text);
            TeacherInf teacherInf=new TeacherInf(txtTeacherNumber.Text,txtTeacherName.Text,ddlDepartment.SelectedValue,ddlSex.SelectedValue,txtIdentity.Text,txtSpeciality.Text,ddlXueLi.SelectedItem.Text,ddlZhiCheng.SelectedItem.Text,ddlFace.SelectedItem.Text,txtTel.Text,te_Birthday,te_Teachtime,txtHomeAddress.Text,ddlProvince.SelectedItem.Text,ddlMingZu.SelectedItem.Text,txtRemark.Text);
            teacher.AddTeacher(teacherInf);
        }
        catch
        {
            JScript.AlertAndRedirect("时间格式错误!请重新输入", "AddTeacher.aspx");
        }
        
    }
}
