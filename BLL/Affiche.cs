using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.Common;
using StudentManager.DALFactory;
using StudentManager.Model;

#region 业务逻辑层公告实体
namespace StudentManager.BLL
{
    /// <summary>
    /// 业务逻辑层公告实体
    /// </summary>
    public class Affiche
    {
        #region 工厂实例化公告实体
        /// <summary>
        /// 工厂实例化公告实体
        /// </summary>
        IAffiche affiche = DataAccess.CreateAffiche();
        #endregion 

        #region  绑定数据到页面数据控件
        /// <summary>
        /// 绑定数据到页面数据控件
        /// </summary>
        /// <param name="gdvAffiche"></param>
        public void BindAffiches(GridView gdvAffiche)
        {
            gdvAffiche.DataSource = affiche.GetAffiches();
            gdvAffiche.DataBind();
        }
        #endregion

        #region 绑定指定公告信息
        /// <summary>
        /// 绑定指定公告信息
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dvAfficheDetails">详细控件</param>
        /// <returns></returns>
        public void BindAffiche(int af_Id,DetailsView dvAfficheDetails)
        {
            dvAfficheDetails.DataSource=affiche.GetAffiche(af_Id);
            dvAfficheDetails.DataBind();
        }
        #endregion

        #region 获取公告信息表
        /// <summary>
        /// 获取公告信息表
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <returns>公告信息表</returns>
        public DataTable GetAfficheTb(int af_Id)
        {
            return affiche.GetAffiche(af_Id).Tables[0];
        }
        #endregion

        #region 发表公告信息
        /// <summary>
        /// 发表公告信息
        /// </summary>
        /// <param name="afficheInf">公告实体</param>
        public void Add_Affiche(AfficheInf afficheInf)
        {
            if (afficheInf.Af_EnableTime < DateTime.Now)
            {
                JScript.Alert("输入的有效日期小于了现在日期!");
            }
            else
            {
                if (affiche.AddAffiche(afficheInf) == false)
                {
                    JScript.AlertAndRedirect("发表公告失败!", "AddAffiche.aspx");
                }
                else
                {
                    JScript.AlertAndRedirect("发表公告成功!", "AddAffiche.aspx");                    
                }
            }
        }
        #endregion

        #region 删除公告信息
        /// <summary>
        /// 删除公告信息
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dp_Id">部门ID</param>
        /// <returns></returns>
        public void DelAffiche(int af_Id, string dp_Id)
        {
            int int_reault = affiche.DelAffiche(af_Id, dp_Id);
            if (int_reault==-1)
            {
                JScript.AlertAndRedirect("你没有权限!删除其他部门的公告信息.", "Default.aspx");
            }
            if(int_reault==0)
            {
                JScript.AlertAndRedirect("公告信息删除失败,请重试!", "Default.aspx");
            }
        }
        #endregion

        #region 返回公告的行
        /// <summary>
        /// 返回公告的行
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dp_Id">部门编号</param>
        /// <returns></returns>
        public void BindAfForUpdate(int af_Id, string dp_Id,TextBox txtAfTitle,TextBox txtAfContent,TextBox txt_Af_EnableTile)
        {
            AfficheInf afficheInf = affiche.GetAfficheForUpdate(af_Id, dp_Id);
            if (afficheInf != null)
            {
                txtAfTitle.Text = afficheInf.Af_Title;
                txtAfContent.Text = afficheInf.Af_Content;
                txt_Af_EnableTile.Text = afficheInf.Af_EnableTime.ToString();         
            }
        }
        #endregion

        #region 修改公告信息
        /// <summary>
        /// 修改公告信息
        /// </summary>
        /// <param name="afficheInf">公告实体</param>
        /// <returns></returns>
        public void UpdateAffiche(AfficheInf afficheInf)
        {
            if (affiche.UpdateAffiche(afficheInf) == false)
            {
                JScript.Alert("修改公告信息失败!");
            }
            else
            {
                JScript.AlertAndRedirect("修改公告信息成功!","Default.aspx");
            }
        }
        #endregion

    }
}
#endregion
