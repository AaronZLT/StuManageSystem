using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using StudentManager.DALFactory;
using StudentManager.IDAL;
using StudentManager.Model;
using StudentManager.SQLServer;

#region רҵҵ���߼���
namespace StudentManager.BLL
{
    /// <summary>
    /// �߼���רҵ����
    /// ����:���
    /// ʱ��:2008-05-01
    /// </summary>
    public class Speciality
    {
        #region ���÷��乤������רҵ��
        private ISpeciality speciality = DataAccess.CreateSpeciality();
        #endregion

        #region ��רҵ�б���Ϣ
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
        public void  BindSpecialityList(string dp_Id, string sp_Grade,GridView gvSpecialityList)
        {
            DataTable tb=speciality.GetSpecialityList(dp_Id, sp_Grade);
            gvSpecialityList.DataSource = tb;
            gvSpecialityList.DataBind();
        }
        #endregion

        #region ��ѧԺ��רҵ�б���Ϣ
        /// <summary>
        /// ��ȡרҵ�б�
        /// </summary>
        /// <returns>רҵ��Ϣ�б�</returns>
        public void BindSpecialityList(string dp_Id,DropDownList ddlSpecialityList)
        {
            ddlSpecialityList.DataSource = speciality.GetSpecialityList(dp_Id);
            ddlSpecialityList.DataTextField = "sp_name";
            ddlSpecialityList.DataValueField = "sp_id";
            ddlSpecialityList.DataBind();
        }
        #endregion

    }
}
#endregion