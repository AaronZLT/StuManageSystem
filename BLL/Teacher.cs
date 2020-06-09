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
    /// ��ʦҵ���߼���
    /// </summary>
    public class Teacher
    {
        #region ʹ�ù�������,��̬��ʵ������ʦ
        //ʹ�ù�������,��̬ʵ������ʦ
        private ITeacher teacher = DataAccess.CreateTeacher();
        #endregion

        #region  ��֤��ʦ��½
        /// <summary>
        /// ��֤��ʦ��½
        /// </summary>
        /// <param name="te_Id">��ʦID</param>
        /// <param name="te_Pwd">����</param>
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
                JScript.Alert("�û���Ϣ����!����������!");
                JScript.GoHistory(-1);
            }
        }
        #endregion

        #region ��ʦ�޸�����
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="te_Id">ID</param>
        /// <param name="te_OldPwd">ԭ����</param>
        /// <param name="te_NewPwd">������</param>
        /// <param name="te_ReNewPwd">�ظ�����</param>
        /// <param name="lblMessage">������Ϣ</param>
        public void  ChangePwd(string te_Id, string te_OldPwd, string te_NewPwd, string te_ReNewPwd, Label lblMessage)
        {
            int returnMessge = teacher.ChangePwd(te_Id, te_OldPwd, te_NewPwd, te_ReNewPwd);
            switch (returnMessge)
            {
                case -1: lblMessage.Text = "������������벻һ��!";
                    break;
                case -2: lblMessage.Text = "�������!";
                    break;
                case 1: lblMessage.Text = "�����޸ĳɹ�!";
                    break;
                case 0: lblMessage.Text = "�����޸�ʧ��,������!";
                    break;
            }
        }
        #endregion

        #region ��ӽ�ʦ
        public void AddTeacher(TeacherInf teacherInf)
        {
            int result = teacher.AddTeacher(teacherInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("��ӳɹ�!", "AddTeacher.aspx");
                    break;
                case 0:JScript.Alert("���ʧ��!������!");
                       JScript.GoHistory(-1); 
                    break;
                case -2: JScript.Alert("��ʦ����Ѵ���,�뻻�������");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region �󶨽�ʦ��Ϣ
        public void BindeTeachers(string dp_name,GridView gvTeachers)
        {
            gvTeachers.DataSource = teacher.GetTeachers(dp_name);
            gvTeachers.DataBind();
        }
        #endregion

        #region ��ʾ��ʦ��ϸ��Ϣ
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

