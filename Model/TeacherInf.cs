using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// 教师实体类
    /// 创建者:余洪
    /// 时间:2008-3-27
    /// </summary>
    public class TeacherInf
    {
        #region  教师实体类私有变量
        private string te_ID;          //教师编号
       // private string te_Pwd;         //系统密码
        private string te_Name;        //教师姓名
        private string dp_Id;          //所属学院
        private string te_Sex;         //教师性别
        private string te_Identity;     //身份证号
        private string te_Speciality;  //教师毕业专业
        private string te_Learngrade;  //学历
        private string te_ZZFace;      //政治面貌
        private string te_ZhiCheng;    //职称
        private string te_Tel;         //教师电话
        private DateTime te_Birthday;  //出生日期
        private DateTime te_Teachtime;  //入职时间
        private string te_Address;     //家庭地址
        private string te_Province;    //省
        private string te_MinZu;       //民族
        private string te_Remark;      //教师备注
        #endregion

        #region 教师实体构造函数
        /// <summary>
        /// 教师实体构造函数
        /// </summary>
        /// <param name="te_ID">教师编号</param>
        /// <param name="te_Pwd">系统密码</param>
        /// <param name="te_Name">姓名</param>
        /// <param name="te_Sex">性别</param>
        /// <param name="te_Speciality">毕业专业</param>
        /// <param name="te_Tel">电话</param>
        /// <param name="te_Birthday">出生日期</param>
        /// <param name="te_Jointime">入职时间</param>
        /// <param name="te_Remark">备注</param>
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

        #region 教师属性

        /// <summary>
        /// 教师编号
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
