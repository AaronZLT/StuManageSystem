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
using StudentManager.Common;


public partial class Department_AddAffiche : System.Web.UI.Page
{
    private AfficheInf afficheInf;
    private Affiche affiche = new Affiche();
    private DateTime af_EnableTime;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAddAffiche_Click(object sender, EventArgs e)
    {
        try
        {
            af_EnableTime = Convert.ToDateTime(txtEnbaleTime.Text);
            afficheInf = new AfficheInf(HttpContext.Current.User.Identity.Name.ToString(), txtAfficheTitle.Text, txtAfficheContent.Text, af_EnableTime, "..\\AfficheFiles\\" + Get_Af_FileName());
            affiche.Add_Affiche(afficheInf);
            UpLoadFile();
        }
        catch
        {
            JScript.AlertAndRedirect("日期格式错误!", "AddAffiche.aspx");
        }

    }
    private string Get_Af_FileName()
    {
        return  fluAfficheFile.PostedFile.FileName.Substring(fluAfficheFile.PostedFile.FileName.LastIndexOf('\\') + 1);
    }
    private void UpLoadFile()
    {
        string path=Server.MapPath("../AfficheFiles/");
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
