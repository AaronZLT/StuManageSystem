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

public partial class Student_QueryScore : System.Web.UI.Page
{
    #region ��������
    private Course course = new Course();
    private string dp_Id = string.Empty;
    private string sp_Id = string.Empty;
    private string st_id = HttpContext.Current.User.Identity.Name;
    #endregion

    #region ҳ�����
    protected void Page_Load(object sender, EventArgs e)
    {
        course.BindStudentInf(HttpContext.Current.User.Identity.Name, lblTitle, ref dp_Id, ref sp_Id);
    }
    #endregion

    #region ��ѯָ��ʱ��ɼ�
    protected void btnView_Click(object sender, EventArgs e)
    {
        course.GetScoreTable(st_id, ddlLearnYear.SelectedValue, Convert.ToInt32(ddlLearnTerm.SelectedValue), gv_ScoreTable);
    }
    #endregion

    #region ��ѯ��У���гɼ�
    protected void btnviewAll_Click(object sender, EventArgs e)
    {
        course.GetScoreTable(st_id, "all", 0, gv_ScoreTable);
    }
    #endregion 
}
