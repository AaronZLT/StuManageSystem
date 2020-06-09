using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using StudentManager.IDAL;
using StudentManager.DALFactory;
using StudentManager.SQLServer;
using StudentManager.Common;
using StudentManager.Model;

namespace StudentManager.BLL
{

    /// <summary>
    /// 教师业务逻辑层
    /// </summary>
    public class Teacher
    {
        #region 使用工厂方法,多态是实例化教师
        //使用工厂方法,多态实例化教师
        private ITeacher teacher = DataAccess.CreateTeacher();
        #endregion

        #region  验证教师登陆
        /// <summary>
        /// 验证教师登陆
        /// </summary>
        /// <param name="te_Id">教师ID</param>
        /// <param name="te_Pwd">密码</param>
        public void ValidTeacherLogin(string te_Id,string te_Pwd)
        {
            if (teacher.ValidLogin(te_Id, te_Pwd))
            {
                FormsAuthentication.SetAuthCookie(te_Id, false);
                if (!Roles.IsUserInRole(te_Id, "Teacher"))
                {
                    Roles.AddUserToRole(te_Id, "Teacher");
                }
                HttpContext.Current.Session["role"] = "teacher";
                JScript.RedirectUrl(@"~/Teacher/Default.aspx");
            }
            else
            {
                JScript.Alert("用户信息错误!请重新输入!");
                JScript.GoHistory(-1);
            }
        }
        #endregion

        #region 教师修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="te_Id">ID</param>
        /// <param name="te_OldPwd">原密码</param>
        /// <param name="te_NewPwd">新密码</param>
        /// <param name="te_ReNewPwd">重复密码</param>
        /// <param name="lblMessage">返回消息</param>
        public void  ChangePwd(string te_Id, string te_OldPwd, string te_NewPwd, string te_ReNewPwd, Label lblMessage)
        {
            int returnMessge = teacher.ChangePwd(te_Id, te_OldPwd, te_NewPwd, te_ReNewPwd);
            switch (returnMessge)
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

        #region 添加教师
        public void AddTeacher(TeacherInf teacherInf)
        {
            int result = teacher.AddTeacher(teacherInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("添加成功!", "AddTeacher.aspx");
                    break;
                case 0:JScript.Alert("添加失败!请重试!");
                       JScript.GoHistory(-1); 
                    break;
                case -2: JScript.Alert("教师编号已存在,请换其他编号");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 绑定教师信息
        public void BindeTeachers(string dp_name,GridView gvTeachers)
        {
            gvTeachers.DataSource = teacher.GetTeachers(dp_name);
            gvTeachers.DataBind();
        }
        #endregion

        #region 显示教师详细信息
        public void  DisplayTeacherDetailsInf(string te_id,Label lblTeID, Label lblTeName,Label lblTeDpName,Label lblTeLgName,Label lblTeZcName,Label lblTeSex,Label lblTeIdentity,Label lblTeSp,Label lblTeAddress,Label lblTeZzFace, Label lblTeMinZu,Label lblTeTel, Label lblTeBirthday, Label lblTeTeachTime,Label lblTePro, TextBox txtRemark)
        {
            DataRow dr=teacher.DisplayTeacherDetailsInf(te_id).Rows[0];
            lblTeID.Text = dr["te_id"].ToString();
            lblTeName.Text = dr["te_name"].ToString();
            lblTeDpName.Text = dr["dp_name"].ToString();
            lblTeLgName.Text = dr["lg_name"].ToString();
            lblTeZcName.Text = dr["zc_name"].ToString();
            lblTeSex.Text = dr["te_sex"].ToString();
            lblTeIdentity.Text = dr["te_identity"].ToString();
            lblTeSp.Text = dr["te_speciality"].ToString();
            lblTeAddress.Text = dr["te_address"].ToString();
            lblTeZzFace.Text = dr["te_zzface"].ToString();
            lblTeMinZu.Text = dr["te_minzu"].ToString();
            lblTeTel.Text = dr["te_tel"].ToString();
            lblTeBirthday.Text = dr["te_birthday"].ToString().Substring(0,8);
            lblTeTeachTime.Text = dr["te_teachtime"].ToString().Substring(0,8);
            lblTePro.Text = dr["tb_Province"].ToString();
            txtRemark.Text = dr["te_remark"].ToString();
        }
        #endregion
    }
}

