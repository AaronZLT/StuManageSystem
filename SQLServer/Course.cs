using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;
using StudentManager.DBUtility;
using StudentManager.IDAL;
using System.Data.SqlClient;

namespace StudentManager.SQLServer
{
    //课程数据访问层
    public class Course:SqlServerBaseDb,ICourse
    {
        #region 存储过程参数
        private const string CB_ID = "@Cb_id";
        private const string DP_ID = "@Dp_id";
        private const string CB_NAME = "@Cb_name";
        private const string CB_CREDITHOUR = "@Cb_credithour";
        private const string CT_TYPE = "@Ct_type";
        private const string CB_TIME = "@Cb_time";
        private const string CB_ISPUBLIC = "@Cb_ispublic";
        private const string CB_REMARK = "@Cb_remark";
        private const string SP_ID = "@Sp_id";
        private const string TE_ID = "@Te_id";
        private const string CR_ID = "@Cr_id";
        private const string PC_YEAR = "@Pc_year";
        private const string PC_TERM = "@Pc_term";
        private const string PC_WEEKS = "@Pc_weeks";
        private const string PC_PERSONCOUNT = "@Pc_personcount";
        private const string PC_CLASSTIME = "@Pc_classtime";
        private const string PC_REMARK = "@Pc_remark";
        private const string STUDENT_ID = "@St_id";
        private const string PC_ID = "@Pc_id";
        private const string SC_YEAR = "@Sc_year";
        private const string SC_TERM = "@Sc_term";
        private const string ST_ID = "@St_id";
        private const string SCORE = "@Scocre ";

        #endregion

        #region 添加开课课程
        public int AddCourse(CourseInf courseInf)
        {
            SqlParameter[] parms ={
                MakeInParm(CB_ID,SqlDbType.VarChar,10,courseInf.Cb_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,courseInf.Dp_Id),
                MakeInParm(CB_NAME,SqlDbType.VarChar,40,courseInf.Cb_Name),
                MakeInParm(CB_CREDITHOUR,SqlDbType.Real,0,courseInf.Cb_Credithour),
                MakeInParm(CT_TYPE,SqlDbType.VarChar,12,courseInf.Ct_Type),
                MakeInParm(CB_TIME,SqlDbType.Int,4,courseInf.Cb_Time),
                MakeInParm(CB_ISPUBLIC,SqlDbType.Char,2,courseInf.Cb_Ispublic),
                MakeInParm(CB_REMARK,SqlDbType.VarChar,600,courseInf.Cb_Remark)
            };
            try
            {
                return ExecProc("AddCourse", parms);
            }
            catch
            {
                return 0;
            }
                
                
        }
        #endregion 

        #region 获取课程类型列表
        public DataTable GetCourseTypeList()
        {
            try
            {
                return ExecProcDs("GetCourseType", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取学院开课信息
        public DataTable GetCourses(string dp_id)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_id)
            };
            try
            {
                return ExecProcDs("GetCourses", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取课程下拉列表
        public DataTable GetCourseList()
        {
            try
            {
                return ExecProcDs("GetCourseList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取上课教室下拉列表
        public DataTable GetCRList()
        {
            try
            {
                return ExecProcDs("GetCRList", null).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取上课教师下拉列表
        public DataTable GetTeacherList(string dp_id)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_id)
            };
            try
            {
                return ExecProcDs("GetTeacherList",parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 添加选课课程
        public int AddChooseCourse(CourseInf courseInf)
        {
            SqlParameter[] parms ={
                MakeInParm(CB_ID,SqlDbType.VarChar,10,courseInf.Cb_Id),
                MakeInParm(SP_ID,SqlDbType.Char,20,courseInf.Sp_Id),
                MakeInParm(TE_ID,SqlDbType.VarChar,10,courseInf.Te_Id),
                MakeInParm(CR_ID,SqlDbType.Char,10,courseInf.Cr_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,courseInf.Pc_Year),
                MakeInParm(PC_TERM,SqlDbType.Char,10,courseInf.Pc_Term),
                MakeInParm(PC_WEEKS,SqlDbType.Char,10,courseInf.Pc_Weeks),
                MakeInParm(PC_PERSONCOUNT,SqlDbType.Int,4,courseInf.Pc_PersonCount),
                MakeInParm(PC_CLASSTIME,SqlDbType.Char,50,courseInf.Pc_ClassTime),
                MakeInParm(PC_REMARK,SqlDbType.NVarChar,400,courseInf.PC_Remark)
            };
            try
            {
                return ExecProc("AddChooseCourse", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region 获取学生个人信息
        public string GetStudentInf(string st_Id,ref string dp_id,ref string sp_id)
        { 
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id)
            };
            try
            {
                DataTable sdt= ExecProcDs("GetStudentInf", parms).Tables[0];
                if (sdt.Rows.Count > 0)
                {

                    string st_Inf = sdt.Rows[0].ItemArray[0].ToString() + " " + sdt.Rows[0].ItemArray[14].ToString() + " " + sdt.Rows[0].ItemArray[13].ToString() + " " + sdt.Rows[0].ItemArray[10].ToString();
                    dp_id=sdt.Rows[0].ItemArray[12].ToString();
                    sp_id = sdt.Rows[0].ItemArray[11].ToString();
                    return st_Inf;
                }
                else
                {
                    return " ";
                }
            }
            catch
            {
               return " ";
            }
        }
        #endregion

        #region 获取学生选课课表
        public DataTable GetChooseClassTb(string dp_Id, string sp_Id,string pc_Year,int pc_Term)
        {
            SqlParameter[] parms={
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id),
                MakeInParm(SP_ID,SqlDbType.Char,20,sp_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,pc_Year),
                MakeInParm(PC_TERM,SqlDbType.Int,4,pc_Term)
            };
            try
            {
                return ExecProcDs("GetChooseTable",parms).Tables[0];
            }
            catch
            {
                return null;
            }

        }
        #endregion

        #region 选课
        public int ChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm,string te_id)
        {
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id),
                MakeInParm(PC_ID,SqlDbType.BigInt,8,pc_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,LearnYear),
                MakeInParm(PC_TERM,SqlDbType.Int,4,LearnTerm),
                //MakeInParm(TE_ID,SqlDbType.VarChar,10,te_id)
            };
            try
            {
                return ExecProc("ChooseCourse", parms);
            }
            catch
            {
                return 0;
            }

        }
        #endregion

        #region 退选课
        public int NotChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm)
        {
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id),
                MakeInParm(PC_ID,SqlDbType.BigInt,8,pc_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,LearnYear),
                MakeInParm(PC_TERM,SqlDbType.Int,4,LearnTerm)
            };
            try
            {
                return ExecProc("NoChooseCourse", parms);
            }
            catch
            {
                return 0;
            }

        }
        #endregion 

        #region 获取选课结果表
        public DataTable GetChooseCourseTable(string st_Id, string pc_Year, int pc_Term)
        {
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,pc_Year),
                MakeInParm(PC_TERM,SqlDbType.Int,4,pc_Term)
            };
            try
            {
                return ExecProcDs("ChooseCourseTable", parms).Tables[0];
            }
            catch
            {
                return null;
            }

        }
        #endregion

        #region 获取培养计划表
        public DataTable GetPlanCourseTable(string st_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id)
            };
            try
            {
                return ExecProcDs("PlanCourseTable", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 查询成绩表
        public DataTable QueryScore(string st_Id, string pc_Year, int pc_Term)
        {
            SqlParameter[] parms ={
                MakeInParm(STUDENT_ID,SqlDbType.VarChar,20,st_Id),
                MakeInParm(PC_YEAR,SqlDbType.Char,10,pc_Year),
                MakeInParm(PC_TERM,SqlDbType.Int,4,pc_Term)
            };
            try
            {
                return ExecProcDs("QueryScore", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 查询教师授课表
        public DataTable TecherTeachCourses(string te_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(TE_ID,SqlDbType.VarChar,10,te_Id)
            };
            try
            {
                return ExecProcDs("ViewTeachCourses", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取选课学生列表
        public DataTable ChooseStudentTb(string pc_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(PC_ID,SqlDbType.BigInt,8,Convert.ToInt32(pc_Id))
            };
            try
            {
                return ExecProcDs("ViewChooseStudents", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取对应课程选课学生列表
        public DataTable GetStForUpdateScore(string cb_Id,string learn_Year,int learn_Term)
        {
            SqlParameter[] parms ={
                MakeInParm(CB_ID,SqlDbType.VarChar,10,cb_Id),
                MakeInParm(SC_YEAR,SqlDbType.Char,10,learn_Year),
                MakeInParm(SC_TERM,SqlDbType.Int,4,learn_Term)
            };
            try
            {
                return ExecProcDs("GetStForUpdateScoreBat", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 获取教师上课列表
        public DataTable GetCourseList(string te_ID)
        {
            SqlParameter[] parms ={
                MakeInParm(TE_ID,SqlDbType.VarChar,10,te_ID)
            };
            
            try
            {
                return ExecProcDs("ViewTeachCourses", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        
           // return ExecProcDs("GetTeacherList", parms).Tables[0];
        }
            #endregion

            #region 更新成绩
            public int UpdateScore(string cb_id, string st_id, float score,string te_id)
        {
            SqlParameter[] parms ={
                MakeInParm(CB_ID,SqlDbType.VarChar,10,cb_id),
                MakeInParm(ST_ID,SqlDbType.VarChar,20,st_id),
                MakeInParm(SCORE,SqlDbType.Real,0,score),
                MakeInParm(TE_ID,SqlDbType.VarChar,10,te_id)
            };
            try
            {
                return ExecProc("UpdateScoreBat", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

    }

}
