using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.DBUtility;
using StudentManager.IDAL;
using StudentManager.Model;

#region 数据访问层
namespace StudentManager.SQLServer
{

    #region 部门(学院,其他部门数据访问层类体)
    /// <summary>
    /// 数据访问层
    /// </summary>
    public class Department:SqlServerBaseDb,IDepartment
    {
        #region 存储过程参数常量
        private const string DP_ID = "@Dp_id";
        private const string DP_PWD="@Dp_pwd";
        private const string DP_OLDPWD="@Dp_oldpwd";
        private const string DP_NEWPWD="@Dp_newpwd";
        private const string DP_RENEWPWD = "@Dp_renewpwd";
        private const string DP_NAME="@Dp_name";
        private const string DP_ADDRESS="@Dp_address";
        private const string DP_TEL= "@Dp_tel";
        private const string DP_REMARK= "@Dp_remark";
        private const string CUR_DP_ID = "@CurDp_id";

        private const string SP_ID="@Sp_id";
        private const string SP_NAME="@Sp_name";
        private const string SP_RENARK="@Sp_remark";
        private const string SP_GRADE="@Sp_grade";

        private const string OBJECT = "@Object";
        private const string NUMBER = "@Number";
        private const string NEWPWD = "@Newpwd";
        private const string CL_ID = "@Cl_id";
        private const string CB_ID = "@Cb_id";
        #endregion

        #region 验证登陆
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="dp_Id">部门ID</param>
        /// <param name="dp_Pwd">密码</param>
        /// <returns>是否成功</returns>
        public bool ValidLogin(string dp_Id, string dp_Pwd)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id),
                MakeInParm(DP_PWD,SqlDbType.VarChar,20,dp_Pwd)
            };
            try
            {
                return ExecProc("Valid_Dp_Login", parms) > 0 ? true : false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 部门修改密码
        /// <summary>
        /// 部门修改密码
        /// </summary>
        /// <param name="dp_Id">ID</param>
        /// <param name="dp_OldPwd">原密码</param>
        /// <param name="dp_NewPwd">新密码</param>
        /// <param name="dp_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        public int ChangePwd(string dp_Id, string dp_OldPwd, string dp_NewPwd, string dp_ReNewPwd)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.VarChar,20,dp_Id),
                MakeInParm(DP_OLDPWD,SqlDbType.VarChar,20,dp_OldPwd),
                MakeInParm(DP_NEWPWD,SqlDbType.VarChar,20,dp_NewPwd),
                MakeInParm(DP_RENEWPWD,SqlDbType.VarChar,20,dp_ReNewPwd)
            };
            try
            {
                return ExecProc("Dp_ChangePwd", parms);
            }
            catch
            {
                return 0;
            }

        }
        #endregion

        #region 添加部门信息(包括学生信息)
        /// <summary>
        /// 添加部门信息(包括学生信息)
        /// </summary>
        /// <param name="dept">部门信息</param>
        /// <returns></returns>
        public int AddDept(DepartmentInf dept)
        {
            SqlParameter[] parms={
                MakeInParm(DP_ID,SqlDbType.Char,2,dept.Dp_Id),
                MakeInParm(DP_NAME,SqlDbType.VarChar,20,dept.Dp_Name),
                MakeInParm(DP_PWD,SqlDbType.VarChar,20,dept.Dp_Pwd),
                MakeInParm(DP_ADDRESS,SqlDbType.VarChar,30,dept.Dp_Address),
                MakeInParm(DP_TEL,SqlDbType.Char,11,dept.Dp_Tel),
                MakeInParm(DP_REMARK,SqlDbType.VarChar,600,dept.Dp_Remark)
            };
            try
            {
                return ExecProc("Add_Dept", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region  添加专业信息
        /// <summary>
        /// 添加专业信息
        /// </summary>
        /// <param name="sp_Id">专业编号</param>
        /// <param name="dp_Id">所属学院</param>
        /// <param name="sp_Name">专业名字</param>
        /// <param name="sp_Remark">专业备注</param>
        /// <param name="sp_Grade">专业所属年级</param>
        /// <returns></returns>
        public int AddSpeciality(string sp_Id, string dp_Id, string sp_Name, string sp_Remark, string sp_Grade)
        {
            SqlParameter[] parms ={
                MakeInParm(SP_ID,SqlDbType.Char,20,sp_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id),
                MakeInParm(SP_NAME,SqlDbType.VarChar,40,sp_Name),
                MakeInParm(SP_RENARK,SqlDbType.VarChar,600,sp_Remark),
                MakeInParm(SP_GRADE,SqlDbType.Char,4,sp_Grade)
            };
            try
            {
                return ExecProc("Add_Speciality", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 绑定学院
        /// <summary>
        /// 绑定学院
        /// </summary>
        /// <returns></returns>
        public DataSet GetCollege()
        {
            try
            {
                return ExecProcDs("GetCollegeForBind", null);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 绑定所有学院信息
        /// <summary>
        /// 绑定所有学院信息
        /// </summary>
        /// <returns>学院信息列表</returns>
        public DataTable GetCollegeList()
        {
            DataTable dtCollegeList = new DataTable();
            try
            {
                dtCollegeList = ExecProcDs("GetCollegeList", null).Tables[0];
            }
            catch
            {
                return null;
            }
            return dtCollegeList;
        }
        #endregion  
        
        #region 重置密码
        public int ResetPwd(string objectStr, string number, string pwd)
        {
            SqlParameter[] parms ={
                MakeInParm(OBJECT,SqlDbType.VarChar,20,objectStr),
                MakeInParm(NUMBER,SqlDbType.VarChar,20,number),
                MakeInParm(NEWPWD,SqlDbType.VarChar,20,pwd)
            };
            try
            {
                return ExecProc("ReSetPwd", parms);
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        #region 删除学院部门
        /// <summary>
        /// 删除学院部门
        /// </summary>
        /// <returns></returns>
        public int DeleteDept(string CurDp_ID,string dp_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(CUR_DP_ID,SqlDbType.Char,2,CurDp_ID),
                MakeInParm(DP_ID,SqlDbType.VarChar,2,dp_ID),
            };
            try
            {
                return ExecProc("Delete_College", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 删除专业
        /// <summary>
        /// 删除专业
        /// </summary>
        /// <returns></returns>
        public int DeleteSP(string CurDp_ID, string sp_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(CUR_DP_ID,SqlDbType.Char,2,CurDp_ID),
                MakeInParm(SP_ID,SqlDbType.VarChar,20,sp_ID),
            };
            try
            {
                return ExecProc("Delete_Speciality", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion


        #region 删除班级
        /// <summary>
        /// 删除班级
        /// </summary>
        /// <returns></returns>
        public int DeleteCL(string CurDp_ID, string cl_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(CUR_DP_ID,SqlDbType.Char,2,CurDp_ID),
                MakeInParm(CL_ID,SqlDbType.VarChar,20,cl_ID),
            };
            try
            {
                return ExecProc("Delete_Class", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 删除课程库课程
        /// <summary>
        /// 删除课程库课程
        /// </summary>
        /// <returns></returns>
        public int DeleteCourseLib(string CurDp_ID, string cb_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(CUR_DP_ID,SqlDbType.Char,2,CurDp_ID),
                MakeInParm(CB_ID,SqlDbType.VarChar,10,cb_ID),
            };
            try
            {
                return ExecProc("Delete_CourseLib", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 显示学院详细信息
        /// <summary>
        /// 显示学院详细信息
        /// </summary>
        /// <returns></returns>
        public DataSet DisplayDeptDetailsInf(string CurDp_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,CurDp_ID)
            };
            try
            {
                return ExecProcDs("DisplayDeptDetailsInf", parms);
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
    #endregion
}
#endregion