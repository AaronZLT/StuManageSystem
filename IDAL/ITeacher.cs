using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    public interface ITeacher
    {
        #region ��֤��½
        /// <summary>
        /// ��֤��½
        /// </summary>
        /// <param name="te_Id">��ʦID</param>
        /// <param name="te_Pwd">����</param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool ValidLogin(string te_Id,string te_Pwd);
        #endregion

        #region �޸�����
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="st_Id">��ʦID</param>
        /// <param name="st_OldPwd">ԭ����</param>
        /// <param name="st_NewPwd">������</param>
        /// <param name="st_ReNewPwd">�ظ�����</param>
        /// <returns>����ֵ</returns>
        int ChangePwd(string st_Id, string st_OldPwd, string st_NewPwd, string st_ReNewPwd);
        #endregion

        #region �����ʦ
        /// <summary>
        /// �����ʦ
        /// </summary>
        /// <param name="teacherInf">��ʦʵ��</param>
        /// <returns></returns>
        int AddTeacher(TeacherInf teacherInf);
        #endregion

        #region ��ȡ��ʦ�б�
        DataTable GetTeachers(string dp_name);
        #endregion

        #region ��ȡ��ʦ��ϸ��Ϣ
        DataTable DisplayTeacherDetailsInf(string te_id);
        #endregion
    }
}
