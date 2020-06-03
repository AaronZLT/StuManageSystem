using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.Model;
using StudentManager.DBUtility;
using StudentManager.IDAL;

namespace StudentManager.SQLServer
{
    /// <summary>
    /// �༶���ݷ��ʲ�
    /// </summary>
    public class StuClass:SqlServerBaseDb,IClass
    {
        #region ���ݷ��ʲ���̲���
        private const string CL_ID = "@Cl_id";
        private const string SP_ID = "@Sp_id";
        private const string CL_NAME = "@Cl_name";
        private const string CL_REMARK = "@Cl_remark";
        private const string DP_NAME = "@Dp_name";
        private const string SP_NAME = "@Sp_name";
        #endregion

        #region ��Ӱ༶
        public int AddClass(ClassInf clsssInf)
        {
            SqlParameter[] parms ={
                MakeInParm(CL_ID,SqlDbType.Char,30,clsssInf.Cl_Id),
                MakeInParm(SP_ID,SqlDbType.Char,20,clsssInf.Sp_Id),
                MakeInParm(CL_NAME,SqlDbType.VarChar,40,clsssInf.Cl_Name),
                MakeInParm(CL_REMARK,SqlDbType.VarChar,600,clsssInf.Cl_Remark)
            };
            try
            {
                return ExecProc("AddClass", parms);
            }
            catch
            {
                return 0;
            }
                
        }
        #endregion

        #region ��ȡ�༶�б���Ϣ
        public DataTable GetClassList(string sp_id)
        {
            SqlParameter[] parms ={
                MakeInParm(SP_ID,SqlDbType.Char,20,sp_id)
            };
            try
            {
                return ExecProcDs("GetClassList", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region ��ȡ�༶��Ϣ
        public DataTable GetClasses(string dp_name, string sp_name)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_NAME,SqlDbType.VarChar,20,dp_name),
                MakeInParm(SP_NAME,SqlDbType.VarChar,40,sp_name)
            };
            try
            {
                return ExecProcDs("GetClassesList", parms).Tables[0];
            }
            catch
            {
                return null;
            }
        }
        #endregion

    }
}
