using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManager.DBUtility
{
    /// <summary>
    /// SQL SERVER ���ݿ���ʻ���
    /// ������:���
    /// ʱ��:2008-3-25
    /// 2008-08-06 �׷���51aspx.com��ת����ע��
    /// </summary>
    public class SqlServerBaseDb
    {

        #region ��ʼ�����ñ���
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        private  readonly string constr=ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

        private SqlConnection con;     //����SQL����
        private SqlCommand cmd;        //����SQL�������
        private SqlDataAdapter sda;    //����SQL����������
        private SqlDataReader sdr;     //����SQL�����Ķ���
        private SqlParameter param;   //����SQL����
        private DataSet ds;            //�������ݼ�
        private DataTable dt;          //�������ݱ�
        #endregion

        #region �����������ݿ�����
        /// <summary>
        /// �����������ݿ�����
        /// </summary>
        private void OpenCon()
        {
            con = new SqlConnection(constr);
            con.Open();
        }
        #endregion

        #region �ر��Ѵ򿪵�����
        /// <summary>
        /// �ر��Ѵ򿪵�����
        /// </summary>
        private void CloseCon()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
        #endregion

        #region �������ݼ�
        /// <summary>
        /// �������ݼ�
        /// </summary>
        /// <param name="sqlstring">SQL���</param>
        /// <returns>���ݼ�</returns>
        public DataSet GetDs(string sqlString)
        {
            OpenCon();
            sda = new SqlDataAdapter(sqlString, con);
            ds = new DataSet();
            sda.Fill(ds);
            CloseCon();
            return ds;
        }
        #endregion

        #region ��ȡ������ͼ
        /// <summary>
        /// ��ȡ������ͼ
        /// </summary>
        /// <param name="sqlstring">SQL���</param>
        /// <returns>������ͼ</returns>
        public  DataView GetDv(string sqlString)
        {
            return GetDs(sqlString).Tables[0].DefaultView;
        }
        #endregion

        #region ��ȡ�Ķ���
        /// <summary>
        /// ��ȡ�Ķ���
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        /// <returns>�Ķ���</returns>
        public SqlDataReader GetDataReader(string sqlString)
        {
            OpenCon();
            cmd = new SqlCommand(sqlString, con);
            sdr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        #endregion

        #region ��ȡ���ݱ�
        /// <summary>
        /// ��ȡ���ݱ�
        /// </summary>
        /// <param name="sqlstring">SQL���</param>
        /// <returns>���ݱ�</returns>
        public DataTable GetDt(string sqlString)
        {
            dt=GetDs(sqlString).Tables[0];
            return dt;
        }
        #endregion

        #region ִ��SQL���
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="sqlString">SQL���</param>
        public void ExecSql(string sqlString)
        {
            OpenCon();
            cmd = new SqlCommand(sqlString, con);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
        #endregion

        #region ִ�д���SQL���
        /// <summary>
        /// ִ�д���SQL���
        /// </summary>
        /// <param name="sqlString">SQL�������</param>
        /// <returns>ִ��SQL��䷵��ֵ</returns>
        public int ExecParmSql(string sqlString,SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion

        #region ִ�д���SQL���,���������Ķ�����
        /// <summary>
        /// ִ�д���SQL���,���������Ķ�����
        /// </summary>
        /// <param name="sqlString">����SQL���</param>
        /// <param name="parms">SQL������</param>
        /// <returns>�����Ķ���</returns>
        public SqlDataReader ExecParmSqlReader(string sqlString, SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        #endregion

        #region ִ�д���SQL���
        /// <summary>
        /// ִ�д���SQL���
        /// </summary>
        /// <param name="sqlString">SQL�������</param>
        /// <param name="parms">����</param>
        /// <returns>���ݼ�</returns>
        public DataSet ExecParmSqlDs(string sqlString, SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        #endregion

        #region ִ�д洢����
        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="procName">�洢������</param>
        /// <returns>����ֵ</returns>
        public int ExecProc(string procName)
        {
            cmd =BulidProcCommand(procName, null);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion 

        #region ִ�д������Ĵ洢����
        /// <summary>
        /// ִ�д������Ĵ洢����
        /// </summary>
        /// <param name="procName">�洢������</param>
        /// <param name="parms">�洢���̲���</param>
        /// <returns>�洢���̷���ֵ</returns>
        public int ExecProc(string procName, SqlParameter[] parms)
        {
            cmd = BulidProcCommand(procName, parms);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion 

        #region ִ�д洢����
        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="procName">�洢������</param>
        /// <param name="dataReader">�����Ķ���</param>
        public void ExecProc(string procName, SqlDataReader dataReader)
        {
            cmd =BulidProcCommand(procName, null);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion 

        #region ִ�д洢����
        /// <summary>
        ///ִ�д洢����
        /// </summary>
        /// <param name="procName">������</param>
        /// <param name="parms">���̲���</param>
        /// <param name="dataReader">�Ķ���</param>
        public void ExecProc(string procName, SqlParameter[] parms, SqlDataReader dataReader)
        {
            cmd =BulidProcCommand(procName, parms);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion

        #region ִ�д洢����
        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="procName">������</param>
        /// <param name="parms">���̲���</param>
        /// <returns>�������ݼ�</returns>
        public DataSet ExecProcDs(string procName, SqlParameter[] parms)
        {
            cmd =BulidProcCommand(procName, parms);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            CloseCon();
            return ds;
        }
        #endregion 

        #region ���ɴ洢�����������
        /// <summary>
        /// ���ɴ洢�����������
        /// </summary>
        /// <param name="procName">�洢������</param>
        /// <param name="parms">�洢���̲���</param>
        /// <returns>�������</returns>
        public SqlCommand BulidProcCommand(string procName, SqlParameter[] parms)
        {
            OpenCon();
            cmd = new SqlCommand(procName, con);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parms != null)
            {
                foreach (SqlParameter parameter in parms)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            cmd.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return cmd;
        }
        #endregion 

        #region ����SQL�������
        /// <summary>
        /// ����SQL�������
        /// </summary>
        /// <param name="sqlstr">SQL�������</param>
        /// <param name="parms">SQL������</param>
        /// <returns>SQL�������</returns>
        public SqlCommand BuildSqlCommand(string sqlstr, SqlParameter[] parms)
        {
            OpenCon();
            cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = CommandType.Text;
            if (parms != null)
            {
                foreach (SqlParameter parameter in parms)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            cmd.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return cmd;
        }
        #endregion

        #region ���ɹ��̲���
        /// <summary>
        /// ���ɹ��̲���
        /// </summary>
        /// <param name="proName">������</param>
        /// <param name="dbTpye">��������</param>
        /// <param name="size">���ݴ�С</param>
        /// <param name="direction">��������</param>
        /// <param name="value">����ֵ</param>
        /// <returns>���̲���</returns>
        private  SqlParameter MakeParm(string parmName, SqlDbType dbTpye, Int32 size, ParameterDirection direction, object value)
        {
            if (size > 0)
            {
                param = new SqlParameter(parmName, dbTpye, size);
            }
            else
            {
                param = new SqlParameter(parmName, dbTpye);
            }
            param.Direction = direction;
            if (!(direction == ParameterDirection.Output && value == null))
            {
                param.Value = value;
            }
            return param;
        }
        #endregion

        #region ���ɴ洢�����������
        /// <summary>
        /// ���ɴ洢�����������
        /// </summary>
        /// <param name="procName">������</param>
        /// <param name="dbType">��������</param>
        /// <param name="size">������С</param>
        /// <param name="value">����ֵ</param>
        /// <returns>���̲���</returns>
        public SqlParameter MakeInParm(string parmName, SqlDbType dbType, Int32 size, object value)
        {
            return MakeParm(parmName, dbType, size, ParameterDirection.Input, value);
        }
        #endregion

        #region ���ɴ洢�����������
        /// <summary>
        /// ���ɴ洢�����������
        /// </summary>
        /// <param name="procName">������</param>
        /// <param name="dbType">��������</param>
        /// <param name="size">������С</param>
        /// <param name="value">����ֵ</param>
        /// <returns>���̲���</returns>
        public SqlParameter MakOutParm(string parmName, SqlDbType dbType, Int32 size)
        {
            return MakeParm(parmName, dbType, size, ParameterDirection.Output, null);
        }
        #endregion
    }
}
//5_1_a_s_p_x.c_o_m
