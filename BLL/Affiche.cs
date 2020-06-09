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

#region ҵ���߼��㹫��ʵ��
namespace StudentManager.BLL
{
    /// <summary>
    /// ҵ���߼��㹫��ʵ��
    /// </summary>
    public class Affiche
    {
        #region ����ʵ��������ʵ��
        /// <summary>
        /// ����ʵ��������ʵ��
        /// </summary>
        IAffiche affiche = DataAccess.CreateAffiche();
        #endregion 

        #region  �����ݵ�ҳ�����ݿؼ�
        /// <summary>
        /// �����ݵ�ҳ�����ݿؼ�
        /// </summary>
        /// <param name="gdvAffiche"></param>
        public void BindAffiches(GridView gdvAffiche)
        {
            gdvAffiche.DataSource = affiche.GetAffiches();
            gdvAffiche.DataBind();
        }
        #endregion

        #region ��ָ��������Ϣ
        /// <summary>
        /// ��ָ��������Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dvAfficheDetails">��ϸ�ؼ�</param>
        /// <returns></returns>
        public void BindAffiche(int af_Id,DetailsView dvAfficheDetails)
        {
            dvAfficheDetails.DataSource=affiche.GetAffiche(af_Id);
            dvAfficheDetails.DataBind();
        }
        #endregion

        #region ��ȡ������Ϣ��
        /// <summary>
        /// ��ȡ������Ϣ��
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <returns>������Ϣ��</returns>
        public DataTable GetAfficheTb(int af_Id)
        {
            return affiche.GetAffiche(af_Id).Tables[0];
        }
        #endregion

        #region ��������Ϣ
        /// <summary>
        /// ��������Ϣ
        /// </summary>
        /// <param name="afficheInf">����ʵ��</param>
        public void Add_Affiche(AfficheInf afficheInf)
        {
            if (afficheInf.Af_EnableTime < DateTime.Now)
            {
                JScript.Alert("�������Ч����С������������!");
            }
            else
            {
                if (affiche.AddAffiche(afficheInf) == false)
                {
                    JScript.AlertAndRedirect("������ʧ��!", "AddAffiche.aspx");
                }
                else
                {
                    JScript.AlertAndRedirect("������ɹ�!", "AddAffiche.aspx");                    
                }
            }
        }
        #endregion

        #region ɾ��������Ϣ
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">����ID</param>
        /// <returns></returns>
        public void DelAffiche(int af_Id, string dp_Id)
        {
            int int_reault = affiche.DelAffiche(af_Id, dp_Id);
            if (int_reault==-1)
            {
                JScript.AlertAndRedirect("��û��Ȩ��!ɾ���������ŵĹ�����Ϣ.", "Default.aspx");
            }
            if(int_reault==0)
            {
                JScript.AlertAndRedirect("������Ϣɾ��ʧ��,������!", "Default.aspx");
            }
        }
        #endregion

        #region ���ع������
        /// <summary>
        /// ���ع������
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">���ű��</param>
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

        #region �޸Ĺ�����Ϣ
        /// <summary>
        /// �޸Ĺ�����Ϣ
        /// </summary>
        /// <param name="afficheInf">����ʵ��</param>
        /// <returns></returns>
        public void UpdateAffiche(AfficheInf afficheInf)
        {
            if (affiche.UpdateAffiche(afficheInf) == false)
            {
                JScript.Alert("�޸Ĺ�����Ϣʧ��!");
            }
            else
            {
                JScript.AlertAndRedirect("�޸Ĺ�����Ϣ�ɹ�!","Default.aspx");
            }
        }
        #endregion

    }
}
#endregion
