using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// ѧ���༶ʵ��
    /// </summary>
    public class ClassInf
    {
        #region ˽�б���
        private string cl_Id;       //�༶���
        private string sp_Id;       //����רҵ���
        private string cl_Name;     //�༶����
        private string cl_Remark;   //�༶��ע
        #endregion

        #region �༶���캯��
        public ClassInf(string cl_id, string sp_id, string cl_name, string cl_remark)
        {
            this.cl_Id = cl_id;
            this.sp_Id = sp_id;
            this.cl_Name = cl_name;
            this.cl_Remark = cl_remark;
        }
        #endregion

        #region �༶����
        /// <summary>
        /// �༶���
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
        /// �༶����רҵ���
        /// </summary>
        public string Sp_Id
        {
            set
            {
                sp_Id = value;
            }
            get
            {
                return sp_Id;
            }
         }
        /// <summary>
        /// �༶����
        /// </summary>
        public string Cl_Name
        {
            set
            {
                cl_Name = value;
            }
            get
            {
                return cl_Name;
            }
        }
        /// <summary>
        /// �༶��ע
        /// </summary>
        public string Cl_Remark
        {
            set
            {
                cl_Remark = value;
            }
            get
            {
                return cl_Remark;
            }
        }
        #endregion
    }
}
