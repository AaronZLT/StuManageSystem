using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using StudentManager.Model;
using StudentManager.DBUtility;
using StudentManager.IDAL;

namespace StudentManager.SQLServer
{
    /// <summary>
    /// 数据访问层专业实体类
    /// </summary>
    public class Speciality:SqlServerBaseDb,ISpeciality
    {
        #region 数据访问层存储过程参数常量
        private const string SP_ID = "@Sp_id";  //专业编号
        private const string DP_ID = "@Dp_id";  //学院编号
        private const string SP_GRADE = "@Sp_grade"; // 专业年级
        #endregion

        #region 获取专业列表信息
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        public DataTable GetSpecialityList(string dp_Id,string sp_Grade)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id),
                MakeInParm(SP_GRADE,SqlDbType.Char,4,sp_Grade)
            };
            try
            {
                return ExecProcDs("GetSpecialityList", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取专业列表信息
        /// <summary>
        /// 获取专业列表
        /// </summary>
        /// <returns>专业信息列表</returns>
        public DataTable GetSpecialityList(string dp_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id)
            };
            try
            {
                return ExecProcDs("GetSpecialityListByCollegeId", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 删除专业
        /// <summary>
        /// 删除专业
        /// </summary>
        /// <param name="sp_Id"></param>
        /// <returns></returns>
        public bool DelSpeciality(string sp_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(SP_ID,SqlDbType.Char,20,sp_Id)
            };
            try
            {
                return ExecProc("", parms) == 1 ? true : false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
