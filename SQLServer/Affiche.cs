using System;
using System.Data;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.DBUtility;
using StudentManager.Model;

namespace StudentManager.SQLServer
{
    /// <summary>
    /// ������Ϣ���ʲ�
    /// </summary>
    public class Affiche:SqlServerBaseDb,IAffiche
    {
        #region �洢���̲�������
        private const string AF_ID = "@Af_id";
        private const string DP_ID="@Dp_id";
        private const string AF_TITLE="@Af_title";
        private const string AF_CONTENT="@Af_content ";
        private const string AF_ENABLETIME="@Af_enabletime";
        private const string AF_FILEPATH="@Af_filepath";
        #endregion

        #region ��ȡ������Ϣ
        /// <summary>
        /// ��ȡ������Ϣ
        /// </summary>
        /// <returns>������Ϣ</returns>
        public DataSet GetAffiches()
        {
            try
            {
                return ExecProcDs("GetAffiches", null);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region  ��ȡҪ�鿴�Ĺ�����Ϣ
        /// <summary>
        /// ��ȡҪ�鿴�Ĺ�����Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <returns></returns>
        public DataSet GetAffiche(int af_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(AF_ID,SqlDbType.Int,4,af_Id)
            };
            try
            {
                return ExecProcDs("GetAffiche", parms);
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region ������
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="afficheInf">������Ϣʵ��</param>
        /// <returns></returns>
        public bool AddAffiche(AfficheInf afficheInf)
        {
            SqlParameter[] parms ={
                MakeInParm(DP_ID,SqlDbType.Char,2,afficheInf.Dp_Id),
                MakeInParm(AF_TITLE,SqlDbType.NVarChar,100,afficheInf.Af_Title),
                MakeInParm(AF_CONTENT,SqlDbType.Text,3000,afficheInf.Af_Content),
                MakeInParm(AF_ENABLETIME,SqlDbType.DateTime,0,afficheInf.Af_EnableTime),
                MakeInParm(AF_FILEPATH,SqlDbType.NVarChar,150,afficheInf.Af_FilePath)
            };
            try
            {
                if (ExecProc("Add_Affiche", parms) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region ɾ��������Ϣ
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">����ID</param>
        /// <returns></returns>
        public int DelAffiche( int af_Id,string dp_Id)
        {
            SqlParameter[] parms ={
                MakeInParm(AF_ID,SqlDbType.Int,4,af_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id)
            };
            try
            {
                return ExecProc("DeleteAffiche", parms);
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region  ��ȡҪ���µ�
        /// <summary>
        /// ��ȡҪ���µ�
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">����ID</param>
        /// <returns></returns>
        public AfficheInf GetAfficheForUpdate(int af_Id, string dp_Id)
        {
            AfficheInf afficheInf = null;
            SqlParameter[] parms ={
                MakeInParm(AF_ID,SqlDbType.Int,4,af_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,dp_Id),
                MakOutParm(AF_TITLE,SqlDbType.NVarChar,100),
                MakOutParm(AF_CONTENT,SqlDbType.NVarChar,3000),
                MakOutParm(AF_ENABLETIME,SqlDbType.DateTime,0),
                MakOutParm(AF_FILEPATH,SqlDbType.NVarChar,150)
            };
            try
            {
                ExecProc("GetAfficheForUpdate",parms);
                afficheInf= new AfficheInf(parms[2].Value.ToString(), parms[3].Value.ToString(), Convert.ToDateTime(parms[4].Value), parms[5].Value.ToString());
                return afficheInf;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region �޸Ĺ�����Ϣ
        /// <summary>
        /// �޸Ĺ�����Ϣ
        /// </summary>
        /// <param name="afficheInf">����ʵ��</param>
        /// <returns></returns>
        public bool UpdateAffiche(AfficheInf afficheInf)
        {
            SqlParameter[] parms ={
                MakeInParm(AF_ID,SqlDbType.Int,4,afficheInf.Af_Id),
                MakeInParm(DP_ID,SqlDbType.Char,2,afficheInf.Dp_Id),
                MakeInParm(AF_TITLE,SqlDbType.NVarChar,100,afficheInf.Af_Title),
                MakeInParm(AF_CONTENT,SqlDbType.Text,3000,afficheInf.Af_Content),
                MakeInParm(AF_ENABLETIME,SqlDbType.DateTime,0,afficheInf.Af_EnableTime),
                MakeInParm(AF_FILEPATH,SqlDbType.NVarChar,150,afficheInf.Af_FilePath)
            };
            try
            {
                if (ExecProc("UpdateAffiche", parms) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
