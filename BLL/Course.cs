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
    /// 课程业务逻辑层务层
    /// </summary>
    public class Course
    {
        #region 使用反射工厂多态实例化课程接口
        /// <summary>
        /// 使用反射工厂多态实例化课程接口
        /// </summary>
        private ICourse course = DataAccess.CreateCourse();
        #endregion

        #region 添加学院开课课程
        public void AddCourse(CourseInf courseInf,Label lblMessage)
        {
            int result= course.AddCourse(courseInf);
            switch (result)
            {
                case   1: lblMessage.Text = "添加课程成功!";
                    break;
                case  -1: lblMessage.Text = "课程号重复,请换其他课程号 ";
                    break;
                case   0: lblMessage.Text="添加课程失败!";
                    break;
            }
        }
        #endregion

        #region 添加专业选课
        public void AddChooseCourse(CourseInf courseInf, Label lblMessage)
        {
            int result = course.AddChooseCourse(courseInf);
            switch (result)
            {
                case 1: lblMessage.Text = "添加选课课程成功!";
                    break;
                case -1: lblMessage.Text = "该学院已经设置了修该课程";
                    break;
                case -2: lblMessage.Text = "同一时间上课教室冲突";
                    break;
                case -3: lblMessage.Text = "该老师在该时间要上其他课程";
                    break;
                case 0: lblMessage.Text = "添加选课课程失败!";
                    break;
            }
        }
        #endregion

        #region 绑定课程类型列表
        public void BindCourseType(DropDownList ddlCourseType)
        {
            ddlCourseType.DataSource = course.GetCourseTypeList();
            ddlCourseType.DataValueField = "ct_type";
            ddlCourseType.DataTextField = "ct_type";
            ddlCourseType.DataBind();
        }
        #endregion

        #region 梆定开课信息
        public void BindCourses(string dp_id,GridView gvCourse)
        {
            gvCourse.DataSource = course.GetCourses(dp_id);
            gvCourse.DataBind();
        }
        #endregion

        #region 绑定课程到下拉列表
        public void BindCoursList(DropDownList ddlCourseList)
        {
            ddlCourseList.DataSource = course.GetCourseList();
            ddlCourseList.DataTextField = "cb_name";
            ddlCourseList.DataValueField = "cb_id";
            ddlCourseList.DataBind();
        }
        #endregion

        #region 绑定上课教室到下拉列表
        public void BindCRList(DropDownList ddlCRList)
        {
            ddlCRList.DataSource = course.GetCRList();
            ddlCRList.DataTextField = "cr_id";
            ddlCRList.DataValueField = "cr_id";
            ddlCRList.DataBind();
        }
        #endregion

        #region 绑定上课教师到下拉列表
        public void BindTeacherList(string dp_id,DropDownList ddlTeacherList)
        {
            ddlTeacherList.DataSource = course.GetTeacherList(dp_id);
            ddlTeacherList.DataTextField = "te_name";
            ddlTeacherList.DataValueField = "te_id";
            ddlTeacherList.DataBind();
        }
        #endregion

        #region 在选课页面绑定学生信息
        public void BindStudentInf(string st_Id,Label lblMessage,ref string dp_id,ref string sp_id)
        {
            lblMessage.Text =course.GetStudentInf(st_Id, ref dp_id,ref sp_id);
        }
        #endregion

        #region 绑定选课课程列表
        public void BindClassChooseTb(string dp_Id, string sp_Id, string pc_Year, int pc_Term, GridView gvChooseCourse)
        {
            gvChooseCourse.DataSource = course.GetChooseClassTb(dp_Id, sp_Id, pc_Year, pc_Term);
            gvChooseCourse.DataBind();
        }
        #endregion

        #region 选课
        public void ChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm, string te_id)
        {
            int result=course.ChooseCourse(st_Id, pc_Id, LearnYear, LearnTerm,te_id);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("选课成功!", "ChooseCourse.aspx");
                    break;
                case -2: JScript.AlertAndRedirect("已经选了该课程了!", "ChooseCourse.aspx");
                    break;
                case -1: JScript.AlertAndRedirect("超出人数限制了!", "ChooseCourse.aspx");
                    break;
                case 0: JScript.AlertAndRedirect("选课失败!", "ChooseCourse.aspx");
                    break;
            }
        }
        #endregion

        #region 退选课
        public void NotChooseCourse(string st_Id, int pc_Id, string LearnYear, int LearnTerm)
        {
            int result = course.NotChooseCourse(st_Id, pc_Id, LearnYear, LearnTerm);
            switch (result)
            {
                case 1: JScript.AlertAndRedirect("退选成功!", "ChooseCourse.aspx");
                    break;
                case -1: JScript.AlertAndRedirect("退选失败!", "ChooseCourse.aspx");
                    break;
            }
        }
        #endregion

        #region 获取选课结果表
        public void GetChooseCourseTable(string st_Id, string pc_Year, int pc_Term,GridView gvChooseTable)
        {
            gvChooseTable.DataSource= course.GetChooseCourseTable(st_Id, pc_Year, pc_Term);
            gvChooseTable.DataBind();
        }
        #endregion

        #region 获取培养计划表
        public void GetPlanCourseTable(string st_Id,GridView gvPlanCourse)
        {
            gvPlanCourse.DataSource = course.GetPlanCourseTable(st_Id);
            gvPlanCourse.DataBind();
        }
        #endregion

        #region 获取成绩表
        public void GetScoreTable(string st_Id, string pc_Year, int pc_Term, GridView gvScoreTable)
        {        
            gvScoreTable.DataSource = course.QueryScore(st_Id, pc_Year,pc_Term);
            gvScoreTable.DataBind();
        }
        #endregion

        #region 查询教师授课表
        public void  TecherTeachCourses(string te_Id,GridView gvTeachCourses)
        {
            gvTeachCourses.DataSource = course.TecherTeachCourses(te_Id);
            gvTeachCourses.DataBind();
        }
        #endregion

        #region 获取选课学生列表
        public void ChooseStudentTb(string pc_Id,GridView gvStudents)
        {
            gvStudents.DataSource = course.ChooseStudentTb(pc_Id);
            gvStudents.DataBind();
        }
        #endregion

        #region 获取选课学生列表
        public void ChooseStudentTb(string pc_Id, GridView gvStudents,ref DataTable dt)
        {
            dt = course.ChooseStudentTb(pc_Id);
            gvStudents.DataSource = course.ChooseStudentTb(pc_Id);
            gvStudents.DataBind();
        }
        #endregion

        #region 绑定对应课程选课学生列表
        public void  BindStForUpdateScore(string cb_Id, string learn_Year, int learn_Term,GridView gv_StudentForUpdateScore)
        {
            gv_StudentForUpdateScore.DataSource = course.GetStForUpdateScore(cb_Id, learn_Year, learn_Term);
            gv_StudentForUpdateScore.DataBind();
        }
        #endregion

        #region 获取教师上课列表
        public void  GetCourseList(string te_ID,GridView  gvList)
        {
            gvList.DataSource = course.GetCourseList(te_ID);
            gvList.DataBind();
        }
        #endregion

        #region 录入成绩
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
