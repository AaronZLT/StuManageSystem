<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="SetChooseCourse.aspx.cs" Inherits="Department_SetChooseCourse" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function GoBacK_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>

    <table class="tbAffiche" style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid;
        margin-top: 15px; border-left: #99ccff 1px solid; width: 100%; border-bottom: #99ccff 1px solid;
        height: 100%">
        <tr>
            <td colspan="2" style="background-image: url(Images/main_top_bg.gif); height: 15px;
                text-align: left; width: 948px;" valign="top">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="19px" />添加选课计划</td>
        </tr>
        <tr>
            <td colspan="2" style="border-right: #99ccff 0px solid; border-top: #99ccff 0px solid;
                vertical-align: top; border-left: #99ccff 0px solid; border-bottom: #99ccff 0px solid;
                height: 430px; text-align: right; width: 948px;">
                <table class="changePwd" style="border-right: #99ccff 0.05em solid; border-top: #99ccff 0.05em solid;
                    border-left: #99ccff 0.05em solid; width: 848px; border-bottom: #99ccff 0.05em solid;
                    height: 328px">
                    <tr>
                        <td colspan="6" style="height: 9px; text-align: center; border-bottom: #0099ff 0.1ex solid;">
                            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Height="22px" Width="471px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="width: 297px; height: 20px; text-align: right">
                            课程名称:</td>
                        <td style="width: 278px; height: 20px; text-align: left">
                            <asp:DropDownList ID="ddlCourseList" runat="server" Width="152px">
                            </asp:DropDownList></td>
                        <td style="width: 140px; height: 20px; text-align: left">
                            上课教室:</td>
                        <td style="width: 278px; height: 20px; text-align: left">
                            <asp:DropDownList ID="ddlClassRoomList" runat="server" Width="174px">
                            </asp:DropDownList></td>
                        <td style="width: 168px; height: 20px; text-align: left">
                            上课时间:</td>
                        <td style="width: 278px; height: 20px; text-align: left">
                            <asp:DropDownList ID="ddlDay" runat="server" Width="65px">
                                <asp:ListItem>星期一</asp:ListItem>
                                <asp:ListItem>星期二</asp:ListItem>
                                <asp:ListItem>星期三</asp:ListItem>
                                <asp:ListItem>星期四</asp:ListItem>
                                <asp:ListItem>星期五</asp:ListItem>
                                <asp:ListItem>星期六</asp:ListItem>
                                <asp:ListItem>星期天</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp; &nbsp;-&nbsp;&nbsp;
                            <asp:DropDownList ID="ddlTurn" runat="server">
                                <asp:ListItem>1-2节</asp:ListItem>
                                <asp:ListItem>2-4节</asp:ListItem>
                                <asp:ListItem>5-6节</asp:ListItem>
                                <asp:ListItem>7-8节</asp:ListItem>
                                <asp:ListItem>9-11节</asp:ListItem>
                                <asp:ListItem>9-12节</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 297px; height: 20px; text-align: right">
                            上课教师:
                        </td>
                        <td style="width: 278px; height: 20px; text-align: left">
                            <asp:DropDownList ID="ddlTeacherList" runat="server" Width="151px">
                            </asp:DropDownList></td>
                        <td style="width: 140px; height: 20px; text-align: left">
                            上课学年:</td>
                        <td style="width: 278px; height: 20px; text-align: left">
                            <asp:DropDownList ID="ddlLearnYear" runat="server" Width="85px">
                                <asp:ListItem>2004-2005</asp:ListItem>
                                <asp:ListItem>2005-2006</asp:ListItem>
                                <asp:ListItem>2006-2007</asp:ListItem>
                                <asp:ListItem>2007-2008</asp:ListItem>
                                <asp:ListItem>2008-2009</asp:ListItem>
                                <asp:ListItem>2009-2010</asp:ListItem>
                            </asp:DropDownList>
                            学年
                            <asp:DropDownList ID="ddlLearnTerm" runat="server" Width="34px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                            </asp:DropDownList>学期</td>
                        <td style="width: 168px; height: 20px; text-align: left">
                            上课时间:</td>
                        <td style="width: 278px; height: 20px; text-align: left"><asp:DropDownList ID="ddlWeektoo" runat="server" Width="65px">
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem>星期一</asp:ListItem>
                            <asp:ListItem>星期二</asp:ListItem>
                            <asp:ListItem>星期三</asp:ListItem>
                            <asp:ListItem>星期四</asp:ListItem>
                            <asp:ListItem>星期五</asp:ListItem>
                            <asp:ListItem>星期六</asp:ListItem>
                            <asp:ListItem>星期天</asp:ListItem>
                        </asp:DropDownList>
                            &nbsp; &nbsp;- &nbsp;
                            <asp:DropDownList ID="ddlDaytoo" runat="server">
                                <asp:ListItem Value="  "> </asp:ListItem>
                                <asp:ListItem>1-2节</asp:ListItem>
                                <asp:ListItem>2-4节</asp:ListItem>
                                <asp:ListItem>5-6节</asp:ListItem>
                                <asp:ListItem>7-8节</asp:ListItem>
                                <asp:ListItem>9-11节</asp:ListItem>
                                <asp:ListItem>9-12节</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 297px; height: 13px; text-align: right">
                            限选人数:</td>
                        <td style="width: 278px; height: 13px; text-align: left">
                            <asp:DropDownList ID="ddlPersonCount" runat="server" Width="150px">
                                <asp:ListItem>50</asp:ListItem>
                                <asp:ListItem>100</asp:ListItem>
                                <asp:ListItem>120</asp:ListItem>
                                <asp:ListItem>150</asp:ListItem>
                                <asp:ListItem>200</asp:ListItem>
                                <asp:ListItem>250</asp:ListItem>
                                <asp:ListItem Value="300"></asp:ListItem>
                            </asp:DropDownList></td>
                        <td style="width: 140px; height: 13px; text-align: left">
                            上课周数:</td>
                        <td style="width: 278px; height: 13px; text-align: left">
                            <asp:DropDownList ID="ddlStartWeek" runat="server" Width="84px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem Value="7">7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                            </asp:DropDownList>
                            -
                            <asp:DropDownList ID="ddlEndWeek" runat="server" Width="80px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem Value="7">7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>11</asp:ListItem>
                                <asp:ListItem>12</asp:ListItem>
                                <asp:ListItem>13</asp:ListItem>
                                <asp:ListItem>14</asp:ListItem>
                                <asp:ListItem>15</asp:ListItem>
                                <asp:ListItem>16</asp:ListItem>
                                <asp:ListItem>17</asp:ListItem>
                                <asp:ListItem>18</asp:ListItem>
                                <asp:ListItem>19</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>21</asp:ListItem>
                                <asp:ListItem>22</asp:ListItem>
                            </asp:DropDownList></td>
                        <td style="width: 168px; height: 13px; text-align: left">
                            上课专业:</td>
                        <td style="width: 278px; height: 13px; text-align: left">
                        <asp:DropDownList ID="ddlSpeciality" runat="server" Width="154px">
                        </asp:DropDownList></td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 297px; height: 24px; text-align: right" valign="top">
                            备 &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; 注:&nbsp;</td>
                        <td align="left" colspan="5" style="height: 24px; text-align: left" valign="top">
                            <asp:TextBox ID="txtRemark" runat="server" Height="120px" Width="721px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="height: 14px; text-align: center">
                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnAddChooseCourse" runat="server"
                                Text="添 加" OnClick="btnAddChooseCourse_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<input id="GoBacK"
                                type="button" value="返 回" onclick="return GoBacK_onclick()" />&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="background-image: url(Images/bottom_bg.gif); height: 23px;
                text-align: right; width: 948px;">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
            </td>
        </tr>
    </table>
</asp:Content>

