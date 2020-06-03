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
using StudentManager.Model;
using StudentManager.BLL;

public partial class Department_AddCollege : System.Web.UI.Page
{
    private Department dept = new Department();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddStudent_Click(object sender, EventArgs e)
    {
        DepartmentInf deptInf = new DepartmentInf(txtCollegeNumber.Text, txtSysPwd.Text, txtCollegeName.Text, txtAddress.Text, txtTel.Text, txtRemark.Text);
        dept.AddDept(deptInf);
        
        
    }
}
