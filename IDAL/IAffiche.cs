using System;
using System.Data;
using System.Text;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    /// <summary>
    /// 公告接口
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public interface IAffiche
    {
        #region 获取公告信息
        /// <summary>
        /// 获取公告信息
        /// </summary>
        /// <returns>公告信息</returns>
        DataSet GetAffiches();
        #endregion

        #region 获取要查看的公告信息
        /// <summary>
        /// 获取要查看的公告信息
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <returns></returns>
        DataSet GetAffiche(int af_Id);
        #endregion

        #region 发表公告
        /// <summary>
        /// 发表公告
        /// </summary>
        /// <param name="afficheInf">公告信息实体</param>
        /// <returns></returns>
        bool AddAffiche(AfficheInf afficheInf);
        #endregion

        #region  删除公告信息
        /// <summary>
        /// 删除公告信息
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dp_Id">部门ID</param>
        /// <returns></returns>
        int DelAffiche(int af_Id, string dp_Id);
        #endregion

        #region 获取要更新的
        /// <summary>
        /// 获取要更新的
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dp_Id">部门ID</param>
        /// <returns></returns>
        AfficheInf  GetAfficheForUpdate(int af_Id, string dp_Id);
        #endregion

        #region 修改公告信息
        /// <summary>
        /// 修改公告信息
        /// </summary>
        /// <param name="afficheInf">公告实体</param>
        /// <returns></returns>
        bool UpdateAffiche(AfficheInf afficheInf);
        #endregion
    }
}
