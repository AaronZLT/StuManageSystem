using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManager.DBUtility
{
    /// <summary>
    /// SQL SERVER 数据库访问基类
    /// 创建者:余洪
    /// 时间:2008-3-25
    /// 2008-08-06 首发于51aspx.com，转载请注明
    /// </summary>
    public class SqlServerBaseDb
    {

        #region 初始化常用变量
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        private  readonly string constr=ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString;

        private SqlConnection con;     //创建SQL连接
        private SqlCommand cmd;        //创建SQL命令对象
        private SqlDataAdapter sda;    //创建SQL数据适配器
        private SqlDataReader sdr;     //创建SQL数据阅读器
        private SqlParameter param;   //创建SQL参数
        private DataSet ds;            //创建数据集
        private DataTable dt;          //创建数据表
        #endregion

        #region 创建并打开数据库连接
        /// <summary>
        /// 创建并打开数据库连接
        /// </summary>
        private void OpenCon()
        {
            con = new SqlConnection(constr);
            con.Open();
        }
        #endregion

        #region 关闭已打开的连接
        /// <summary>
        /// 关闭已打开的连接
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

        #region 返回数据集
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sqlstring">SQL语句</param>
        /// <returns>数据集</returns>
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

        #region 获取数据视图
        /// <summary>
        /// 获取数据视图
        /// </summary>
        /// <param name="sqlstring">SQL语句</param>
        /// <returns>数据视图</returns>
        public  DataView GetDv(string sqlString)
        {
            return GetDs(sqlString).Tables[0].DefaultView;
        }
        #endregion

        #region 获取阅读器
        /// <summary>
        /// 获取阅读器
        /// </summary>
        /// <param name="sqlString">SQL语句</param>
        /// <returns>阅读器</returns>
        public SqlDataReader GetDataReader(string sqlString)
        {
            OpenCon();
            cmd = new SqlCommand(sqlString, con);
            sdr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        #endregion

        #region 获取数据表
        /// <summary>
        /// 获取数据表
        /// </summary>
        /// <param name="sqlstring">SQL语句</param>
        /// <returns>数据表</returns>
        public DataTable GetDt(string sqlString)
        {
            dt=GetDs(sqlString).Tables[0];
            return dt;
        }
        #endregion

        #region 执行SQL语句
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sqlString">SQL语句</param>
        public void ExecSql(string sqlString)
        {
            OpenCon();
            cmd = new SqlCommand(sqlString, con);
            cmd.ExecuteNonQuery();
            CloseCon();
        }
        #endregion

        #region 执行带参SQL语句
        /// <summary>
        /// 执行带参SQL语句
        /// </summary>
        /// <param name="sqlString">SQL带参语句</param>
        /// <returns>执行SQL语句返回值</returns>
        public int ExecParmSql(string sqlString,SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion

        #region 执行带参SQL语句,返回数据阅读对象
        /// <summary>
        /// 执行带参SQL语句,返回数据阅读对象
        /// </summary>
        /// <param name="sqlString">带参SQL语句</param>
        /// <param name="parms">SQL语句参数</param>
        /// <returns>数据阅读器</returns>
        public SqlDataReader ExecParmSqlReader(string sqlString, SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr;
        }
        #endregion

        #region 执行带参SQL语句
        /// <summary>
        /// 执行带参SQL语句
        /// </summary>
        /// <param name="sqlString">SQL带参语句</param>
        /// <param name="parms">参数</param>
        /// <returns>数据集</returns>
        public DataSet ExecParmSqlDs(string sqlString, SqlParameter[] parms)
        {
            cmd = BuildSqlCommand(sqlString, parms);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        #endregion

        #region 执行存储过程
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <returns>返回值</returns>
        public int ExecProc(string procName)
        {
            cmd =BulidProcCommand(procName, null);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion 

        #region 执行带参数的存储过程
        /// <summary>
        /// 执行带参数的存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="parms">存储过程参数</param>
        /// <returns>存储过程返回值</returns>
        public int ExecProc(string procName, SqlParameter[] parms)
        {
            cmd = BulidProcCommand(procName, parms);
            cmd.ExecuteNonQuery();
            CloseCon();
            return (int)cmd.Parameters["ReturnValue"].Value;
        }
        #endregion 

        #region 执行存储过程
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="dataReader">数据阅读器</param>
        public void ExecProc(string procName, SqlDataReader dataReader)
        {
            cmd =BulidProcCommand(procName, null);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion 

        #region 执行存储过程
        /// <summary>
        ///执行存储过程
        /// </summary>
        /// <param name="procName">过程名</param>
        /// <param name="parms">过程参数</param>
        /// <param name="dataReader">阅读器</param>
        public void ExecProc(string procName, SqlParameter[] parms, SqlDataReader dataReader)
        {
            cmd =BulidProcCommand(procName, parms);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion

        #region 执行存储过程
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">过程名</param>
        /// <param name="parms">过程参数</param>
        /// <returns>返回数据集</returns>
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

        #region 生成存储过程命令对象
        /// <summary>
        /// 生成存储过程命令对象
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="parms">存储过程参数</param>
        /// <returns>命令对象</returns>
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

        #region 生成SQL命令对象
        /// <summary>
        /// 生成SQL命令对象
        /// </summary>
        /// <param name="sqlstr">SQL带参语句</param>
        /// <param name="parms">SQL语句参数</param>
        /// <returns>SQL命令对象</returns>
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

        #region 生成过程参数
        /// <summary>
        /// 生成过程参数
        /// </summary>
        /// <param name="proName">过程名</param>
        /// <param name="dbTpye">数据类型</param>
        /// <param name="size">数据大小</param>
        /// <param name="direction">参数方向</param>
        /// <param name="value">参数值</param>
        /// <returns>过程参数</returns>
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

        #region 生成存储过程输入参数
        /// <summary>
        /// 生成存储过程输入参数
        /// </summary>
        /// <param name="procName">过程名</param>
        /// <param name="dbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>过程参数</returns>
        public SqlParameter MakeInParm(string parmName, SqlDbType dbType, Int32 size, object value)
        {
            return MakeParm(parmName, dbType, size, ParameterDirection.Input, value);
        }
        #endregion

        #region 生成存储过程输出参数
        /// <summary>
        /// 生成存储过程输出参数
        /// </summary>
        /// <param name="procName">过程名</param>
        /// <param name="dbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>过程参数</returns>
        public SqlParameter MakOutParm(string parmName, SqlDbType dbType, Int32 size)
        {
            return MakeParm(parmName, dbType, size, ParameterDirection.Output, null);
        }
        #endregion
    }
}
//5_1_a_s_p_x.c_o_m
