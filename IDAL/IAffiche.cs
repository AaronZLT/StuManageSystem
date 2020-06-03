using System;
using System.Data;
using System.Text;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    /// <summary>
    /// ����ӿ�
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public interface IAffiche
    {
        #region ��ȡ������Ϣ
        /// <summary>
        /// ��ȡ������Ϣ
        /// </summary>
        /// <returns>������Ϣ</returns>
        DataSet GetAffiches();
        #endregion

        #region ��ȡҪ�鿴�Ĺ�����Ϣ
        /// <summary>
        /// ��ȡҪ�鿴�Ĺ�����Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <returns></returns>
        DataSet GetAffiche(int af_Id);
        #endregion

        #region ������
        /// <summary>
        /// ������
        /// </summary>
        /// <param name="afficheInf">������Ϣʵ��</param>
        /// <returns></returns>
        bool AddAffiche(AfficheInf afficheInf);
        #endregion

        #region  ɾ��������Ϣ
        /// <summary>
        /// ɾ��������Ϣ
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">����ID</param>
        /// <returns></returns>
        int DelAffiche(int af_Id, string dp_Id);
        #endregion

        #region ��ȡҪ���µ�
        /// <summary>
        /// ��ȡҪ���µ�
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">����ID</param>
        /// <returns></returns>
        AfficheInf  GetAfficheForUpdate(int af_Id, string dp_Id);
        #endregion

        #region �޸Ĺ�����Ϣ
        /// <summary>
        /// �޸Ĺ�����Ϣ
        /// </summary>
        /// <param name="afficheInf">����ʵ��</param>
        /// <returns></returns>
        bool UpdateAffiche(AfficheInf afficheInf);
        #endregion
    }
}
