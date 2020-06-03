using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using StudentManager.Model;

namespace StudentManager.IDAL
{
    #region 课程接口
    public interface ICourse
    {
        #region 添加开课课程
        int AddCourse(CourseInf courseInf);
        #endregion 

        #region 获取课程类型列表
        DataTable GetCourseTypeList();
        #endregion

        #region 获取学院开课信息
        DataTable GetCourses(string dp_id);
        #endregion

        #region 获取课程下拉列表
        DataTable GetCourseList();
        #endregion

        #region 获取上课教室下拉列表
        DataTable GetCRList();
        #endregion

        #region 获取上课教师下拉列表
        DataTable GetTeacherList(string dp_id);
        #endregion

        #region 添加选课课程
        int AddChooseCourse(CourseInf courseInf);
        #endregion

        #region 获取学生个人信息
        string GetStudentInf(string st_Id,ref  string dp_id,ref  string sp_id);
        #endregion

        #region 获取学生选课课表
        DataTable GetChooseClassTb(string dp_Id, string sp_Id, string pc_Year, int pc_Term);
        #endregion

        #region 选课
        int ChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm, string te_id);
        #endregion 
                
        #region 退选课
        int NotChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm);
        #endregion 

        #region 获取选课结果表
        DataTable GetChooseCourseTable(string st_Id, string pc_Year, int pc_Term);
        #endregion

        #region 获取培养计划表
        DataTable GetPlanCourseTable(string st_Id);
        #endregion

        #region 查询成绩表
        DataTable QueryScore(string st_Id, string pc_Year, int pc_Term);
        #endregion

        #region 查询教师授课表
        DataTable TecherTeachCourses(string te_Id);
        #endregion

        #region 获取选课学生列表
        DataTable ChooseStudentTb(string  pc_Id);
        #endregion

        #region 获取对应课程选课学生列表
        DataTable GetStForUpdateScore(string cb_Id, string learn_Year, int learn_Term);
        #endregion

        #region 获取教师上课列表
        DataTable GetCourseList(string te_ID);
        #endregion

        #region 录入成绩
        int UpdateScore(string cb_id, string st_id, float score,string te_id);
        #endregion
    }
    #endregion
}
