using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using StudentManager.BLL;

public partial class Student_OtherSPChooseCourse : System.Web.UI.Page
{
    #region 变量声明
    private Course course = new Course();
    private Department dept = new Department();
    private Speciality sp = new Speciality();
    private string dp_Id = string.Empty;
    private string sp_Id = string.Empty;
    private string learn_Year = string.Empty;
    private string learn_Term = string.Empty;
    private string st_id = HttpContext.Current.User.Identity.Name;
    private int ddlCollegeSelectIndex = 0;
    private string ddlCollegeSelectValue = "00";
    private int ddlspSelectIndex = -1;
    private string ddlspSelectValue = string.Empty;
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTime.Text = SetTitle();
        course.BindStudentInf(HttpContext.Current.User.Identity.Name, lblTitle, ref dp_Id, ref sp_Id);
        //course.BindClassChooseTb(dp_Id, sp_Id, learn_Year, Convert.ToInt32(learn_Term), gv_ChooseClassTb);
        dept.BindCollegeForDll(ddlCollege);
        ddlCollege.Items.RemoveAt(0);
        ddlCollege.SelectedIndex = ddlCollegeSelectIndex;
        sp.BindSpecialityList(ddlCollegeSelectValue, ddlSp);
        ddlSp.SelectedIndex = ddlspSelectIndex;
        course.BindClassChooseTb(ddlCollegeSelectValue, ddlspSelectValue, DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString(), ReturnTerm(), gv_ChooseClassTb);

    }
    #endregion

    #region 设置选课标题
    private string SetTitle()
    {
        learn_Year = DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString();
        string year = learn_Year + "学年";
        string month = string.Empty;
        if (DateTime.Now.Month < 6)
        {
            month = "  第1学期选课";
            learn_Term = "1";
        }
        else
        {
            month = "  第2学期选课";
            learn_Term = "2";
        }
        return year + month;
    }
    #endregion

    #region 获取选课状态
    public string GetChooseStstue()
    {
        if ((Eval("flag")).ToString().Trim() == "1")
        {
            return "已选";
        }
        else
        {
            return "未选";
        }
    }
    #endregion

    #region 设定按钮命令
    public string SetCommandText()
    {
        if ((Eval("flag")).ToString().Trim() == "1")
        {
            return "退选";
        }
        else
        {
            return "选定";
        }
    }
    #endregion

    #region 设定操作命令
    public string SetCommandName()
    {
        if ((Eval("flag")).ToString().Trim() == "1")
        {
            return "nochoose";
        }
        else
        {
            return "choose";
        }
    }
    #endregion

    #region 选课操作
    protected void lbtnOperate_Click(object sender, EventArgs e)
    {

    }
    #endregion

    #region 选课或退选
    protected void gv_ChooseClassTb_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        GridViewRow drv = ((GridViewRow)(((LinkButton)(e.CommandSource)).Parent.Parent));
        int rowIndex = drv.RowIndex;
        if (e.CommandName == "nochoose")
        {
            course.NotChooseCourse(st_id, Convert.ToInt32(e.CommandArgument.ToString()), DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString(), ReturnTerm());
        }
        if (e.CommandName == "choose")
        {
            course.ChooseCourse(st_id, Convert.ToInt32(e.CommandArgument.ToString()), DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString(), ReturnTerm(),gv_ChooseClassTb.DataKeys[rowIndex].Values[1].ToString());
        }
    }
    #endregion

    #region 返回学期
    private int ReturnTerm()
    {
        if (DateTime.Now.Month < 6)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
    #endregion
 
    protected void ddlCollege_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ddlCollege_DataBinding(object sender, EventArgs e)
    {
        ddlCollegeSelectIndex = ddlCollege.SelectedIndex;
        ddlCollegeSelectValue = ddlCollege.SelectedValue;
    }
    protected void viewCourse_Click(object sender, EventArgs e)
    {
        //course.BindClassChooseTb(ddlCollege.SelectedValue, ddlSp.SelectedValue, DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString(), ReturnTerm(), gv_ChooseClassTb);
        course.BindClassChooseTb(ddlCollegeSelectValue,ddlspSelectValue, DateTime.Now.AddYears(-1).Year.ToString() + "-" + DateTime.Now.Year.ToString(), ReturnTerm(), gv_ChooseClassTb);
    }
    protected void ddlSp_DataBinding(object sender, EventArgs e)
    {
        ddlspSelectIndex = ddlSp.SelectedIndex;
        ddlspSelectValue = ddlSp.SelectedValue;
    }
}
