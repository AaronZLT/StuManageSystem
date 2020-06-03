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

public partial class Teacher_TeachCourseTable : System.Web.UI.Page
{
    #region ��������
    private Course course = new Course();
    private string te_id = HttpContext.Current.User.Identity.Name;
    #endregion

    #region ҳ�����
    protected void Page_Load(object sender, EventArgs e)
    {
        course.TecherTeachCourses(te_id, gv_TeachCoures);
    }
    #endregion

    #region �鿴ѡ��ѧ��
    protected void gv_TeachCoures_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        Response.Redirect("ViewStudentChoose.aspx?pc_id=" + e.CommandArgument.ToString());
    }
    #endregion

}
