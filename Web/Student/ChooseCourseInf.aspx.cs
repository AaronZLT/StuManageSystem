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

public partial class Student_ChooseCourseInf : System.Web.UI.Page
{
    #region ±äÁ¿ÉùÃ÷
    private Course course = new Course();
    private string learn_Year = "2004-2005";
    private string learn_Term= "1";
    private string dp_Id = string.Empty;
    private string sp_Id = string.Empty;
    private int learn_YearSelectIndex =0;
    private int learn_TermSelectIndex = 0;
    private string st_id = HttpContext.Current.User.Identity.Name;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        course.BindStudentInf(HttpContext.Current.User.Identity.Name, lblTitle, ref dp_Id, ref sp_Id);
        course.GetChooseCourseTable(st_id, learn_Year, Convert.ToInt32(learn_Term), gv_ChooseClassTb);
    }
    protected void ddlLearnTerm_SelectedIndexChanged(object sender, EventArgs e)
    {
        learn_Year = ddlLearnYear.SelectedValue;
        learn_Term = ddlLearnTerm.SelectedValue;
        learn_TermSelectIndex = ddlLearnTerm.SelectedIndex;
        learn_YearSelectIndex = ddlLearnYear.SelectedIndex;
    }
    protected void btnviewAll_Click(object sender, EventArgs e)
    {
        course.GetChooseCourseTable(st_id, "all",0, gv_ChooseClassTb);
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        course.GetChooseCourseTable(st_id,ddlLearnYear.SelectedValue,Convert.ToInt32(ddlLearnTerm.SelectedValue), gv_ChooseClassTb);       
    }
}
