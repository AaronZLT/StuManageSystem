using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// ��ʦʵ����
    /// ������:���
    /// ʱ��:2008-3-27
    /// </summary>
    public class TeacherInf
    {
        #region  ��ʦʵ����˽�б���
        private string te_ID;          //��ʦ���
       // private string te_Pwd;         //ϵͳ����
        private string te_Name;        //��ʦ����
        private string dp_Id;          //����ѧԺ
        private string te_Sex;         //��ʦ�Ա�
        private string te_Identity;     //���֤��
        private string te_Speciality;  //��ʦ��ҵרҵ
        private string te_Learngrade;  //ѧ��
        private string te_ZZFace;      //������ò
        private string te_ZhiCheng;    //ְ��
        private string te_Tel;         //��ʦ�绰
        private DateTime te_Birthday;  //��������
        private DateTime te_Teachtime;  //��ְʱ��
        private string te_Address;     //��ͥ��ַ
        private string te_Province;    //ʡ
        private string te_MinZu;       //����
        private string te_Remark;      //��ʦ��ע
        #endregion

        #region ��ʦʵ�幹�캯��
        /// <summary>
        /// ��ʦʵ�幹�캯��
        /// </summary>
        /// <param name="te_ID">��ʦ���</param>
        /// <param name="te_Pwd">ϵͳ����</param>
        /// <param name="te_Name">����</param>
        /// <param name="te_Sex">�Ա�</param>
        /// <param name="te_Speciality">��ҵרҵ</param>
        /// <param name="te_Tel">�绰</param>
        /// <param name="te_Birthday">��������</param>
        /// <param name="te_Jointime">��ְʱ��</param>
        /// <param name="te_Remark">��ע</param>
        public TeacherInf(
                  string te_ID,
                  string te_Name,
                  string dp_Id,
                  string te_Sex,
                  string te_Identity,
                  string te_Speciality,
                  string te_LearnGrade,
                  string te_ZhiCheng,
                  string te_ZZFace,
                  string te_Tel,
                  DateTime te_Birthday,
                  DateTime te_Teachtime,
                  string te_Address,
                  string te_Province,
                  string te_MinZu,
                  string te_Remark)
        {
            this.te_ID = te_ID;
            this.te_Name = te_Name;
            this.dp_Id = dp_Id;
            this.te_Sex = te_Sex;
            this.te_Identity = te_Identity;
            this.te_Speciality = te_Speciality;
            this.te_Learngrade = te_LearnGrade;
            this.te_ZhiCheng = te_ZhiCheng;
            this.te_ZZFace = te_ZZFace;
            this.te_Tel = te_Tel;
            this.te_Birthday = te_Birthday;
            this.te_Teachtime = te_Teachtime;
            this.te_Address = te_Address;
            this.te_Province = te_Province;
            this.te_MinZu = te_MinZu;
            this.te_Remark = te_Remark;
        }
        #endregion

        #region ��ʦ����

        /// <summary>
        /// ��ʦ���
        /// </summary>
        public string Te_Id
        {
            set
            {
                te_ID = value;
            }
            get
            {
                return te_ID;
            }
        }

        public string Te_Name
        {
            set
            {
                te_Name = value;
            }
            get
            {
                return te_Name;
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

        public string Te_Sex
        {
            set
            {
                te_Sex = value;
            }
            get
            {
                return te_Sex;
            }
        }

        public string Te_Identity
        {
            set
            {
                te_Identity = value;
            }
            get
            {
                return te_Identity;
            }
        }

        public string Te_Speciality
        {
            set
            {
                te_Speciality = value;
            }
            get
            {
                return te_Speciality;
            }
        }

        public string Te_Learngrade
        {
            set
            {
                te_Learngrade = value;
            }
            get
            {
                return te_Learngrade;
            }
        }

        public string Te_ZhiCheng
        {
            set
            {
                te_ZhiCheng = value;
            }
            get
            {
                return te_ZhiCheng;
            }
        }

        public string  Te_Tel
        {
            set
            {
                te_Tel=value;
            }
            get
            {
                return te_Tel;
            }
        }

        public DateTime  Te_Birthday
        {
            set
            {
                te_Birthday=value;
            }
            get
            {
                return te_Birthday;
            }
        }

        public string Te_ZZFace
        {
            set
            {
                te_ZZFace = value;
            }
            get
            {
                return te_ZZFace;
            }
        }

        public string Te_MinZu
        {
            set
            {
                te_MinZu = value;
            }
            get
            {
                return te_MinZu;
            }
        }

        public  DateTime Te_Teachtime
        {
            set
            {
                te_Teachtime=value;
            }
            get
            {
                return te_Teachtime;
            }
        }
        public string Te_Address
        {
            set
            {
                te_Address=value;
            }
            get
            {
                return te_Address;
            }
        }
        public string Te_Province
        {
            set
            {
                 te_Province=value;
            }
            get
            {
                return te_Province;
            }
        }
        public string Te_Remark
        {
            set
            {
                te_Remark=value;
            }
            get
            {
                return te_Remark;
            }
        }

        #endregion

    }
}
