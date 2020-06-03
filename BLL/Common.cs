using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.Common;
using StudentManager.DALFactory;

namespace StudentManager.BLL
{
    /// <summary>
    /// ������Ϣʵ��ҵ���
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public  class Common
    {
        #region ���䴴��������Ϣʵ��
        private ICommon common = DataAccess.CreateCommon();
        #endregion

        #region ��ȡ�û�������ӭ��Ϣ
        /// <summary>
        /// ��ȡ�û�������ӭ��Ϣ
        /// </summary>
        /// <param name="u_Id">�û�ID</param>
        /// <returns>�û���</returns>
        public string GetUseWelInf(string u_Id)
        {
            string table = HttpContext.Current.Session["role"].ToString();
            return u_Id+" "+common.GetUserWelInf(u_Id,table)+" ";

        }
        #endregion

        #region ��ѧ���б������б��
        public void BindLearnList(DropDownList ddlLearnList)
        {
            ddlLearnList.DataSource = common.GetLearnList();
            ddlLearnList.DataTextField = "lg_name";
            ddlLearnList.DataValueField = "lg_name";
            ddlLearnList.DataBind();
        }
        #endregion

        #region �󶨽�ʦְ�Ƶ������б��
        public void BindZhiChengList(DropDownList ddlZhiChengList)
        {
            ddlZhiChengList.DataSource = common.GetZhiChengList();
            ddlZhiChengList.DataTextField = "zc_name";
            ddlZhiChengList.DataValueField = "zc_name";
            ddlZhiChengList.DataBind();
        }
        #endregion

        #region ��������ò�б�
        public void BindZZList(DropDownList ddlZZList)
        {
            ddlZZList.DataSource = common.GetZZList();
            ddlZZList.DataTextField = "zf_name";
            ddlZZList.DataValueField = "zf_id";
            ddlZZList.DataBind();
        }
        #endregion

        #region ��ȡ�����б�
        public void BindMZList(DropDownList ddlMZList)
        {
            ddlMZList.DataSource = common.GetMZList();
            ddlMZList.DataTextField = "mz_name";
            ddlMZList.DataValueField = "mz_name";
            ddlMZList.DataBind();
        }
        #endregion 

        #region ��ʡ�б�
        public void BindProvinceList(DropDownList ddlProvinceList)
        {
            ddlProvinceList.DataSource = common.GetProvinceList();
            ddlProvinceList.DataTextField = "pr_name";
            ddlProvinceList.DataValueField = "pr_name";
            ddlProvinceList.DataBind();
        }
        #endregion

        #region �󶨳����б�
        public void BindeCityList(string province, DropDownList ddlCityList)
        {
            ddlCityList.DataSource = common.GetCityList(province);
            ddlCityList.DataTextField = "ci_name";
            ddlCityList.DataValueField = "ci_name";
            ddlCityList.DataBind();
        }
        #endregion

        #region ��רҵ��Ϣ�������б�
        public void BindSpecialityListForDDl(DropDownList ddlSpeciality)
        {
            ddlSpeciality.DataSource = common.GetSpecialityListForBind();
            ddlSpeciality.DataTextField = "sp_name";
            ddlSpeciality.DataValueField = "sp_id";
            ddlSpeciality.DataBind();
        }
        #endregion
    }
}
