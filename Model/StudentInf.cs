using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{   

    /// <summary>
    /// 学生实体类
    /// </summary>
    public class StudentInf
    {
        #region 学生实体类私有字段
        private string st_Id;          //学号
        //private string st_Pwd;         //系统密码
        private string cl_Id;          //所属班级编号
        private string st_Name;        //姓名
        private string st_Sex;         //性别
        private DateTime st_Birthday;  //出生日期
        private string mz_Name;        //民族
        private string st_Identity;    //身份证号
        private string st_Tel;         //电话
        private string st_Province;    //来源省
        private string st_Face;        //政治面貌
        private string st_address;     //家庭地址
        private string st_Remark;      //备注
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="st_Id">学号</param>
        /// <param name="st_Name">姓名</param>
        /// <param name="st_Sex">性别</param>
        /// <param name="st_Birthday">出生日期</param>
        /// <param name="st_Identity">身份证号</param>
        /// <param name="st_Tel">电话</param>
        /// <param name="st_Province">来源省</param>
        /// <param name="st_City">来源市</param>
        /// <param name="st_Face">政治面貌</param>
        /// <param name="st_address">家庭地址</param>
        /// <param name="st_Remark">备注</param>
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

        #region 学生实体属性
        /// <summary>
        /// 学号
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
        /// 所属班级编号
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
        /// 名字
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
        /// 性别
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
        /// 生日
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
        /// 民族
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
        /// 身份证号
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
        /// 电话
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
        /// 省
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
        /// 政治面貌
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
        /// 地址
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
        /// 备注
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
