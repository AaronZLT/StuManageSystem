using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace StudentManager.IDAL
{
    public interface ICommon
    {
        #region ��ȡϵͳ��½�˻�������ӭ��Ϣ
        /// <summary>
        /// ��ȡϵͳ��½�˻�������ӭ��Ϣ
        /// </summary>
        /// <returns></returns>
        string GetUserWelInf(string u_Id, string u_Table);
        #endregion

        #region ��ȡѧ���б�
        DataTable GetLearnList();
        #endregion

        #region ��ȡ��ʦְ���б�
        DataTable GetZhiChengList();
        #endregion

        #region ��ȡ������ò�б�
        DataTable GetZZList();
        #endregion

        #region ��ȡ�����б�
        DataTable GetMZList();
        #endregion 

        #region ��ȡʡ�б�
        DataTable GetProvinceList();
        #endregion

        #region ��ȡ���б�
        DataTable GetCityList(string province);
        #endregion

        #region ��רҵ��Ϣ�������б��
        DataTable  GetSpecialityListForBind();
        #endregion
    }
}
