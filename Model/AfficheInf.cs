using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{
    /// <summary>
    /// 公告信息
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public class AfficheInf
    {
        #region 公告信息私有变量
        private int af_Id;               //公告编号
        private string af_Title;        //公告标题
        private string af_Content;      //公告内容
        private string dp_Id;            //公告所属部门编号
        //private DateTime af_Time;       //公告时间
        private DateTime af_EnableTime; //公告有效期
        private string af_FilePath;     //公告文件存放路径
        #endregion

        #region 公告构造函数
        /// <summary>
        /// 公告构造函数
        /// </summary>
        /// <param name="af_Id">公告编号</param>
        /// <param name="dp_Id">部门编号</param>
        /// <param name="af_Title">标题</param>
        /// <param name="af_Content">内容</param>
        /// <param name="af_EnableTime">有效期</param>
        /// <param name="af_FilePath">公告文件存放地址</param>
        public AfficheInf(
                    int af_Id,
                    string dp_Id,
                    string af_Title,
                    string af_Content,
                    DateTime af_EnableTime,
                    string af_FilePath
           )
        {
            this.af_Id=af_Id;
            this.dp_Id = dp_Id;
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }
        #endregion

        #region 公告构造函数
        /// <summary>
        /// 公告构造函数
        /// </summary>
        /// <param name="dp_Id">部门编号</param>
        /// <param name="af_Title">标题</param>
        /// <param name="af_Content">内容</param>
        /// <param name="af_EnableTime">有效期</param>
        /// <param name="af_FilePath">公告文件存放地址</param>
        public AfficheInf(
                    string dp_Id,
                    string af_Title,
                    string af_Content,
                    DateTime af_EnableTime,
                    string af_FilePath
           )
        {
            this.dp_Id = dp_Id;
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }

        #endregion

        #region 公告构造函数
        /// <summary>
        /// 公告构造函数
        /// </summary>
        /// <param name="af_Title">标题</param>
        /// <param name="af_Content">内容</param>
        /// <param name="af_EnableTime">有效期</param>
        /// <param name="af_FilePath">公告文件存放地址</param>
        public AfficheInf(
            string af_Title,
            string af_Content,
            DateTime af_EnableTime,
            string af_FilePath
         )
        {
            this.af_Title = af_Title;
            this.af_Content = af_Content;
            this.af_EnableTime = af_EnableTime;
            this.af_FilePath = af_FilePath;
        }
        #endregion

        #region 公告属性
        public int Af_Id
        {
            set
            {
                af_Id = value;
            }
            get
            {
                return af_Id;
            }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
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
        /// <summary>
        /// 公告标题
        /// </summary>
        public string Af_Title
        {
            set
            {
                af_Title = value;
            }
            get
            {
                return af_Title;
            }
        }
        /// <summary>
        /// 公告内容
        /// </summary>
        public string Af_Content
        {
            set
            {
                af_Content = value;
            }
            get
            {
                return af_Content;
            }
        }
        /// <summary>
        /// 公告有效期
        /// </summary>
        public DateTime Af_EnableTime
        {
            set
            {
                af_EnableTime = value;
            }
            get
            {
                return af_EnableTime;
            }
        }
        /// <summary>
        /// 公告文件路径
        /// </summary>
        public string Af_FilePath
        {
            set
            {
                af_FilePath = value;
            }
            get
            {
                return af_FilePath;
            }
        }
        #endregion
    }
}
