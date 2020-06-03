using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;
using StudentManager.DALFactory;
using StudentManager.IDAL;
using StudentManager.Model;
using StudentManager.Common;


namespace StudentManager.BLL
{
    /// <summary>
    /// �༶ҵ���߼���
    /// </summary>
    public class StuClass
    {
        #region ʹ�÷��乤�������༶ʵ��
        private IClass stuClass = DataAccess.CreateClass();
        #endregion

        #region ��Ӱ༶
        public void AddClass(ClassInf classInf)
        {
            int result = stuClass.AddClass(classInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("��Ӱ༶�ɹ�!", "AddClass.aspx");
                    break;
                case 0: JScript.Alert("���ʧ��,��������!");
                    JScript.GoHistory(-1);
                    break;
                case -2: JScript.Alert("�༶����ظ��뻻�����༶���!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region ��ȡ�༶�б���Ϣ
        public void BindClassList(string sp_id, DropDownList ddlClassList)
        {
            ddlClassList.DataSource = stuClass.GetClassList(sp_id);
            ddlClassList.DataTextField = "cl_name";
            ddlClassList.DataValueField = "cl_id";
            ddlClassList.DataBind();
        }
        #endregion

        #region ��ȡ�༶��Ϣ
        public void BindeClasses(string dp_Name, string sp_Name,GridView gvClass)
        {
            gvClass.DataSource= stuClass.GetClasses(dp_Name, sp_Name);
            gvClass.DataBind();
        }
        #endregion
    }
}
