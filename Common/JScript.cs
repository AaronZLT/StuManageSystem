using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StudentManager.Common
{
    /// <summary>
    /// һЩJava script����
    /// ������:���
    /// ʱ��:2008-3
    /// </summary>
    public class JScript
    {
        #region  �ض�Url
        /// <summary>
        /// �ض�Url
        /// </summary>
        /// <param name="toUrl">��url��ַ</param>
        public static void RedirectUrl(string toUrl)
        {           
            HttpContext.Current.Response.Redirect(toUrl);
        }
        #endregion

        #region  ������Ϣ
        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        public static void Alert(string message)
        {
            HttpContext.Current.Response.Write("<script language='javascript'>alert('" + message + "');</script>");
        }
        #endregion

        #region  �رմ���,ȡ���رշ���ǰһ��ʷҳ
        /// <summary>
        /// �رմ���,ȡ���رշ���ǰһ��ʷҳ
        /// </summary>
        public static void ColseWindow()
        {
            HttpContext.Current.Response.Write("<script language='javascript'>parent.opener=null;window.close();history.go(-1);</script>");
            HttpContext.Current.Response.End();
        }
        #endregion

        #region  ������Ϣ,����ת��ָ��ҳ
        /// <summary>
        /// ������Ϣ,����ת��ָ��ҳ
        /// </summary>
        /// <param name="message">��Ϣ����</param>
        /// <param name="redirectUrl">��תҳ</param>
        public static void AlertAndRedirect(string message, string redirectUrl)
        {
            string js = "<script language='javascript'>alert('{0}');window.location.replace('{1}');</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, redirectUrl));
        }
        #endregion

        #region �ض�����ʷҳ
        /// <summary>
        /// �ض�����ʷҳ
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

