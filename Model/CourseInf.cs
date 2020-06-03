using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{

    #region �γ�ʵ��
    /// <summary>
    /// �γ�ʵ��
    /// </summary>
    public class CourseInf
    {
        #region �γ��ֶ�
        private string cb_Id; //�γ̱��
        private string dp_Id; //����ѧԺ
        private string cb_Name; //�γ�����
        private float cb_Credithour; //ѧ��
        private string ct_Type; //�γ�����
        private int cb_Time;   //ѧʱ
        private string cb_Ispublic; //�Ƿ񹫹���Ŀ
        private string cb_Remark; //�γ̱�ע

        private string sp_Id; //רҵ���
        private string te_Id;//�Ͽν�ʦ
        private string cr_Id; //�Ͽν���
        private string pc_Year;//ѧ��
        private int pc_Term;//ѧ��
        private string pc_Weeks;//�Ͽ���
        private int pc_PersonCount;//����
        private string pc_ClassTime;//�Ͽ�ʱ��
        private string pc_Remark;//��ע
        #endregion

        #region �γ��๹�췽��
        public CourseInf(
            string cb_id,
            string dp_id,
            string cb_name,
            float cb_credithour,
            string ct_type,
            int cb_time,
            string cb_Ispublic,
            string cb_Remark
            )
        {
            this.cb_Id= cb_id;
            this.dp_Id = dp_id;
            this.cb_Name = cb_name;
            this.cb_Credithour = cb_credithour;
            this.ct_Type = ct_type;
            this.cb_Time = cb_time;
            this.cb_Ispublic = cb_Ispublic;
            this.cb_Remark = cb_Remark;
        }
        #endregion

        #region �γ�����
        public string Cb_Id
        {
            set
            {
                cb_Id = value;
            }
            get
            {
                return cb_Id;
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
        public string Cb_Name
        {
            set
            {
                cb_Name = value;
            }
            get
            {
                return cb_Name;
            }
        }

        public float Cb_Credithour
        {
            set
            {
                cb_Credithour = value;
            }
            get
            {
                return cb_Credithour;
            }
        }

        public string Ct_Type
        {
            set
            {
                ct_Type = value;
            }
            get
            {
                return ct_Type;
            }
        }

        public int Cb_Time
        {
            set
            {
                cb_Time = value;
            }
            get
            {
                return cb_Time;
            }
        }

        public string  Cb_Ispublic
        {
            set
            {
                cb_Ispublic = value;
            }
            get
            {
                return cb_Ispublic;
            }
        }
        public string Cb_Remark
        {
            set
            {
                cb_Remark = value;
            }
            get
            {
                return cb_Remark;
            }
        }
        #endregion

        #region ѡ��������
        public CourseInf(
            string cb_id,
            string sp_id,
            string te_id,
            string cr_id,
            string pc_Year,
            int pc_Term,
            string pc_Weeks,
            int pc_PersonCount,
            string pc_ClassTime,
            string pc_Remark
            )
        {
            this.cb_Id = cb_id;
            this.sp_Id = sp_id;
            this.te_Id = te_id;
            this.cr_Id = cr_id;
            this.pc_Year = pc_Year;
            this.pc_Term = pc_Term;
            this.pc_Weeks = pc_Weeks;
            this.pc_PersonCount = pc_PersonCount;
            this.pc_ClassTime = pc_ClassTime;
            this.pc_Remark = pc_Remark;
        }
        #endregion
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

        public string Te_Id
        {
            set
            {
                te_Id = value;
            }
            get
            {
                return te_Id;
            }
        }
        public string Cr_Id
        {
            set
            {
                cr_Id = value;
            }
            get
            {
                return cr_Id;
            }
        }
        public string Pc_Year
        {
            set
            {
                pc_Year = value;
            }
            get
            {
                return pc_Year;
            }
        }
        public int Pc_Term
        {
            set
            {
                pc_Term = value;
            }
            get
            {
                return pc_Term;
            }
        }

        public string Pc_Weeks
        {
            set
            {
                pc_Weeks = value;
            }
            get
            {
                return pc_Weeks;
            }
        }
        public int Pc_PersonCount
        {
            set
            {
                pc_PersonCount = value;
            }
            get
            {
                return pc_PersonCount;
            }
        }
        public string Pc_ClassTime
        {
            set
            {
                pc_ClassTime = value;
            }
            get
            {
                return pc_ClassTime;
            }
        }

        public string PC_Remark
        {
            set
            {
                pc_Remark = value;
            }
            get
            {
                return pc_Remark;
            }
        }

    }
    #endregion
}
