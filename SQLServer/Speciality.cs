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
    /// ���ݷ��ʲ�רҵʵ����
    /// </summary>
    public class Speciality:SqlServerBaseDb,ISpeciality
    {
        #region ���ݷ��ʲ�洢���̲�������
        private const string SP_ID = "@Sp_id";  //רҵ���
        private const string DP_ID = "@Dp_id";  //ѧԺ���
        private const string SP_GRADE = "@Sp_grade"; // רҵ�꼶
        #endregion

        #region ��ȡרҵ�б���Ϣ
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
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

        #region ��ȡרҵ�б���Ϣ
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
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

        #region ɾ��רҵ
        /// <summary>
        /// ɾ��רҵ
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
