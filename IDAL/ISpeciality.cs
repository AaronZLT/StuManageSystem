using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace StudentManager.IDAL
{
    /// <summary>
    /// רҵ�ӿڲ�
    /// </summary>
    public interface ISpeciality
    {
        #region ��ȡרҵ�б�
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
        DataTable GetSpecialityList(string dp_Id, string sp_Grade);
        #endregion

        #region ɾ��רҵ
        /// <summary>
        /// ɾ��רҵ
        /// </summary>
        /// <param name="sp_Id"></param>
        /// <returns></returns>
        bool DelSpeciality(string sp_Id);
        #endregion

        #region ��ѧԺ��ȡרҵ�б���Ϣ
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
        DataTable GetSpecialityList(string dp_Id);
        #endregion

    }
}
