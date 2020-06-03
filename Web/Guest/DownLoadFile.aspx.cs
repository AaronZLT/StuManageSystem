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
using System.IO;
using StudentManager.Common;

public partial class Guest_DownLoadFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        string fileName = "..\\AfficheFiles\\" + Request.QueryString["fname"].ToString();
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
