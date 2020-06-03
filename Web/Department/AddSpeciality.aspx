<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddSpeciality.aspx.cs" Inherits="Department_AddSpeciality" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
window.location.replace("Default.aspx");
}

// ]]>
</script>

 <div style="width:100% ; margin-left:3px; margin-top:15px">
     <table style="width:100% ; height:100%; padding-top:1px; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px; width: 929px;">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />添加专业信息</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 430px; vertical-align: top; text-align: left; width: 929px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                <table style="width: 100%; height: 181px; margin-right:auto; margin-left :auto;border-left: 1 solid  #99ccff; border-right: 1 solid  #99ccff border-top: 1 solid  #99ccff; border-bottom: 1 solid  #99ccff; border:1 solid  #99ccff">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 21px;
                            text-align: center; color: #ff0000;">
                            建议专业编号标准:年级+学院编号+专业序号(如20040901)</td>
                    </tr>
                    <tr>
                        <td style="width: 93px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            专业编号:</td>
                        <td style="width: 150px; height: 21px ; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtSpecialityNumber" runat="server" MaxLength="20" Width="124px"></asp:TextBox></td>
                        <td style="width: 65px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            专业名称:</td>
                        <td style="width: 24px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtSpecialityName" runat="server" Width="192px"></asp:TextBox></td>
                        <td style="width: 74px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            所属学院:</td>
                        <td style="width: 33px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlCollege" runat="server" Width="167px">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 93px; height: 18px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            所属年级:</td>
                        <td colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 18px">
                            <asp:DropDownList ID="ddlGrade" runat="server" Width="128px">
                                <asp:ListItem Value="2004">2004级</asp:ListItem>
                                <asp:ListItem Value="2005">2005级</asp:ListItem>
                                <asp:ListItem Value="2006">2006级</asp:ListItem>
                                <asp:ListItem Value="2007">2007级</asp:ListItem>
                                <asp:ListItem Value="2008">2008级</asp:ListItem>
                            </asp:DropDownList>&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 93px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" valign="top">
                            备 注:</td>
                        <td style="height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" colspan="5">
                            <asp:TextBox ID="txtRemark" runat="server" Height="115px" Width="773px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="height: 36px; text-align: center; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:Button ID="btnAddStudent" runat="server" Text="添 加" OnClick="btnAddStudent_Click" />
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

