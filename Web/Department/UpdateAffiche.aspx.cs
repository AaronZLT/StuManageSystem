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
using StudentManager.Model;
using StudentManager.Common;

public partial class Department_UpdateAffiche : System.Web.UI.Page
{
    Affiche affiche = new Affiche();
    AfficheInf afficheInf;
    private DateTime af_EnableTime;

    protected void Page_Load(object sender, EventArgs e)
    {
        affiche.BindAfForUpdate(Convert.ToInt32(Request.QueryString["af_id"]), HttpContext.Current.User.Identity.Name.ToString(),txtAfficheTitle,txtAfficheContent,txtEnbaleTime);

    }

    protected void btnUpdateAffiche_Click(object sender, EventArgs e)
    {
        try
        {
            af_EnableTime = Convert.ToDateTime(txtEnbaleTime.Text);
            afficheInf = new AfficheInf(Convert.ToInt32(Request.QueryString["af_id"]), HttpContext.Current.User.Identity.Name.ToString(), txtAfficheTitle.Text, txtAfficheContent.Text, af_EnableTime, "..\\AfficheFiles\\" + Get_Af_FileName());
            affiche.UpdateAffiche(afficheInf);
            UpLoadFile();
        }
        catch
        {
            JScript.AlertAndRedirect("日期格式错误!", "AddAffiche.aspx");
        }
    }

    private string Get_Af_FileName()
    {
        return fluAfficheFile.PostedFile.FileName.Substring(fluAfficheFile.PostedFile.FileName.LastIndexOf('\\') + 1);
    }
    private void UpLoadFile()
    {
        string path = Server.MapPath("../AfficheFiles/");
        if (fluAfficheFile.HasFile)
        {
            try
            {
                fluAfficheFile.PostedFile.SaveAs(path + fluAfficheFile.FileName);
            }
            catch
            {
                lblMessage.Text = "上传文件失败!";
            }

        }
    }

}
