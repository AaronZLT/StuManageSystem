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
using StudentManager.Common;
using StudentManager.Model;
using StudentManager.BLL;

public partial class Department_AddStudent : System.Web.UI.Page
{

    #region 变量声明
    private Department dept = new Department();
    private Speciality speciality = new Speciality();
    private Student student = new Student();
    private StuClass studentClass = new StuClass();
    private Common common = new Common();
    private string collegeSelect ="";
    private int collegeSelectIndex = 0;
    private int specialitySelectIndex = 0;
    private string specialitySelect = "";
    private DateTime birthday;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

        dept.BindCollegeForDll(ddlCollegeList);
        ddlCollegeList.SelectedIndex = collegeSelectIndex;
   
        speciality.BindSpecialityList(collegeSelect, ddlSpeciality);
        ddlSpeciality.SelectedIndex = specialitySelectIndex;
        studentClass.BindClassList(specialitySelect, ddlClass);
        if (!Page.IsPostBack)
        {

            common.BindMZList(ddlMingZu);
            common.BindProvinceList(ddlProvince);
            common.BindZZList(ddlStuFace);            
            
        }       
        
    }
    protected void txtQingshiNumber_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ddlCollegeList_DataBinding(object sender, EventArgs e)
    {
        collegeSelect = ddlCollegeList.SelectedValue;
        collegeSelectIndex = ddlCollegeList.SelectedIndex;
    }
    protected void ddlSpeciality_DataBinding(object sender, EventArgs e)
    {
        specialitySelect = ddlSpeciality.SelectedValue;
        specialitySelectIndex = ddlSpeciality.SelectedIndex;
 
    }
    protected void ddlSpeciality_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnAddStudent_Click(object sender, EventArgs e)
    {
        try
        {
            birthday=Convert.ToDateTime(txtBirthday.Text);
            StudentInf studentInf = new StudentInf(txtStudentNumber.Text, ddlClass.SelectedValue, txtStudentName.Text, ddlSex.SelectedItem.Value, birthday, txtIdentity.Text, txtTel.Text, ddlProvince.SelectedValue, ddlStuFace.SelectedItem.Text, ddlMingZu.SelectedValue, txtHomeAddress.Text, txtRemark.Text);
            student.AddStudent(studentInf);
        }
        catch
        {
            JScript.AlertAndRedirect("日期格式错误!","AddStudent.aspx");
        }
        
    }
}
