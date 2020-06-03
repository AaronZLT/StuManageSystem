using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.DBUtility;


namespace StudentManager.SQLServer
{
    /// <summary>
    /// �������ݷ���
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public class Common:SqlServerBaseDb,ICommon
    {
        #region �洢���̲�������
        private const string UID="@Uid";
        private const string UTABLE="@Utable";
        private const string USERNAME = "@Username";
        private const string PROVINCE="@Province";
        #endregion

        #region  ��ȡ�û�������ӭ��Ϣ
        /// <summary>
        /// ��ȡ�û�������ӭ��Ϣ
        /// </summary>
        /// <param name="u_Id">�û�ID</param>
        /// <param name="U_Table">�û���</param>
        /// <returns>�û���</returns>
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

        #region ��ȡѧ���б�
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

        #region ��ȡ��ʦְ���б�
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

        #region ��ȡ������ò�б�
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

        #region ��ȡ�����б�
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

        #region ��ȡʡ�б�
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

        #region ��ȡ���б�
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

        #region ��רҵ��Ϣ�������б��
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
