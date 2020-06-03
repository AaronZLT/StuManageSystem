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
using System.IO;
using StudentManager.Common;

public partial class Student_AfficheInf : System.Web.UI.Page
{

    Affiche af = new Affiche();
    private static int af_Id;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            af_Id = Convert.ToInt32(Request.QueryString["id"]);
            af.BindAffiche(af_Id, AffDetails);
        }
    }
    public string GetFileName()
    {
        return Eval("af_filepath").ToString().Substring(16);
    }


    protected void lbtnFileName_Click(object sender, EventArgs e)
    {
        string fileName = "..\\AfficheFiles\\" + ((LinkButton)AffDetails.FindControl("lbtnFileName")).Text.ToString();
        try
        {
            FileInfo fileinf = new FileInfo(fileName);
            Response.Clear();
            Response.Charset = "utf-8";
            Response.Buffer = true;
            this.EnableViewState = false;
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + fileName.Substring(16));
            Response.ContentType = "application/unknown";
            Response.WriteFile(fileName);
            Response.Flush();
            Response.Close();
            Response.End();
        }
        catch
        {
            JScript.Alert("相关文件不存在");
        }
    }
}
