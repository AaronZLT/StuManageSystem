using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// ����ʵ����
    /// ������:���
    /// ʱ��:2008-3-28
    /// </summary>
    public  class DepartmentInf
    {
        #region  ����ʵ����˽�б���
        private string dp_Id;       //���ű��
        private string dp_Pwd;      //��������
        private string dp_Name;     //��������
        private string dp_Address;  //���ŵ�ַ
        private string dp_Tel;      //���ŵ绰
        private string dp_Remark;   //���ű�ע
        #endregion

        #region  ����ʵ���๹�캯��
        /// <summary>
        /// ����ʵ���๹�캯��
        /// </summary>
        /// <param name="dp_Id">���ű��</param>
        /// <param name="dp_Pwd">��������</param>
        /// <param name="dp_Name">����</param>
        /// <param name="dp_Address">��ַ</param>
        /// <param name="dp_Tel">�绰</param>
        /// <param name="dp_Remark">��ע</param>
        public DepartmentInf(
            string dp_Id,
            string dp_Pwd,
            string dp_Name,
            string dp_Address,
            string dp_Tel,
            string dp_Remark
            )
        {
            this.dp_Id = dp_Id;
            this.dp_Pwd = dp_Pwd;
            this.dp_Name = dp_Name;
            this.dp_Address = dp_Address;
            this.dp_Tel = dp_Tel;
            this.dp_Remark = dp_Remark;
        }
        #endregion

        #region ��������
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
        public string Dp_Pwd
        {
            set
            {
                dp_Pwd = value;
            }
            get
            {
                return dp_Pwd;
            }
        }
        public string Dp_Name
        {
            set
            {
                dp_Name= value;
            }
            get
            {
                return dp_Name; 
            }
        }

        public string Dp_Address
        {
            set
            {
                dp_Address = value;
            }
            get
            {
                return dp_Address;
            }
        }

        public string Dp_Tel
        {
            set
            {
                dp_Tel = value;
            }
            get
            {
                return dp_Tel;
            }
        }

        public string Dp_Remark
        {
            set
            {
                dp_Remark = value;
            }
            get
            {
                return dp_Remark;
            }
        }
        #endregion
    }
}
