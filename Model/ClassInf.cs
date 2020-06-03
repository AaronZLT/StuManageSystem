using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// 学生班级实体
    /// </summary>
    public class ClassInf
    {
        #region 私有变量
        private string cl_Id;       //班级编号
        private string sp_Id;       //所属专业编号
        private string cl_Name;     //班级名字
        private string cl_Remark;   //班级备注
        #endregion

        #region 班级构造函数
        public ClassInf(string cl_id, string sp_id, string cl_name, string cl_remark)
        {
            this.cl_Id = cl_id;
            this.sp_Id = sp_id;
            this.cl_Name = cl_name;
            this.cl_Remark = cl_remark;
        }
        #endregion

        #region 班级属性
        /// <summary>
        /// 班级编号
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
        /// 班级所属专业编号
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
        /// 班级名字
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
        /// 班级备注
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
