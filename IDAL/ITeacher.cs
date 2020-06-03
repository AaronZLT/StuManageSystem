using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    public interface ITeacher
    {
        #region 验证登陆
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="te_Id">教师ID</param>
        /// <param name="te_Pwd">密码</param>
        /// <returns>是否成功</returns>
        bool ValidLogin(string te_Id,string te_Pwd);
        #endregion

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="st_Id">教师ID</param>
        /// <param name="st_OldPwd">原密码</param>
        /// <param name="st_NewPwd">新密码</param>
        /// <param name="st_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        int ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd);
        #endregion

        #region 添加老师
        /// <summary>
        /// 添加老师
        /// </summary>
        /// <param name="teacherInf">老师实体</param>
        /// <returns></returns>
        int AddTeacher(TeacherInf teacherInf);
        #endregion

        #region 获取教师列表
        DataTable GetTeachers(string dp_name);
        #endregion

        #region 获取教师详细信息
        DataTable DisplayTeacherDetailsInf(string te_id);
        #endregion
    }
}
