using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

#region 数据访问层接口
namespace StudentManager.IDAL
{
    #region 部门(学院)数据访问层接口
    public interface IDepartment
    {
        #region  登陆验证
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="dp_Id">部门ID</param>
        /// <param name="dp_Pwd">密码</param>
        /// <returns>是否成功</returns>
        bool ValidLogin(string dp_Id,string dp_Pwd);
        #endregion

        #region 修改密码
        /// <summary>
        /// 部门修改密码
        /// </summary>
        /// <param name="dp_Id">教师ID</param>
        /// <param name="dp_OldPwd">原密码</param>
        /// <param name="dp_NewPwd">新密码</param>
        /// <param name="dp_ReNewPwd">重复密码</param>
        /// <returns>返回值</returns>
        int ChangePwd(string dp_Id, string dp_OldPwd, string dp_NewPwd, string dp_ReNewPwd);
        #endregion

        #region 添加部门信息
        /// <summary>
        /// 添加部门信息(包括学生信息)
        /// </summary>
        /// <param name="dept">部门信息</param>
        /// <returns></returns>
        int AddDept(DepartmentInf dept);
        #endregion

        #region 添加专业信息
        /// <summary>
        /// 添加专业信息
        /// </summary>
        /// <param name="sp_Id">专业编号</param>
        /// <param name="dp_Id">所属学院</param>
        /// <param name="sp_Name">专业名字</param>
        /// <param name="sp_Remark">专业备注</param>
        /// <param name="sp_Grade">专业所属年级</param>
        /// <returns></returns>
        int AddSpeciality(string sp_Id, string dp_Id, string sp_Name, string sp_Remark, string sp_Grade);
        #endregion

        #region 绑定学院到下拉列表框
        /// <summary>
        /// 绑定学院
        /// </summary>
        /// <returns></returns>
        DataSet GetCollege();
        #endregion

        #region 获取学院信息列表
        /// <summary>
        /// 获取学院信息列表
        /// </summary>
        /// <returns>学院信息列表</returns>
        DataTable GetCollegeList();
        #endregion

        #region 重置密码
        int ResetPwd(string objectStr, string number, string pwd);
        #endregion

         #region 删除学院部门
        /// <summary>
        /// 删除学院信息
        /// </summary>
        /// <returns></returns>
        int  DeleteDept(string CurDp_ID,string dp_ID);
        #endregion

        #region 删除专业
        /// <summary>
        /// 删除学专业
        /// </summary>
        /// <returns></returns>
        int DeleteSP(string CurDp_ID, string sp_ID);
        #endregion


        #region 删除班级
        /// <summary>
        /// 删除班级
        /// </summary>
        /// <returns></returns>
        int DeleteCL(string CurDp_ID, string cl_ID);
        #endregion

        #region 删除课程库课程
        /// <summary>
        /// 删除课程库课程
        /// </summary>
        /// <returns></returns>
        int DeleteCourseLib(string CurDp_ID, string cb_ID);
        #endregion

        #region 显示学院详细信息
        /// <summary>
        /// 显示学院详细信息
        /// </summary>
        /// <returns></returns>
        DataSet DisplayDeptDetailsInf(string CurDp_ID);
        #endregion
    }
    #endregion
}
#endregion
