using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using StudentManager.IDAL;
using StudentManager.SQLServer;
using StudentManager.DALFactory;
using StudentManager.Common;
using StudentManager.Model;


namespace StudentManager.BLL
{
    /// <summary>
    /// 部门业务逻辑层务层
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public class Department
    {
        #region 使用反射工厂多态实例化部门接口
        /// <summary>
        /// 使用反射工厂多态实例化部门接口
        /// </summary>
        private IDepartment department = DataAccess.CreateDepartment();
        #endregion

        #region 验证登陆
        /// <summary>
        /// 验证登陆
        /// </summary>
        /// <param name="dp_Id">部门ID</param>
        /// <param name="dp_Pwd">密码</param>
        public void ValidDepartMentLogin(string dp_Id, string dp_Pwd)
        {
            if (department.ValidLogin(dp_Id, dp_Pwd))
            {
                FormsAuthentication.SetAuthCookie(dp_Id, false);
                if (!Roles.IsUserInRole(dp_Id, "Department"))
                {
                    Roles.AddUserToRole(dp_Id, "Department");
                }
                HttpContext.Current.Session["role"] = "department";
                JScript.RedirectUrl(@"~/Department/Default.aspx");
            }
            else
            {
                JScript.Alert("用户信息错误!请重新输入!");
                JScript.GoHistory(-1);
            }
        }
        #endregion

        #region  部门(学院)修改密码
        /// <summary>
        /// 部门修改密码
        /// </summary>
        /// <param name="dp_Id">ID</param>
        /// <param name="dp_OldPwd">原密码</param>
        /// <param name="dp_NewPwd">新密码</param>
        /// <param name="dp_ReNewPwd">重复密码</param>
        /// <param name="lblMessage">返回信息</param>
        public void ChangePwd(string dp_Id, string dp_OldPwd, string dp_NewPwd, string dp_ReNewPwd, Label lblMessage)
        {
            int returnMessage = department.ChangePwd(dp_Id, dp_OldPwd, dp_NewPwd, dp_ReNewPwd);
            switch (returnMessage)
            {
                case -1: lblMessage.Text = "两次输入的密码不一致!";
                    break;
                case -2: lblMessage.Text = "密码错误!";
                    break;
                case 1: lblMessage.Text = "密码修改成功!";
                    break;
                case 0: lblMessage.Text = "密码修改失败,请重试!";
                    break;
            }

        }
        #endregion

        #region 添加部门信息(包括学生信息)
        /// <summary>
        /// 添加部门信息(包括学生信息)
        /// </summary>
        /// <param name="dept">部门信息</param>
        /// <returns></returns>
        public void AddDept(DepartmentInf dept)
        {
            int returnMessage = department.AddDept(dept);
            switch (returnMessage)
            {
                case -1: JScript.Alert("该学院编号存在");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("添加成功!", "Default.aspx");
                    break;
                case 0: JScript.Alert("添加失败,请重试!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region  添加专业信息
        /// <summary>
        /// 添加专业信息
        /// </summary>
        /// <param name="sp_Id">专业编号</param>
        /// <param name="dp_Id">所属学院</param>
        /// <param name="sp_Name">专业名字</param>
        /// <param name="sp_Remark">专业备注</param>
        /// <param name="sp_Grade">专业所属年级</param>
        /// <returns></returns>
        public void AddSpeciality(string sp_Id, string dp_Id, string sp_Name, string sp_Remark, string sp_Grade)
        {
            int returnMessage = department.AddSpeciality(sp_Id, dp_Id, sp_Name, sp_Remark, sp_Grade);
            switch (returnMessage)
            {
                case -1: JScript.Alert("学院不存在");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("添加成功!", "AddSpeciality.aspx");
                    break;
                case 0: JScript.Alert("添加失败,请重试!");
                    JScript.GoHistory(-1);
                    break;
                case -2: JScript.Alert("专业编号已存在,请换其他编号!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 绑定学院信息到下拉列表框
        /// <summary>
        /// 绑定学院信息到下拉列表框
        /// </summary>
        /// <param name="ddlCollege"></param>
        public void BindCollegeForDll(DropDownList ddlCollege)
        {
            ddlCollege.DataSource = department.GetCollege();
            ddlCollege.DataTextField = "dp_name";
            ddlCollege.DataValueField = "dp_id";
            ddlCollege.DataBind();
        }
        #endregion

        #region 绑定所有学院信息到GridView
        /// <summary>
        /// 绑定所有学院信息到GridView
        /// </summary>
        /// <param name="gvColleges"></param>
        public void BindColleges(GridView gvColleges)
        {
            gvColleges.DataSource = department.GetCollegeList();
            gvColleges.DataBind();
        }
        #endregion

        #region 重置密码
        public void ReSetPwd(string objectstr, string number, string newpwd, Label lblMessage)
        {
            int result=department.ResetPwd(objectstr, number, newpwd);
            switch (result)
            {
                case -1: lblMessage.Text = "重置密码失败!";
                    break;
                case -2: lblMessage.Text = "学生或教师不存在!";
                    break;
                case 1: lblMessage.Text = "密码重置成功!";
                    break;
            }
        }
        #endregion

        #region 删除学院部门
        /// <summary>
        /// 删除学院信息列表
        /// </summary>
        /// <returns></returns>
        public void  DeleteDept(string CurDp_ID, string dp_ID)
        {
            int returnMessage = department.DeleteDept(CurDp_ID, dp_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("你没有权限删除学院或部门");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("删除成功!", "Colleges.aspx");
                    break;
                case 0:JScript.Alert("还有其它信息与学院关联，请删除与该学院相关联的其它信息后再删除该学院");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 删除专业
        /// <summary>
        /// 删除专业
        /// </summary>
        /// <returns></returns>
        public void DeleteSP(string CurDp_ID, string sp_ID)
        {
            int returnMessage = department.DeleteSP(CurDp_ID, sp_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("你没有权限删除该专业");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("删除成功!", "Specialities.aspx");
                    break;
                case 0: JScript.Alert("还有其它信息与该专业关联，请删除与该专业相关联的其它信息后在删除该学院");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 删除班级
        /// <summary>
        /// 删除班级
        /// </summary>
        /// <returns></returns>
        public void  DeleteCL(string CurDp_ID, string cl_ID)
        {
            int returnMessage = department.DeleteCL(CurDp_ID, cl_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("你没有权限删除该班级");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("删除成功!", "Classes.aspx");
                    break;
                case 0: JScript.Alert("还有其它信息与该班级关联，请删除该与该班级关联的其它信息后再删除该班级");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 删除课程库课程
        /// <summary>
        /// 删除课程库课程
        /// </summary>
        /// <returns></returns>
        public void  DeleteCourseLib(string CurDp_ID, string cb_ID)
        {
            int returnMessage = department.DeleteCourseLib(CurDp_ID, cb_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("你没有权限删除该课程");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("删除成功!", "Courses.aspx");
                    break;
                case 0: JScript.Alert("还有其它信息与该课程关联，请删除与该课程关联的其它信息后再删除该课程");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 显示学院详细信息
        /// <summary>
        /// 显示学院详细信息
        /// </summary>
        /// <returns></returns>
        public void  DisplayDeptDetailsInf(string CurDp_ID,Label lblDeptID,Label lblDeptName,Label lblAddress,Label lblDeptTel,TextBox txtDeptRemark)
        {
            DataSet ds = department.DisplayDeptDetailsInf(CurDp_ID);
            if (ds != null)
            {
                lblDeptID.Text = ds.Tables[0].Rows[0]["dp_id"].ToString();
                lblDeptName.Text = ds.Tables[0].Rows[0]["dp_name"].ToString();
                lblAddress.Text = ds.Tables[0].Rows[0]["dp_address"].ToString();
                lblDeptTel.Text = ds.Tables[0].Rows[0]["dp_tel"].ToString();
                txtDeptRemark.Text = ds.Tables[0].Rows[0]["dp_remark"].ToString();
            }
        }
        #endregion

    }
}
