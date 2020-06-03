using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StudentManager.IDAL
{
    public interface ICommon
    {
        #region 获取系统登陆账户基本欢迎信息
        /// <summary>
        /// 获取系统登陆账户基本欢迎信息
        /// </summary>
        /// <returns></returns>
        string GetUserWelInf(string u_Id, string u_Table);
        #endregion

        #region 获取学历列表
        DataTable GetLearnList();
        #endregion

        #region 获取教师职称列表
        DataTable GetZhiChengList();
        #endregion

        #region 获取政治面貌列表
        DataTable GetZZList();
        #endregion

        #region 获取民族列表
        DataTable GetMZList();
        #endregion 

        #region 获取省列表
        DataTable GetProvinceList();
        #endregion

        #region 获取市列表
        DataTable GetCityList(string province);
        #endregion

        #region 绑定专业信息到下拉列表框
        DataTable  GetSpecialityListForBind();
        #endregion
    }
}
