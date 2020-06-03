using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentManager.IDAL
{
    /// <summary>
    /// 专业接口层
    /// </summary>
    public interface ISpeciality
    {
        #region 获取专业列表
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        DataTable GetSpecialityList(string dp_Id, string sp_Grade);
        #endregion

        #region 删除专业
        /// <summary>
        /// 删除专业
        /// </summary>
        /// <param name="sp_Id"></param>
        /// <returns></returns>
        bool DelSpeciality(string sp_Id);
        #endregion

        #region 按学院获取专业列表信息
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        DataTable GetSpecialityList(string dp_Id);
        #endregion

    }
}
