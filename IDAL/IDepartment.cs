using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

#region ���ݷ��ʲ�ӿ�
namespace StudentManager.IDAL
{
    #region ����(ѧԺ)���ݷ��ʲ�ӿ�
    public interface IDepartment
    {
        #region  ��½��֤
        /// <summary>
        /// ��֤��½
        /// </summary>
        /// <param name="dp_Id">����ID</param>
        /// <param name="dp_Pwd">����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool ValidLogin(string dp_Id,string dp_Pwd);
        #endregion

        #region �޸�����
        /// <summary>
        /// �����޸�����
        /// </summary>
        /// <param name="dp_Id">��ʦID</param>
        /// <param name="dp_OldPwd">ԭ����</param>
        /// <param name="dp_NewPwd">������</param>
        /// <param name="dp_ReNewPwd">�ظ�����</param>
        /// <returns>����ֵ</returns>
        int ChangePwd(string dp_Id, string dp_OldPwd, string dp_NewPwd, string dp_ReNewPwd);
        #endregion

        #region ��Ӳ�����Ϣ
        /// <summary>
        /// ��Ӳ�����Ϣ(����ѧ����Ϣ)
        /// </summary>
        /// <param name="dept">������Ϣ</param>
        /// <returns></returns>
        int AddDept(DepartmentInf dept);
        #endregion

        #region ���רҵ��Ϣ
        /// <summary>
        /// ���רҵ��Ϣ
        /// </summary>
        /// <param name="sp_Id">רҵ���</param>
        /// <param name="dp_Id">����ѧԺ</param>
        /// <param name="sp_Name">רҵ����</param>
        /// <param name="sp_Remark">רҵ��ע</param>
        /// <param name="sp_Grade">רҵ�����꼶</param>
        /// <returns></returns>
        int AddSpeciality(string sp_Id, string dp_Id, string sp_Name, string sp_Remark, string sp_Grade);
        #endregion

        #region ��ѧԺ�������б��
        /// <summary>
        /// ��ѧԺ
        /// </summary>
        /// <returns></returns>
        DataSet GetCollege();
        #endregion

        #region ��ȡѧԺ��Ϣ�б�
        /// <summary>
        /// ��ȡѧԺ��Ϣ�б�
        /// </summary>
        /// <returns>ѧԺ��Ϣ�б�</returns>
        DataTable GetCollegeList();
        #endregion

        #region ��������
        int ResetPwd(string objectStr, string number, string pwd);
        #endregion

         #region ɾ��ѧԺ����
        /// <summary>
        /// ɾ��ѧԺ��Ϣ
        /// </summary>
        /// <returns></returns>
        int  DeleteDept(string CurDp_ID,string dp_ID);
        #endregion

        #region ɾ��רҵ
        /// <summary>
        /// ɾ��ѧרҵ
        /// </summary>
        /// <returns></returns>
        int DeleteSP(string CurDp_ID, string sp_ID);
        #endregion


        #region ɾ���༶
        /// <summary>
        /// ɾ���༶
        /// </summary>
        /// <returns></returns>
        int DeleteCL(string CurDp_ID, string cl_ID);
        #endregion

        #region ɾ���γ̿�γ�
        /// <summary>
        /// ɾ���γ̿�γ�
        /// </summary>
        /// <returns></returns>
        int DeleteCourseLib(string CurDp_ID, string cb_ID);
        #endregion

        #region ��ʾѧԺ��ϸ��Ϣ
        /// <summary>
        /// ��ʾѧԺ��ϸ��Ϣ
        /// </summary>
        /// <returns></returns>
        DataSet DisplayDeptDetailsInf(string CurDp_ID);
        #endregion
    }
    #endregion
}
#endregion
