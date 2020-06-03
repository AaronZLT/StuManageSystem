<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddCourse.aspx.cs" Inherits="Department_AddCourse" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
location.replace("Default.aspx");
}

// ]]>
</script>
 <div style="width:100% ; margin-left:3px; margin-top:15px;">
    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                height: 19px">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />添加学院开课课程</td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 929px; border-bottom: #99ccff 0.1em solid;
                height: 430px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: auto;
                    border-left: #99ccff 1px solid; width: 100%; margin-right: auto; border-bottom: #99ccff 1px solid;
                    height: 180px">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; color: #ff0000; border-bottom: #99ccff 0.1em solid;
                            height: 21px; text-align: center">
                            <asp:Label ID="lblMessage" runat="server" Height="19px" Width="473px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            课程编号:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 25px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            <asp:TextBox ID="txtCourseNumber" runat="server"></asp:TextBox></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 93px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            开课学院:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 22px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            <asp:DropDownList ID="ddlCollege" runat="server" Width="155px">
                            </asp:DropDownList></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 74px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            课程名称:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 33px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            课程学分:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 25px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            <asp:TextBox ID="txtXueFen" runat="server"></asp:TextBox></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 93px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            课程类型:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 22px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            <asp:DropDownList ID="ddlCourseType" runat="server" Width="155px">
                            </asp:DropDownList></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 74px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            学 &nbsp; &nbsp; &nbsp; 时:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 33px; border-bottom: #99ccff 0.1em solid; height: 15px">
                            <asp:TextBox ID="txtCourseTime" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            是否公共:</td>
                        <td colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 2px">
                            <asp:DropDownList ID="ddlIsPublic" runat="server" Width="155px">
                                <asp:ListItem Value="否">否</asp:ListItem>
                                <asp:ListItem Value="是">是</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 2px" valign="top">
                            备 &nbsp; &nbsp; &nbsp; 注:</td>
                        <td colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 2px">
                            <asp:TextBox ID="txtCourseRemark" runat="server" Height="218px" Width="768px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid">
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 36px;
                            text-align: center">
                            <asp:Button ID="btnAddStudent" runat="server" Text="添 加" OnClick="btnAddStudent_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            &nbsp;<input id="btnCancel" type="button" value="返 回" onclick="return btnCancel_onclick()" /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                background-image: url(Images/bottom_bg.gif); border-left: #99ccff 0.1em solid;
                width: 929px; border-bottom: #99ccff 0.1em solid; height: 25px; text-align: right"
                valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
            </td>
        </tr>
    </table>
    </div>
</asp:Content>

