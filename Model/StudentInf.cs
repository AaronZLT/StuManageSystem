using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{   

    /// <summary>
    /// ѧ��ʵ����
    /// </summary>
    public class StudentInf
    {
        #region ѧ��ʵ����˽���ֶ�
        private string st_Id;          //ѧ��
        //private string st_Pwd;         //ϵͳ����
        private string cl_Id;          //�����༶���
        private string st_Name;        //����
        private string st_Sex;         //�Ա�
        private DateTime st_Birthday;  //��������
        private string mz_Name;        //����
        private string st_Identity;    //���֤��
        private string st_Tel;         //�绰
        private string st_Province;    //��Դʡ
        private string st_Face;        //������ò
        private string st_address;     //��ͥ��ַ
        private string st_Remark;      //��ע
        #endregion

        #region ���캯��
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="st_Id">ѧ��</param>
        /// <param name="st_Name">����</param>
        /// <param name="st_Sex">�Ա�</param>
        /// <param name="st_Birthday">��������</param>
        /// <param name="st_Identity">���֤��</param>
        /// <param name="st_Tel">�绰</param>
        /// <param name="st_Province">��Դʡ</param>
        /// <param name="st_City">��Դ��</param>
        /// <param name="st_Face">������ò</param>
        /// <param name="st_address">��ͥ��ַ</param>
        /// <param name="st_Remark">��ע</param>
        public StudentInf(
            string st_Id,
            string cl_Id,
            string st_Name,
            string st_Sex, 
            DateTime st_Birthday,
            string st_Identity,
            string st_Tel,
            string st_Province,
            string st_Face, 
            string mz_Name,
            string st_address,
            string st_Remark)
        {
            this.st_Id = st_Id;
            this.cl_Id = cl_Id;
            this.st_Name = st_Name;
            this.st_Sex = st_Sex;
            this.st_Birthday = st_Birthday;
            this.st_Identity = st_Identity;
            this.st_Tel = st_Tel;
            this.st_Province = st_Province;
            this.st_Face = st_Face;
            this.mz_Name = mz_Name;
            this.st_address = st_address;
            this.st_Remark = st_Remark;
        }
        #endregion

        #region ѧ��ʵ������
        /// <summary>
        /// ѧ��
        /// </summary>
        public string St_Id
        {
            set
            {
                st_Id = value;
            }
            get
            {
                return st_Id;
            }
        }

        /// <summary>
        /// �����༶���
        /// </summary>
        public string Cl_Id
        {
            set
            {
                cl_Id = value;
            }
            get
            {
                return cl_Id;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string St_Name
        {
            set
            {
                st_Name = value;
            }
            get
            {
                return st_Name;
            }
        }

        /// <summary>
        /// �Ա�
        /// </summary>
        public string St_Sex
        {
            set
            {
                st_Sex = value;
            }
            get
            {
                return st_Sex;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public DateTime St_Birthday
        {
            set
            {
                st_Birthday = value;
            }
            get
            {
                return st_Birthday;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string Mz_Name
        {
            set
            {
                mz_Name = value;   
            }
            get
            {
                return mz_Name;
            }
        }

        /// <summary>
        /// ���֤��
        /// </summary>
        public string St_Identity
        {
            set
            {
                st_Identity = value;
            }
            get
            {
                return st_Identity;
            }
        }

        /// <summary>
        /// �绰
        /// </summary>
        public string St_Tel
        {
            set
            {
                st_Tel = value;
            }
            get
            {
                return st_Tel;
            }
        }

        /// <summary>
        /// ʡ
        /// </summary>
        public string St_Province
        {
            set
            {
                st_Province = value;
            }
            get
            {
                return st_Province;
            }
        }

        /// <summary>
        /// ������ò
        /// </summary>
        public string St_Face
        {
            set
            {
                st_Face = value;
            }
            get
            {
                return st_Face;
            }
        }
        /// <summary>
        /// ��ַ
        /// </summary>
        public string St_Address
        {
            set
            {
                st_address=value;
            }
            get
            {
                return st_address;
            }
        }

        /// <summary>
        /// ��ע
        /// </summary>
        public string St_Remark
        {
            set
            {
                st_Remark = value;
            }
            get
            {
                return st_Remark;
            }
        }
        #endregion

    }
}
