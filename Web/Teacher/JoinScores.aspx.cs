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
using System.Data.OleDb;
using StudentManager.BLL;

public partial class Teacher_JoinScores : System.Web.UI.Page
{
    #region 变量声明
    private Course course = new Course();
    private string te_id = HttpContext.Current.User.Identity.Name;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //course.GetCourseList(te_id, ddlScoreList);
            course.BindStForUpdateScore(Session["cb_id"].ToString(), Session["pc_year"].ToString(), Convert.ToInt32(Session["pc_term"].ToString()), gCourses);
        }
    }

    protected void btnStudentList_Click(object sender, EventArgs e)
    {
       // course.BindStForUpdateScore(ddlScoreList.SelectedValue, ddlYear.SelectedValue, Convert.ToInt32(ddlTerm.SelectedValue), gCourses);
    }

    #region 导出EXCEL
    protected void btnExport_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.Charset = "GB2312";
        Response.AppendHeader("Content-Disposition", "attachment;"+FileUp.PostedFile.FileName);
        Response.ContentEncoding = System.Text.Encoding.UTF7;
        Response.ContentType = "application/ms-excel";
        System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
        gCourses.RenderControl(oHtmlTextWriter);
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

    #region 批量更新成绩
    protected void btnImport_Click(object sender, EventArgs e)
    {
        
    }
    #endregion

    protected void BtnOKToImport_Click(object sender, EventArgs e)
    {
        if (course.UpdateScore(gCourses,te_id) == "yes")
        {
            this.Page.RegisterClientScriptBlock("message", "<script javascript>alert('EXCEL中有成绩没有导入成功');location.replace('JoinScores.aspx');</script>");
        }
        else
        {
            this.Page.RegisterClientScriptBlock("message", "<script javascript>alert('导入成功');location.repalce('JoinScores');</script>"); 
        }
    }

    protected void btnPrivew_Click(object sender, EventArgs e)
    {
        string strConn;
        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source="+FileUp.PostedFile.FileName + " ; Extended Properties=Excel 8.0;";
        OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", strConn);
        DataSet myDataSet = new DataSet();
        myCommand.Fill(myDataSet, "ExcelInfo");
        gCourses.DataSource = myDataSet.Tables["ExcelInfo"].DefaultView;
        gCourses.DataBind();
    }
}
