using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    #region �γ̽ӿ�
    public interface ICourse
    {
        #region ��ӿ��ογ�
        int AddCourse(CourseInf courseInf);
        #endregion 

        #region ��ȡ�γ������б�
        DataTable GetCourseTypeList();
        #endregion

        #region ��ȡѧԺ������Ϣ
        DataTable GetCourses(string dp_id);
        #endregion

        #region ��ȡ�γ������б�
        DataTable GetCourseList();
        #endregion

        #region ��ȡ�Ͽν��������б�
        DataTable GetCRList();
        #endregion

        #region ��ȡ�Ͽν�ʦ�����б�
        DataTable GetTeacherList(string dp_id);
        #endregion

        #region ���ѡ�ογ�
        int AddChooseCourse(CourseInf courseInf);
        #endregion

        #region ��ȡѧ��������Ϣ
        string GetStudentInf(string st_Id,ref  string dp_id,ref  string sp_id);
        #endregion

        #region ��ȡѧ��ѡ�οα�
        DataTable GetChooseClassTb(string dp_Id, string sp_Id, string pc_Year, int pc_Term);
        #endregion

        #region ѡ��
        int ChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm, string te_id);
        #endregion 
                
        #region ��ѡ��
        int NotChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm);
        #endregion 

        #region ��ȡѡ�ν����
        DataTable GetChooseCourseTable(string st_Id, string pc_Year, int pc_Term);
        #endregion

        #region ��ȡ�����ƻ���
        DataTable GetPlanCourseTable(string st_Id);
        #endregion

        #region ��ѯ�ɼ���
        DataTable QueryScore(string st_Id, string pc_Year, int pc_Term);
        #endregion

        #region ��ѯ��ʦ�ڿα�
        DataTable TecherTeachCourses(string te_Id);
        #endregion

        #region ��ȡѡ��ѧ���б�
        DataTable ChooseStudentTb(string  pc_Id);
        #endregion

        #region ��ȡ��Ӧ�γ�ѡ��ѧ���б�
        DataTable GetStForUpdateScore(string cb_Id, string learn_Year, int learn_Term);
        #endregion

        #region ��ȡ��ʦ�Ͽ��б�
        DataTable GetCourseList(string te_ID);
        #endregion

        #region ¼��ɼ�
        int UpdateScore(string cb_id, string st_id, float score,string te_id);
        #endregion
    }
    #endregion
}
