using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using StudentManager.DALFactory;
using StudentManager.IDAL;
using StudentManager.Model;
using StudentManager.SQLServer;

#region 专业业务逻辑层
namespace StudentManager.BLL
{
    /// <summary>
    /// 逻辑层专业类体
    /// 作者:余洪
    /// 时间:2008-05-01
    /// </summary>
    public class Speciality
    {
        #region 利用反射工厂创建专业类
        private ISpeciality speciality = DataAccess.CreateSpeciality();
        #endregion

        #region 绑定专业列表信息
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        public void  BindSpecialityList(string dp_Id, string sp_Grade,GridView gvSpecialityList)
        {
            DataTable tb=speciality.GetSpecialityList(dp_Id, sp_Grade);
            gvSpecialityList.DataSource = tb;
            gvSpecialityList.DataBind();
        }
        #endregion

        #region 按学院绑定专业列表信息
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        public void BindSpecialityList(string dp_Id,DropDownList ddlSpecialityList)
        {
            ddlSpecialityList.DataSource = speciality.GetSpecialityList(dp_Id);
            ddlSpecialityList.DataTextField = "sp_name";
            ddlSpecialityList.DataValueField = "sp_id";
            ddlSpecialityList.DataBind();
        }
        #endregion

    }
}
#endregion