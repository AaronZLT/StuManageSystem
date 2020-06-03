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

public partial class Department_PwdManager : System.Web.UI.Page
{
    private Department dept = new Department();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        if (txtNewPwd.Text == txtReNewPwd.Text)
        {
            if (ddlObject.SelectedValue == "����" && HttpContext.Current.User.ToString() != "01")
            {
                lblMessage.Text = "ֻ�н��񴦲��д�Ȩ��";
            }
            else
            {
                dept.ReSetPwd(ddlObject.SelectedItem.Text, txtNumber.Text, txtNewPwd.Text, lblMessage);
            }
        }
        else
        {
            lblMessage.Text = "�������벻һ��";
        }
    }
}
