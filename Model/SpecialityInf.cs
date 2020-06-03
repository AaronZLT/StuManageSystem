using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// רҵʵ����
    /// </summary>
    public class SpecialityInf
    {
        #region רҵ��˽�б���
        private string sp_Id;     //רҵ���
        private string dp_Id;     //����ѧԺ���
        private string sp_Name;   //רҵ����
        private string sp_Remark; //רҵ��ע
        private string sp_Grade;  //רҵ�꼶
        #endregion 

        #region ���캯��
        public SpecialityInf(
            string sp_id, string dp_id, string sp_name, string sp_remark, string sp_grade
            )
        {
            this.sp_Id = sp_id;
            this.dp_Id = dp_id;
            this.sp_Name = sp_name;
            this.sp_Remark = sp_remark;
            this.sp_Grade = sp_grade;
        }
        #endregion

        #region רҵ����
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
        public string Sp_Name
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
        public string Sp_Remark
        {
            set
            {
                sp_Remark = value;
            }
            get
            {
                return sp_Remark;
            }
        }
        public string Sp_Grade
        {
            set
            {
                sp_Grade = value;
            }
            get
            {
                return sp_Grade;
            }
        }
        #endregion
    }
}
