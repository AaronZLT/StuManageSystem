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

public partial class Teacher_ViewStudentChoose : System.Web.UI.Page
{
    #region 变量定义
    private Course course = new Course();
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        course.ChooseStudentTb(Request.QueryString["pc_id"].ToString(), gv_StudentTb);
    }
    #endregion

    #region 导出EXCEL
    protected void btnExportNames_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.Charset = "GB2312";
        Response.AppendHeader("Content-Disposition", "attachment;filename=FileName.xls");
        Response.ContentEncoding = System.Text.Encoding.UTF7;
        Response.ContentType = "application/ms-excel";
        System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
        this.gv_StudentTb.RenderControl(oHtmlTextWriter);
        Response.Output.Write(oStringWriter.ToString());
        Response.Flush();
        Response.End();
    }
    #endregion

    #region 重载VerifyRenderingInServerForm
    public override void VerifyRenderingInServerForm(Control control)
    {

    }
    #endregion

}
