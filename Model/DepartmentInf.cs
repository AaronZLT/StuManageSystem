using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// 部门实体类
    /// 创建者:余洪
    /// 时间:2008-3-28
    /// </summary>
    public  class DepartmentInf
    {
        #region  部门实体类私有变量
        private string dp_Id;       //部门编号
        private string dp_Pwd;      //部门密码
        private string dp_Name;     //部门名称
        private string dp_Address;  //部门地址
        private string dp_Tel;      //部门电话
        private string dp_Remark;   //部门备注
        #endregion

        #region  部门实体类构造函数
        /// <summary>
        /// 部门实体类构造函数
        /// </summary>
        /// <param name="dp_Id">部门编号</param>
        /// <param name="dp_Pwd">部门密码</param>
        /// <param name="dp_Name">名称</param>
        /// <param name="dp_Address">地址</param>
        /// <param name="dp_Tel">电话</param>
        /// <param name="dp_Remark">备注</param>
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

        #region 部门属性
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
