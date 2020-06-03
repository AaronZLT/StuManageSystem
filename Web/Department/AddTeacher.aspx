<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddTeacher.aspx.cs" Inherits="Department_AddTeacher" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
window.location.replace('Default.aspx');
}

// ]]>
</script>

 <div style="width:100% ; margin-left:3px; margin-top:15px">
     <table style="width:100% ; height:100%; padding-top:1px; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px; width: 929px;">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />添加老师信息</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 430px; vertical-align: top; text-align: left; width: 929px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                <table style="width:100%; height: 180px; margin-right:auto; margin-left :auto;border-left: 1 solid  #99ccff; border-right: 1 solid  #99ccff border-top: 1 solid  #99ccff; border-bottom: 1 solid  #99ccff; border:1 solid  #99ccff">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; color: #ff0000; border-bottom: #99ccff 0.1em solid;
                            height: 21px; text-align: center">
                            建议教师编号标准:入职年份+学院编号+教师序号(如20050901)</td>
                    </tr>
                    <tr>
                        <td style="width: 204px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            教师编号:</td>
                        <td style="width: 162px; height: 21px ; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtTeacherNumber" runat="server"></asp:TextBox></td>
                        <td style="width: 86px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            教师姓名:</td>
                        <td style="width: 41px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtTeacherName" runat="server"></asp:TextBox></td>
                        <td style="width: 78px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            性 &nbsp; &nbsp;&nbsp; 别:</td>
                        <td style="width: 33px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlSex" runat="server" Width="153px">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 204px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            所属学院:</td>
                        <td style="width: 162px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlDepartment" runat="server" Width="154px">
                            </asp:DropDownList></td>
                        <td style="width: 86px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            出生日期:</td>
                        <td style="width: 41px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox></td>
                        <td style="width: 78px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            学 &nbsp; &nbsp;&nbsp; 历:</td>
                        <td style="width: 33px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlXueLi" runat="server" Width="153px">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 204px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            职 &nbsp; &nbsp;&nbsp; 称:</td>
                        <td style="width: 162px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlZhiCheng" runat="server" Width="153px">
                            </asp:DropDownList></td>
                        <td style="width: 86px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            身份证号:</td>
                        <td style="width: 41px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtIdentity" runat="server"></asp:TextBox></td>
                        <td style="width: 78px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            毕业专业:</td>
                        <td style="width: 33px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtSpeciality" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 204px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            政治面貌:</td>
                        <td style="width: 162px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlFace" runat="server" Width="153px">
                            </asp:DropDownList></td>
                        <td style="width: 86px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            任教时间:</td>
                        <td style="width: 41px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtWorkTime" runat="server"></asp:TextBox></td>
                        <td style="width: 78px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            联系电话:</td>
                        <td style="width: 33px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 204px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            民 &nbsp; &nbsp; &nbsp;族:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 162px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            <asp:DropDownList ID="ddlMingZu" runat="server" Width="154px">
                            </asp:DropDownList></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 86px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            来 源 省:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 41px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            <asp:DropDownList ID="ddlProvince" runat="server" Width="153px" AutoPostBack="True">
                                <asp:ListItem>四川</asp:ListItem>
                            </asp:DropDownList></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            家庭地址:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 33px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 204px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 162px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 86px; border-bottom: #99ccff 0.1em solid; height: 2px">
                            </td>
                        <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 2px">
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
                        <td colspan="6" style="height: 36px; text-align: center; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:Button ID="btnAddTeacher" runat="server" Text="添 加" OnClick="btnAddTeacher_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            &nbsp;<input id="btnCancel" type="button" value="返 回" onclick="return btnCancel_onclick()" /></td>
                    </tr>
                </table>

            </td>
        </tr>
        <tr>
            <td colspan="3" style="background-image: url(Images/bottom_bg.gif); height: 25px; width: 929px; text-align: right;; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" align="right" valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
        </tr>
    </table>
    </div>
</asp:Content>

