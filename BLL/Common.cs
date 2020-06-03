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
    /// 公共信息实体业务层
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public  class Common
    {
        #region 反射创建公共信息实体
        private ICommon common = DataAccess.CreateCommon();
        #endregion

        #region 获取用户基本欢迎信息
        /// <summary>
        /// 获取用户基本欢迎信息
        /// </summary>
        /// <param name="u_Id">用户ID</param>
        /// <returns>用户名</returns>
        public string GetUseWelInf(string u_Id)
        {
            string table = HttpContext.Current.Session["role"].ToString();
            return u_Id+" "+common.GetUserWelInf(u_Id,table)+" ";

        }
        #endregion

        #region 绑定学历列表到下拉列表框
        public void BindLearnList(DropDownList ddlLearnList)
        {
            ddlLearnList.DataSource = common.GetLearnList();
            ddlLearnList.DataTextField = "lg_name";
            ddlLearnList.DataValueField = "lg_name";
            ddlLearnList.DataBind();
        }
        #endregion

        #region 绑定教师职称到下拉列表框
        public void BindZhiChengList(DropDownList ddlZhiChengList)
        {
            ddlZhiChengList.DataSource = common.GetZhiChengList();
            ddlZhiChengList.DataTextField = "zc_name";
            ddlZhiChengList.DataValueField = "zc_name";
            ddlZhiChengList.DataBind();
        }
        #endregion

        #region 绑定政治面貌列表
        public void BindZZList(DropDownList ddlZZList)
        {
            ddlZZList.DataSource = common.GetZZList();
            ddlZZList.DataTextField = "zf_name";
            ddlZZList.DataValueField = "zf_id";
            ddlZZList.DataBind();
        }
        #endregion

        #region 获取民族列表
        public void BindMZList(DropDownList ddlMZList)
        {
            ddlMZList.DataSource = common.GetMZList();
            ddlMZList.DataTextField = "mz_name";
            ddlMZList.DataValueField = "mz_name";
            ddlMZList.DataBind();
        }
        #endregion 

        #region 绑定省列表
        public void BindProvinceList(DropDownList ddlProvinceList)
        {
            ddlProvinceList.DataSource = common.GetProvinceList();
            ddlProvinceList.DataTextField = "pr_name";
            ddlProvinceList.DataValueField = "pr_name";
            ddlProvinceList.DataBind();
        }
        #endregion

        #region 绑定城市列表
        public void BindeCityList(string province, DropDownList ddlCityList)
        {
            ddlCityList.DataSource = common.GetCityList(province);
            ddlCityList.DataTextField = "ci_name";
            ddlCityList.DataValueField = "ci_name";
            ddlCityList.DataBind();
        }
        #endregion

        #region 绑定专业信息到下拉列表
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
