using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// 专业实体类
    /// </summary>
    public class SpecialityInf
    {
        #region 专业类私有变量
        private string sp_Id;     //专业编号
        private string dp_Id;     //所属学院编号
        private string sp_Name;   //专业名称
        private string sp_Remark; //专业备注
        private string sp_Grade;  //专业年级
        #endregion 

        #region 构造函数
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

        #region 专业属性
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
