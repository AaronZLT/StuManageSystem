using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.DBUtility;


namespace StudentManager.SQLServer
{
    /// <summary>
    /// 公共数据访问
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public class Common:SqlServerBaseDb,ICommon
    {
        #region 存储过程参数常量
        private const string UID="@Uid";
        private const string UTABLE="@Utable";
        private const string USERNAME = "@Username";
        private const string PROVINCE="@Province";
        #endregion

        #region  获取用户基本欢迎信息
        /// <summary>
        /// 获取用户基本欢迎信息
        /// </summary>
        /// <param name="u_Id">用户ID</param>
        /// <param name="U_Table">用户表</param>
        /// <returns>用户名</returns>
        public string GetUserWelInf(string u_Id, string u_Table)
        {
            SqlParameter[] parms ={
                MakeInParm(UID,SqlDbType.VarChar,20,u_Id),
                MakeInParm(UTABLE,SqlDbType.VarChar,20,u_Table),
                MakOutParm(USERNAME,SqlDbType.VarChar,20)
            };
            
            try
            {
                ExecProc("GetUserWelcomeInf",parms);
                return parms[2].Value.ToString();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取学历列表
        public  DataTable GetLearnList()
        {
            try
            {
                return ExecProcDs("GetLearnList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取教师职称列表
        public DataTable GetZhiChengList()
        {
            try
            {
                return ExecProcDs("GetZhiChengList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取政治面貌列表
        public DataTable GetZZList()
        {
            try
            {
                return ExecProcDs("GetZZList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取民族列表
        public DataTable GetMZList()
        {
            try
            {
                return ExecProcDs("GetMZList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion 

        #region 获取省列表
        public DataTable GetProvinceList()
        {
            try
            {
                return ExecProcDs("GetProvinceList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取市列表
        public DataTable GetCityList(string province)
        {
            SqlParameter[] parms ={
                MakeInParm(PROVINCE,SqlDbType.VarChar,10,province)
            };
            try
            {
                return ExecProcDs("GetCityList", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 绑定专业信息到下拉列表框
        public DataTable GetSpecialityListForBind()
        {
            try
            {
                return ExecProcDs("GetSpecialityListForBind", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion


    }
}
