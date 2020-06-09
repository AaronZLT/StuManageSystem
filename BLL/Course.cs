using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using StudentManager.DALFactory;
using StudentManager.SQLServer;
using StudentManager.Model;
using StudentManager.IDAL;
using StudentManager.Common;

namespace StudentManager.BLL
{
    /// <summary>
    /// �γ�ҵ���߼������
    /// </summary>
    public class Course
    {
        #region ʹ�÷��乤����̬ʵ�����γ̽ӿ�
        /// <summary>
        /// ʹ�÷��乤����̬ʵ�����γ̽ӿ�
        /// </summary>
        private ICourse course = DataAccess.CreateCourse();
        #endregion

        #region ���ѧԺ���ογ�
        public void AddCourse(CourseInf courseInf,Label lblMessage)
        {
            int result= course.AddCourse(courseInf);
            switch (result)
            {
                case   1: lblMessage.Text = "��ӿγ̳ɹ�!";
                    break;
                case  -1: lblMessage.Text = "�γ̺��ظ�,�뻻�����γ̺� ";
                    break;
                case   0: lblMessage.Text="��ӿγ�ʧ��!";
                    break;
            }
        }
        #endregion

        #region ���רҵѡ��
        public void AddChooseCourse(CourseInf courseInf, Label lblMessage)
        {
            int result = course.AddChooseCourse(courseInf);
            switch (result)
            {
                case 1: lblMessage.Text = "���ѡ�ογ̳ɹ�!";
                    break;
                case -1: lblMessage.Text = "��ѧԺ�Ѿ��������޸ÿγ�";
                    break;
                case -2: lblMessage.Text = "ͬһʱ���Ͽν��ҳ�ͻ";
                    break;
                case -3: lblMessage.Text = "����ʦ�ڸ�ʱ��Ҫ�������γ�";
                    break;
                case 0: lblMessage.Text = "���ѡ�ογ�ʧ��!";
                    break;
            }
        }
        #endregion

        #region �󶨿γ������б�
        public void BindCourseType(DropDownList ddlCourseType)
        {
            ddlCourseType.DataSource = course.GetCourseTypeList();
            ddlCourseType.DataValueField = "ct_type";
            ddlCourseType.DataTextField = "ct_type";
            ddlCourseType.DataBind();
        }
        #endregion

        #region �𶨿�����Ϣ
        public void BindCourses(string dp_id,GridView gvCourse)
        {
            gvCourse.DataSource = course.GetCourses(dp_id);
            gvCourse.DataBind();
        }
        #endregion

        #region �󶨿γ̵������б�
        public void BindCoursList(DropDownList ddlCourseList)
        {
            ddlCourseList.DataSource = course.GetCourseList();
            ddlCourseList.DataTextField = "cb_name";
            ddlCourseList.DataValueField = "cb_id";
            ddlCourseList.DataBind();
        }
        #endregion

        #region ���Ͽν��ҵ������б�
        public void BindCRList(DropDownList ddlCRList)
        {
            ddlCRList.DataSource = course.GetCRList();
            ddlCRList.DataTextField = "cr_id";
            ddlCRList.DataValueField = "cr_id";
            ddlCRList.DataBind();
        }
        #endregion

        #region ���Ͽν�ʦ�������б�
        public void BindTeacherList(string dp_id,DropDownList ddlTeacherList)
        {
            ddlTeacherList.DataSource = course.GetTeacherList(dp_id);
            ddlTeacherList.DataTextField = "te_name";
            ddlTeacherList.DataValueField = "te_id";
            ddlTeacherList.DataBind();
        }
        #endregion

        #region ��ѡ��ҳ���ѧ����Ϣ
        public void BindStudentInf(string st_Id,Label lblMessage,ref string dp_id,ref string sp_id)
        {
            lblMessage.Text =course.GetStudentInf(st_Id, ref dp_id,ref sp_id);
        }
        #endregion

        #region ��ѡ�ογ��б�
        public void BindClassChooseTb(string dp_Id, string sp_Id, string pc_Year, int pc_Term, GridView gvChooseCourse)
        {
            gvChooseCourse.DataSource = course.GetChooseClassTb(dp_Id, sp_Id, pc_Year, pc_Term);
            gvChooseCourse.DataBind();
        }
        #endregion

        #region ѡ��
        public void ChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm, string te_id)
        {
            int result=course.ChooseCourse(st_Id, pc_Id, LearnYear, LearnTerm,te_id);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("ѡ�γɹ�!", "ChooseCourse.aspx");
                    break;
                case -2: JScript.AlertAndRedirect("�Ѿ�ѡ�˸ÿγ���!", "ChooseCourse.aspx");
                    break;
                case -1: JScript.AlertAndRedirect("��������������!", "ChooseCourse.aspx");
                    break;
                case 0: JScript.AlertAndRedirect("ѡ��ʧ��!", "ChooseCourse.aspx");
                    break;
            }
        }
        #endregion

        #region ��ѡ��
        public void NotChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm)
        {
            int result = course.NotChooseCourse(st_Id, pc_Id, LearnYear, LearnTerm);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("��ѡ�ɹ�!", "ChooseCourse.aspx");
                    break;
                case -1: JScript.AlertAndRedirect("��ѡʧ��!", "ChooseCourse.aspx");
                    break;
            }
        }
        #endregion

        #region ��ȡѡ�ν����
        public void GetChooseCourseTable(string st_Id, string pc_Year, int pc_Term,GridView gvChooseTable)
        {
            gvChooseTable.DataSource= course.GetChooseCourseTable(st_Id, pc_Year, pc_Term);
            gvChooseTable.DataBind();
        }
        #endregion

        #region ��ȡ�����ƻ���
        public void GetPlanCourseTable(string st_Id,GridView gvPlanCourse)
        {
            gvPlanCourse.DataSource = course.GetPlanCourseTable(st_Id);
            gvPlanCourse.DataBind();
        }
        #endregion

        #region ��ȡ�ɼ���
        public void GetScoreTable(string st_Id, string pc_Year, int pc_Term, GridView gvScoreTable)
        {        
            gvScoreTable.DataSource = course.QueryScore(st_Id, pc_Year,pc_Term);
            gvScoreTable.DataBind();
        }
        #endregion

        #region ��ѯ��ʦ�ڿα�
        public void  TecherTeachCourses(string te_Id,GridView gvTeachCourses)
        {
            gvTeachCourses.DataSource = course.TecherTeachCourses(te_Id);
            gvTeachCourses.DataBind();
        }
        #endregion

        #region ��ȡѡ��ѧ���б�
        public void ChooseStudentTb(string pc_Id,GridView gvStudents)
        {
            gvStudents.DataSource = course.ChooseStudentTb(pc_Id);
            gvStudents.DataBind();
        }
        #endregion

        #region ��ȡѡ��ѧ���б�
        public void ChooseStudentTb(string pc_Id, GridView gvStudents,ref DataTable dt)
        {
            dt = course.ChooseStudentTb(pc_Id);
            gvStudents.DataSource = course.ChooseStudentTb(pc_Id);
            gvStudents.DataBind();
        }
        #endregion

        #region �󶨶�Ӧ�γ�ѡ��ѧ���б�
        public void  BindStForUpdateScore(string cb_Id, string learn_Year, int learn_Term,GridView gv_StudentForUpdateScore)
        {
            gv_StudentForUpdateScore.DataSource = course.GetStForUpdateScore(cb_Id, learn_Year, learn_Term);
            gv_StudentForUpdateScore.DataBind();
        }
        #endregion

        #region ��ȡ��ʦ�Ͽ��б�
        public void  GetCourseList(string te_ID,GridView  gvList)
        {
            gvList.DataSource = course.GetCourseList(te_ID);
            gvList.DataBind();
        }
        #endregion

        #region ¼��ɼ�
        public string UpdateScore(GridView gv,string te_id)
        {
            string notSucessStList = string.Empty;
            foreach(GridViewRow gvr in gv.Rows)
            {
                if (course.UpdateScore(gvr.Cells[0].Text, gvr.Cells[1].Text.ToString(), Convert.ToSingle(gvr.Cells[2].Text.ToString()),te_id) == 0)
                {
                    notSucessStList = "yes";
                }
            }
            return notSucessStList;
        }
        #endregion

    }
}
