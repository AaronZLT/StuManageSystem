using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.DBUtility;
using StudentManager.Model;

namespace StudentManager.SQLServer
{  
    
    /// <summary>
    /// 数据访问层
    /// </summary>
    public class Teacher:SqlServerBaseDb,ITeacher
    {

        #region 存储过程参数常量
        private const string TE_ID = "@Te_id";
        private const string TE_PWD = "@Te_pwd";
        private const string TE_OLDPWD = "@Te_oldpwd";
        private const string TE_NEWPWD = "@Te_newpwd";
        private const string TE_RENEWPWD = "@Te_renewpwd";
        private const string DP_ID="@Dp_id";
        private const string LG_NAME="@Lg_name";
        private const string ZC_NAME="@Zc_name";
        private const string TE_NAME="@Te_name";
        private const string TE_SEX="@Te_sex";
        private const string TE_IDENTITY="@Te_identity";
        private const string TE_SPECIALITY="@Te_speciality";
        private const string TE_ADDRESS="@Te_address";
        private const string TE_ZZFACE="@Te_zzface ";
        private const string TE_MINZU="@Te_minzu";
        private const string TE_TEL="@Te_tel";
        private const string TE_BIRTIDAY="@Te_birthday";
        private const string TE_TEACHERTIME="@Te_teachtime";
        private const string TE_PROVINCE ="@Tb_Province";
        private const string TE_REMARK="@Te_Remark";
        private const string DP_NAME="@Dp_name";


        #endregion

        #region 验证登陆
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="te_Id">教师ID</param>
        /// <param name="te_Pwd">密码</param>
        /// <returns>是否成功</returns>
        public bool ValidLogin(string te_Id,string te_Pwd)
        {
            SqlParameter[] parms={
                MakeInParm(TE_ID,SqlDbType.VarChar,10,te_Id),
                MakeInParm(TE_PWD,SqlDbType.VarChar,20,te_Pwd)
            };
            try
            {
                return ExecProc("Valid_Te_Login",parms)>0?true:false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region  修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="te_Id">ID</param>
        /// <param name="te_OldPwd">原密码</param>
        /// <param name="te_NewPwd">新密码</param>
        /// <param name="te_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        public int ChangePwd(string te_Id, string te_OldPwd, string te_NewPwd, string te_ReNewPwd)
        {
            SqlParameter[] parms ={
                MakeInParm(TE_ID,SqlDbType.VarChar,20,te_Id),
                MakeInParm(TE_OLDPWD,SqlDbType.VarChar,20,te_OldPwd),
                MakeInParm(TE_NEWPWD,SqlDbType.VarChar,20,te_NewPwd),
                MakeInParm(TE_RENEWPWD,SqlDbType.VarChar,20,te_ReNewPwd)
            };
            try
            {
                return ExecProc("Te_ChangePwd", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 添加老师
        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="teacherInf">老师实体</param>
        /// <returns></returns>
        public int AddTeacher(TeacherInf teacherInf)
        {
            SqlParameter[] parms ={
                MakeInParm(TE_ID,SqlDbType.VarChar,20,teacherInf.Te_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,teacherInf.Dp_Id),
                MakeInParm(LG_NAME,SqlDbType.VarChar,10,teacherInf.Te_Learngrade),
                MakeInParm(ZC_NAME,SqlDbType.VarChar,10,teacherInf.Te_ZhiCheng),
                MakeInParm(TE_NAME,SqlDbType.VarChar,10,teacherInf.Te_Name),
                MakeInParm(TE_SEX,SqlDbType.Char,2,teacherInf.Te_Sex),
                MakeInParm(TE_IDENTITY,SqlDbType.Char,18,teacherInf.Te_Identity),
                MakeInParm(TE_SPECIALITY,SqlDbType.VarChar,20,teacherInf.Te_Speciality),
                MakeInParm(TE_ADDRESS,SqlDbType.VarChar,50,teacherInf.Te_Address),
                MakeInParm(TE_ZZFACE,SqlDbType.Char,20,teacherInf.Te_ZZFace),
                MakeInParm(TE_MINZU,SqlDbType.Char,16,teacherInf.Te_MinZu),
                MakeInParm(TE_TEL,SqlDbType.Char,11,teacherInf.Te_Tel),
                MakeInParm(TE_BIRTIDAY,SqlDbType.DateTime,0,teacherInf.Te_Birthday),
                MakeInParm(TE_TEACHERTIME,SqlDbType.DateTime,0,teacherInf.Te_Teachtime),
                MakeInParm(TE_PROVINCE,SqlDbType.VarChar,16,teacherInf.Te_Province),
                MakeInParm(TE_REMARK,SqlDbType.VarChar,600,teacherInf.Te_Remark)
            };
            try
            {
                return ExecProc("AddTeacer", parms);
            }
            catch
            {
                return 0;
            }

        }
        #endregion

        #region 获取教师列表
        public DataTable GetTeachers(string dp_name)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_NAME,SqlDbType.VarChar,20,dp_name)
            };
            try
            {
                return ExecProcDs("GetTeachers", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取教师详细信息
        public DataTable DisplayTeacherDetailsInf(string te_id)
        {
            SqlParameter[] parms ={
                MakeInParm(TE_ID,SqlDbType.VarChar,10,te_id)
            };
            try
            {
                return ExecProcDs("DisplayTeacherDetailsInf", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

    }
}
