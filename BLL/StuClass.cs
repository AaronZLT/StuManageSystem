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
    /// 班级业务逻辑层
    /// </summary>
    public class StuClass
    {
        #region 使用反射工厂创建班级实体
        private IClass stuClass = DataAccess.CreateClass();
        #endregion

        #region 添加班级
        public void AddClass(ClassInf classInf)
        {
            int result = stuClass.AddClass(classInf);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("添加班级成功!", "AddClass.aspx");
                    break;
                case 0: JScript.Alert("添加失败,请检查输入!");
                    JScript.GoHistory(-1);
                    break;
                case -2: JScript.Alert("班级编号重复请换其他班级编号!");
                    JScript.GoHistory(-1);
                    break;
            }
        }
        #endregion

        #region 获取班级列表信息
        public void BindClassList(string sp_id, DropDownList ddlClassList)
        {
            ddlClassList.DataSource = stuClass.GetClassList(sp_id);
            ddlClassList.DataTextField = "cl_name";
            ddlClassList.DataValueField = "cl_id";
            ddlClassList.DataBind();
        }
        #endregion

        #region 获取班级信息
        public void BindeClasses(string dp_Name, string sp_Name,GridView gvClass)
        {
            gvClass.DataSource= stuClass.GetClasses(dp_Name, sp_Name);
            gvClass.DataBind();
        }
        #endregion
    }
}
