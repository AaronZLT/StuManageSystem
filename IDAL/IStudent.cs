using System;
using System.Collections.Generic;
using System.Text;
using StudentManager.Model;
using System.Data;

namespace StudentManager.IDAL
{
    /// <summary>
    /// ѧ���ӿ�
    /// </summary>
   public interface IStudent
   {

       #region   ��֤��½
       /// <summary>
        /// ��֤��½
        /// </summary>
        /// <param name="st_ID">ѧ��ID</param>
        /// <param name="st_Pwd">����</param>
        /// <returns>�Ƿ��޸ĳɹ�</returns>
        bool ValidLogin(string st_Id,string st_Pwd);
       #endregion

       #region  �޸�����
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="st_Id">ID</param>
        /// <param name="st_OldPwd">ԭ����</param>
        /// <param name="st_NewPwd">������</param>
        /// <param name="st_ReNewPwd">�ظ�����</param>
        /// <returns>����ֵ</returns>
        int ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd);
        #endregion

       #region ���ѧ����Ϣ
       int AddStudent(StudentInf studentInf);
       #endregion

       #region ��ȡѧ���б���Ϣ
       DataTable GetStudentList(string dp_Name, string sp_Name, string cl_Name);
       #endregion

       #region ��ȡѧ����ϸ
       DataTable DisplayStudentDetialsInf(string st_Id);
       #endregion
    }
}
