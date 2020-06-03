<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="Department_AddClass" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
window.location.replace('Default.aspx');
}

// ]]>
</script>

    <div style="margin-top: 15px; margin-left: 3px; width: 100%; height: 545px;">
        <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
            width: 100%; padding-top: 1px; height: 100%">
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                    height: 19px">
                    <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="22px" />添加班级信息</td>
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
                                border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 21px;
                                text-align: center; color: #ff0000;">
                                建议班级编号标准:年级+学院编号+专业编号+班级序号(如2004090105)</td>
                        </tr>
                        <tr>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 204px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                班级编号:</td>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 151px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                <asp:TextBox ID="txtClassID" runat="server"></asp:TextBox>
                                </td>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 86px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                所属专业::</td>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 41px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                <asp:DropDownList ID="ddlSpeciality" runat="server" Width="153px">
                                </asp:DropDownList></td>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 78px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                班级名称:</td>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 33px; border-bottom: #99ccff 0.1em solid; height: 21px">
                                <asp:TextBox ID="txtClassName" runat="server"></asp:TextBox>
                                </td>
                        </tr>
                        <tr>
                            <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                                width: 204px; border-bottom: #99ccff 0.1em solid; height: 2px" valign="top">
                            备 &nbsp; &nbsp;&nbsp; 注:</td>
                            <td colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                                border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 2px">
                                <asp:TextBox ID="txtRemark" runat="server" Height="170px" Width="806px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                                border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 36px;
                                text-align: center">
                                <asp:Button ID="btnAddClass" runat="server" OnClick="btnAddTeacher_Click" Text="添 加" />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                &nbsp;<input id="btnCancel"  type="button" value="返 回" onclick="return btnCancel_onclick()" causesvalidation="false" /></td>
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

