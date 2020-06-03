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
    /// ѧ��ҵ���
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public class Student
    {
        #region  ʹ�ù���������̬��ʵ����ѧ��ʵ��
        /// <summary>
        /// ʹ�ù���������̬��ʵ����ѧ��ʵ��
        /// </summary>
        private IStudent student = DataAccess.CreateStudent();
        #endregion

        #region ��֤ѧ����½
        /// <summary>
        /// ��֤ѧ����½
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_Pwd">����</param>
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
                JScript.Alert("�û���Ϣ����!����������!");
                JScript.GoHistory(-1); 
            }

        }
        #endregion

        #region ѧ���޸�����
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_OldPwd">ԭ����</param>
        /// <param name="st_NewPwd">������</param>
        /// <param name="st_ReNewPwd">�ظ�����</param>
        /// <param name="lblMessage">������Ϣ</param>
        public void  ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd,Label lblMessage)
        {
            int returnMessage = student.ChangePwd(st_Id, st_OldPwd, st_NewPwd, st_ReNewPwd);
            switch (returnMessage)
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

        #region ���ѧ����Ϣ
        public void AddStudent(StudentInf studentInf)
        {
            int result = student.AddStudent(studentInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("���ѧ���ɹ�!","AddStudent.aspx");                        
                    break;
                case -2: JScript.Alert("���ʧ��,��ѧ���Ѿ�����,�뻻����ѧ��");
                         JScript.GoHistory(-1);
                    break;
                case 0: JScript.Alert("���ʧ��,����ϸ�������!");
                         JScript.GoHistory(-1);
                    break;
            }

        }
        #endregion

        #region ��ѧ���б���Ϣ
        public void BindStudent(string dp_name, string sp_name, string cl_name, GridView gdStudent)
        {
            gdStudent.DataSource = student.GetStudentList(dp_name, sp_name, cl_name);
            gdStudent.DataBind();
        }
        #endregion

        #region ��ʾ��ȡѧ����ϸ
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
