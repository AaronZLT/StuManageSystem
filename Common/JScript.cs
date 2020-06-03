using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StudentManager.Common
{
    /// <summary>
    /// 一些Java script调用
    /// 创建者:余洪
    /// 时间:2008-3
    /// </summary>
    public class JScript
    {
        #region  重定Url
        /// <summary>
        /// 重定Url
        /// </summary>
        /// <param name="toUrl">新url地址</param>
        public static void RedirectUrl(string toUrl)
        {           
            HttpContext.Current.Response.Redirect(toUrl);
        }
        #endregion

        #region  弹出消息
        /// <summary>
        /// 弹出消息
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Alert(string message)
        {
            HttpContext.Current.Response.Write("<script language='javascript'>alert('" + message + "');</script>");
        }
        #endregion

        #region  关闭窗口,取消关闭返回前一历史页
        /// <summary>
        /// 关闭窗口,取消关闭返回前一历史页
        /// </summary>
        public static void ColseWindow()
        {
            HttpContext.Current.Response.Write("<script language='javascript'>parent.opener=null;window.close();history.go(-1);</script>");
            HttpContext.Current.Response.End();
        }
        #endregion

        #region  弹出消息,并跳转到指定页
        /// <summary>
        /// 弹出消息,并跳转到指定页
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="redirectUrl">跳转页</param>
        public static void AlertAndRedirect(string message, string redirectUrl)
        {
            string js = "<script language='javascript'>alert('{0}');window.location.replace('{1}');</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, redirectUrl));
        }
        #endregion

        #region 重定向到历史页
        /// <summary>
        /// 重定向到历史页
        /// </summary>
        /// <param name="historyValue">1/-1</param>
        public static void GoHistory(int historyValue)
        {
            string js = "<script language='javascript'>history.go({0})</script>";
            HttpContext.Current.Response.Write(string.Format(js, historyValue));
        }
        #endregion
    }

}

