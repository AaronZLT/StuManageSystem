using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// ������Ϣ
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public class AfficheInf
    {
        #region ������Ϣ˽�б���
        private int af_Id;               //������
        private string af_Title;        //�������
        private string af_Content;      //��������
        private string dp_Id;            //�����������ű��
        //private DateTime af_Time;       //����ʱ��
        private DateTime af_EnableTime; //������Ч��
        private string af_FilePath;     //�����ļ����·��
        #endregion

        #region ���湹�캯��
        /// <summary>
        /// ���湹�캯��
        /// </summary>
        /// <param name="af_Id">������</param>
        /// <param name="dp_Id">���ű��</param>
        /// <param name="af_Title">����</param>
        /// <param name="af_Content">����</param>
        /// <param name="af_EnableTime">��Ч��</param>
        /// <param name="af_FilePath">�����ļ���ŵ�ַ</param>
        public AfficheInf(
                    int af_Id,
                    string dp_Id,
                    string af_Title,
                    string af_Content,
                    DateTime af_EnableTime,
                    string af_FilePath
           )
        {
            this.af_Id=af_Id;
            this.dp_Id = dp_Id;
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }
        #endregion

        #region ���湹�캯��
        /// <summary>
        /// ���湹�캯��
        /// </summary>
        /// <param name="dp_Id">���ű��</param>
        /// <param name="af_Title">����</param>
        /// <param name="af_Content">����</param>
        /// <param name="af_EnableTime">��Ч��</param>
        /// <param name="af_FilePath">�����ļ���ŵ�ַ</param>
        public AfficheInf(
                    string dp_Id,
                    string af_Title,
                    string af_Content,
                    DateTime af_EnableTime,
                    string af_FilePath
           )
        {
            this.dp_Id = dp_Id;
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }

        #endregion

        #region ���湹�캯��
        /// <summary>
        /// ���湹�캯��
        /// </summary>
        /// <param name="af_Title">����</param>
        /// <param name="af_Content">����</param>
        /// <param name="af_EnableTime">��Ч��</param>
        /// <param name="af_FilePath">�����ļ���ŵ�ַ</param>
        public AfficheInf(
            string af_Title,
            string af_Content,
            DateTime af_EnableTime,
            string af_FilePath
         )
        {
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }
        #endregion

        #region ��������
        public int Af_Id
        {
            set
            {
                af_Id = value;
            }
            get
            {
                return af_Id;
            }
        }
        /// <summary>
        /// ���ű��
        /// </summary>
        public string Dp_Id
        {
            set
            {
                dp_Id = value;
            }
            get
            {
                return dp_Id;
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string Af_Title
        {
            set
            {
                af_Title = value;
            }
            get
            {
                return af_Title;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string Af_Content
        {
            set
            {
                af_Content = value;
            }
            get
            {
                return af_Content;
            }
        }
        /// <summary>
        /// ������Ч��
        /// </summary>
        public DateTime Af_EnableTime
        {
            set
            {
                af_EnableTime = value;
            }
            get
            {
                return af_EnableTime;
            }
        }
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        public string Af_FilePath
        {
            set
            {
                af_FilePath = value;
            }
            get
            {
                return af_FilePath;
            }
        }
        #endregion
    }
}
