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

public partial class Guest_AfficheDetails : System.Web.UI.Page
{
    Affiche af = new Affiche();
    private static int af_Id;
    DataTable afficheTable = new DataTable();
    public DataRow dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            af_Id = Convert.ToInt32(Request.QueryString["id"]);
            afficheTable = af.GetAfficheTb(af_Id);
            for (int i = 0; i < afficheTable.Rows.Count; i++)
            {
                dr = afficheTable.Rows[i];
            }
        }
    }

}
