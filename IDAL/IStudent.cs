using System;
using System.Collections.Generic;
using System.Text;
using StudentManager.Model;
using System.Data;

namespace StudentManager.IDAL
{
    /// <summary>
    /// 学生接口
    /// </summary>
   public interface IStudent
   {

       #region   验证登陆
       /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="st_ID">学生ID</param>
        /// <param name="st_Pwd">密码</param>
        /// <returns>是否修改成功</returns>
        bool ValidLogin(string st_Id,string st_Pwd);
       #endregion

       #region  修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_OldPwd">原密码</param>
        /// <param name="st_NewPwd">新密码</param>
        /// <param name="st_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        int ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd);
        #endregion

       #region 添加学生信息
       int AddStudent(StudentInf studentInf);
       #endregion

       #region 获取学生列表信息
       DataTable GetStudentList(string dp_Name, string sp_Name, string cl_Name);
       #endregion

       #region 获取学生详细
       DataTable DisplayStudentDetialsInf(string st_Id);
       #endregion
    }
}
