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

public partial class Department_AddClass : System.Web.UI.Page
{
    private StuClass stuClass = new StuClass();
    private Common common = new Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            common.BindSpecialityListForDDl(ddlSpeciality);
        }
    }
    protected void btnAddTeacher_Click(object sender, EventArgs e)
    {
        ClassInf classInf=new ClassInf(txtClassID.Text,ddlSpeciality.SelectedValue,txtClassName.Text,txtRemark.Text);
        stuClass.AddClass(classInf);
    }
}
