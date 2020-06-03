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
    /// ����ҵ���߼������
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public class Department
    {
        #region ʹ�÷��乤����̬ʵ�������Žӿ�
        /// <summary>
        /// ʹ�÷��乤����̬ʵ�������Žӿ�
        /// </summary>
        private IDepartment department = DataAccess.CreateDepartment();
        #endregion

        #region ��֤��½
        /// <summary>
        /// ��֤��½
        /// </summary>
        /// <param name="dp_Id">����ID</param>
        /// <param name="dp_Pwd">����</param>
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
                JScript.Alert("�û���Ϣ����!����������!");
                JScript.GoHistory(-1);
            }
        }
        #endregion

        #region  ����(ѧԺ)�޸�����
        /// <summary>
        /// �����޸�����
        /// </summary>
        /// <param name="dp_Id">ID</param>
        /// <param name="dp_OldPwd">ԭ����</param>
        /// <param name="dp_NewPwd">������</param>
        /// <param name="dp_ReNewPwd">�ظ�����</param>
        /// <param name="lblMessage">������Ϣ</param>
        public void ChangePwd(string dp_Id, string dp_OldPwd, string dp_NewPwd, string dp_ReNewPwd, Label lblMessage)
        {
            int returnMessage = department.ChangePwd(dp_Id, dp_OldPwd, dp_NewPwd, dp_ReNewPwd);
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

        #region ��Ӳ�����Ϣ(����ѧ����Ϣ)
        /// <summary>
        /// ��Ӳ�����Ϣ(����ѧ����Ϣ)
        /// </summary>
        /// <param name="dept">������Ϣ</param>
        /// <returns></returns>
        public void AddDept(DepartmentInf dept)
        {
            int returnMessage = department.AddDept(dept);
            switch (returnMessage)
            {
                case -1: JScript.Alert("��ѧԺ��Ŵ���");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("��ӳɹ�!", "Default.aspx");
                    break;
                case 0: JScript.Alert("���ʧ��,������!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region  ���רҵ��Ϣ
        /// <summary>
        /// ���רҵ��Ϣ
        /// </summary>
        /// <param name="sp_Id">רҵ���</param>
        /// <param name="dp_Id">����ѧԺ</param>
        /// <param name="sp_Name">רҵ����</param>
        /// <param name="sp_Remark">רҵ��ע</param>
        /// <param name="sp_Grade">רҵ�����꼶</param>
        /// <returns></returns>
        public void AddSpeciality(string sp_Id, string dp_Id, string sp_Name, string sp_Remark, string sp_Grade)
        {
            int returnMessage = department.AddSpeciality(sp_Id, dp_Id, sp_Name, sp_Remark, sp_Grade);
            switch (returnMessage)
            {
                case -1: JScript.Alert("ѧԺ������");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("��ӳɹ�!", "AddSpeciality.aspx");
                    break;
                case 0: JScript.Alert("���ʧ��,������!");
                    JScript.GoHistory(-1);
                    break;
                case -2: JScript.Alert("רҵ����Ѵ���,�뻻�������!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ��ѧԺ��Ϣ�������б��
        /// <summary>
        /// ��ѧԺ��Ϣ�������б��
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

        #region ������ѧԺ��Ϣ��GridView
        /// <summary>
        /// ������ѧԺ��Ϣ��GridView
        /// </summary>
        /// <param name="gvColleges"></param>
        public void BindColleges(GridView gvColleges)
        {
            gvColleges.DataSource = department.GetCollegeList();
            gvColleges.DataBind();
        }
        #endregion

        #region ��������
        public void ReSetPwd(string objectstr, string number, string newpwd, Label lblMessage)
        {
            int result=department.ResetPwd(objectstr, number, newpwd);
            switch (result)
            {
                case -1: lblMessage.Text = "��������ʧ��!";
                    break;
                case -2: lblMessage.Text = "ѧ�����ʦ������!";
                    break;
                case 1: lblMessage.Text = "�������óɹ�!";
                    break;
            }
        }
        #endregion

        #region ɾ��ѧԺ����
        /// <summary>
        /// ɾ��ѧԺ��Ϣ�б�
        /// </summary>
        /// <returns></returns>
        public void  DeleteDept(string CurDp_ID, string dp_ID)
        {
            int returnMessage = department.DeleteDept(CurDp_ID, dp_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("��û��Ȩ��ɾ��ѧԺ����");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("ɾ���ɹ�!", "Colleges.aspx");
                    break;
                case 0:JScript.Alert("����������Ϣ��ѧԺ��������ɾ�����ѧԺ�������������Ϣ����ɾ����ѧԺ");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ɾ��רҵ
        /// <summary>
        /// ɾ��רҵ
        /// </summary>
        /// <returns></returns>
        public void DeleteSP(string CurDp_ID, string sp_ID)
        {
            int returnMessage = department.DeleteSP(CurDp_ID, sp_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("��û��Ȩ��ɾ����רҵ");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("ɾ���ɹ�!", "Specialities.aspx");
                    break;
                case 0: JScript.Alert("����������Ϣ���רҵ��������ɾ�����רҵ�������������Ϣ����ɾ����ѧԺ");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ɾ���༶
        /// <summary>
        /// ɾ���༶
        /// </summary>
        /// <returns></returns>
        public void  DeleteCL(string CurDp_ID, string cl_ID)
        {
            int returnMessage = department.DeleteCL(CurDp_ID, cl_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("��û��Ȩ��ɾ���ð༶");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("ɾ���ɹ�!", "Classes.aspx");
                    break;
                case 0: JScript.Alert("����������Ϣ��ð༶��������ɾ������ð༶������������Ϣ����ɾ���ð༶");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ɾ���γ̿�γ�
        /// <summary>
        /// ɾ���γ̿�γ�
        /// </summary>
        /// <returns></returns>
        public void  DeleteCourseLib(string CurDp_ID, string cb_ID)
        {
            int returnMessage = department.DeleteCourseLib(CurDp_ID, cb_ID);
            switch (returnMessage)
            {
                case -1: JScript.Alert("��û��Ȩ��ɾ���ÿγ�");
                    JScript.GoHistory(-1);
                    break;
                case 1: JScript.AlertAndRedirect("ɾ���ɹ�!", "Courses.aspx");
                    break;
                case 0: JScript.Alert("����������Ϣ��ÿγ̹�������ɾ����ÿγ̹�����������Ϣ����ɾ���ÿγ�");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ��ʾѧԺ��ϸ��Ϣ
        /// <summary>
        /// ��ʾѧԺ��ϸ��Ϣ
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
