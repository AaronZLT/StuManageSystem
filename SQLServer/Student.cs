using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.DBUtility;
using StudentManager.IDAL;
using StudentManager.Model;

namespace StudentManager.SQLServer
{
    /// <summary>
    /// 学生数据访问层
    /// </summary>
    public class Student:SqlServerBaseDb,IStudent
    {
        #region 存储过程参数常量
        private const string ST_ID = "@St_id";
        private const string CL_ID="@Cl_id ";
        private const string ST_NAME="@St_name";
        private const string ST_SEX="@St_sex";
        private const string ST_BIRTHDAY="@St_birthday";
        private const string MZ_NAME="@Mz_name";
        private const string ST_IDENTTITY="@St_identity";
        private const string ST_TEL="@St_tel";
        private const string ST_PROVINCE="@St_province";
        private const string ST_FACE="@St_face";
        private const string ST_ADDRESS="@St_address";
        private const string ST_REMARK="@St_remark";
        private const string ST_PWD = "@St_pwd";
        private const string ST_OLDPWD = "@St_oldpwd";
        private const string ST_NEWPWD = "@St_newpwd";
        private const string ST_RENEWPWD= "@St_renewpwd";
        private const string DP_NAME = "@Dp_name";
        private const string SP_NAME = "@Sp_name";
        private const string CL_NAME = "@Cl_name";


        #endregion

        #region  验证登陆
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="st_ID">学生ID</param>
        /// <param name="st_Pwd">密码</param>
        /// <returns>是否修改成功</returns>
        public bool ValidLogin(string st_Id, string st_Pwd)
        {
             SqlParameter[] parms={
                 MakeInParm(ST_ID,SqlDbType.VarChar,20,st_Id),
                 MakeInParm(ST_PWD,SqlDbType.VarChar,20,st_Pwd)
             };
             try
             {
                 return ExecProc("Valid_St_Login", parms) > 0?true:false;
                 
             }
             catch
             {
                 return false;
             }
         }
        #endregion

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_OldPwd">原密码</param>
        /// <param name="st_NewPwd">新密码</param>
        /// <param name="st_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        public int ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd)
        {
            SqlParameter[] parms ={
                MakeInParm(ST_ID,SqlDbType.VarChar,20,st_Id),
                MakeInParm(ST_OLDPWD,SqlDbType.VarChar,20,st_OldPwd),
                MakeInParm(ST_NEWPWD,SqlDbType.VarChar,20,st_NewPwd),
                MakeInParm(ST_RENEWPWD,SqlDbType.VarChar,20,st_ReNewPwd)
            };
            try
            {
                return ExecProc("St_ChangePwd", parms);
            }
            catch
            {
                return 0;
            }

        }
        #endregion

        #region 添加学生信息
        public int AddStudent(StudentInf studentInf)
        {
            SqlParameter[] parms ={
               MakeInParm(ST_ID,SqlDbType.VarChar,20,studentInf.St_Id),
               MakeInParm(CL_ID,SqlDbType.Char,30,studentInf.Cl_Id),
               MakeInParm(ST_NAME,SqlDbType.VarChar,20,studentInf.St_Name),
               MakeInParm(ST_SEX,SqlDbType.Char,2,studentInf.St_Sex),
               MakeInParm(ST_BIRTHDAY,SqlDbType.DateTime,0,studentInf.St_Birthday),
               MakeInParm(MZ_NAME,SqlDbType.VarChar,16,studentInf.Mz_Name),
               MakeInParm(ST_IDENTTITY,SqlDbType.Char,18,studentInf.St_Identity),
               MakeInParm(ST_TEL,SqlDbType.Char,11,studentInf.St_Tel),
               MakeInParm(ST_PROVINCE,SqlDbType.VarChar,10,studentInf.St_Province),
               MakeInParm(ST_FACE,SqlDbType.VarChar,10,studentInf.St_Face),
               MakeInParm(ST_ADDRESS,SqlDbType.VarChar,20,studentInf.St_Address),
               MakeInParm(ST_REMARK,SqlDbType.VarChar,600,studentInf.St_Remark)
           };
            try
            {
                return ExecProc("AddStudent", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 获取学生列表信息
        public DataTable GetStudentList(string dp_Name, string sp_Name, string cl_Name)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_NAME,SqlDbType.VarChar,20,dp_Name),
                MakeInParm(SP_NAME,SqlDbType.VarChar,35,sp_Name),
                MakeInParm(CL_NAME,SqlDbType.VarChar,40,cl_Name)
            };
            try
            {
                return ExecProcDs("GetStudentList", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取学生详细
        public DataTable DisplayStudentDetialsInf(string st_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(ST_ID,SqlDbType.VarChar,20,st_Id),
            };
            try
            {
                return ExecProcDs("DisplayStudentDetailsInf", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

    }
}
