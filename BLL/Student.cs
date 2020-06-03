using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using StudentManager.DALFactory;
using StudentManager.SQLServer;
using StudentManager.IDAL;
using StudentManager.Model;
using StudentManager.Common;


namespace StudentManager.BLL
{
    /// <summary>
    /// 学生业务层
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public class Student
    {
        #region  使用工厂方法多态是实例化学生实体
        /// <summary>
        /// 使用工厂方法多态是实例化学生实体
        /// </summary>
        private IStudent student = DataAccess.CreateStudent();
        #endregion

        #region 验证学生登陆
        /// <summary>
        /// 验证学生登陆
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_Pwd">密码</param>
        public void ValidStudentLogin(string st_Id, string st_Pwd)
        {
            if (student.ValidLogin(st_Id, st_Pwd))
            {
                FormsAuthentication.SetAuthCookie(st_Id, false);
                if (!Roles.IsUserInRole(st_Id, "Student"))
                {
                    Roles.AddUserToRole(st_Id, "Student");
                }
                HttpContext.Current.Session["role"] = "student";
                JScript.RedirectUrl(@"~/Student/Default.aspx");
            }
            else
            {
                JScript.Alert("用户信息错误!请重新输入!");
                JScript.GoHistory(-1); 
            }

        }
        #endregion

        #region 学生修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_OldPwd">原密码</param>
        /// <param name="st_NewPwd">新密码</param>
        /// <param name="st_ReNewPwd">重复密码</param>
        /// <param name="lblMessage">返回信息</param>
        public void  ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd,Label lblMessage)
        {
            int returnMessage = student.ChangePwd(st_Id, st_OldPwd, st_NewPwd, st_ReNewPwd);
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

        #region 添加学生信息
        public void AddStudent(StudentInf studentInf)
        {
            int result = student.AddStudent(studentInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("添加学生成功!","AddStudent.aspx");                        
                    break;
                case -2: JScript.Alert("添加失败,该学号已经存在,请换其他学号");
                         JScript.GoHistory(-1);
                    break;
                case 0: JScript.Alert("添加失败,请仔细检查输入!");
                         JScript.GoHistory(-1);
                    break;
            }

        }
        #endregion

        #region 绑定学生列表信息
        public void BindStudent(string dp_name, string sp_name, string cl_name, GridView gdStudent)
        {
            gdStudent.DataSource = student.GetStudentList(dp_name, sp_name, cl_name);
            gdStudent.DataBind();
        }
        #endregion

        #region 显示获取学生详细
        public void DisplayStudentDetialsInf(string st_Id,Label lblID,Label lblName,Label lblSex,Label lblBirthday,Label lblMinZu,Label lblIdentity,Label lblTel,Label lblPro,Label lblFace,Label  lblAddress,Label lblClassName,Label  lblSpName,Label lblGrade,Label  lblDpName,TextBox txtRemark)
        {
            DataRow dr = student.DisplayStudentDetialsInf(st_Id).Rows[0];
            lblID.Text = dr["st_id"].ToString();
            lblName.Text = dr["st_name"].ToString();
            lblSex.Text = dr["st_sex"].ToString();
            lblBirthday.Text = dr["st_birthday"].ToString().Substring(0, 8);
            lblMinZu.Text = dr["mz_name"].ToString();
            lblIdentity.Text = dr["st_identity"].ToString();
            lblTel.Text = dr["st_tel"].ToString();
            lblPro.Text = dr["st_province"].ToString();
            lblFace.Text = dr["st_face"].ToString();
            lblAddress.Text = dr["st_address"].ToString();
            txtRemark.Text = dr["st_remark"].ToString();
            lblClassName.Text = dr["cl_name"].ToString();
            lblSpName.Text = dr["sp_name"].ToString();
            lblGrade.Text = dr["sp_grade"].ToString();
            lblDpName.Text = dr["dp_name"].ToString();
        }
        #endregion
    }
}
