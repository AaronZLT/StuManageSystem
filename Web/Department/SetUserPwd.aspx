<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="SetUserPwd.aspx.cs" Inherits="Department_SetUserPwd" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function GoBacK_onclick() {
history.go(-1);
}

// ]]>
</script>

    <table class="tbAffiche" style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid;
        margin-top: 15px; border-left: #99ccff 1px solid; width: 100%; border-bottom: #99ccff 1px solid;
        height: 100%">
        <tr>
            <td colspan="2" style="background-image: url(Images/main_top_bg.gif); height: 15px;
                text-align: left" valign="top">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="21px" />密码重置</td>
        </tr>
        <tr>
            <td colspan="2" style="border-right: #99ccff 0px solid; border-top: #99ccff 0px solid;
                vertical-align: top; border-left: #99ccff 0px solid; border-bottom: #99ccff 0px solid;
                height: 435px; text-align: right">
                <table class="changePwd" style="border-right: #99ccff 0.05em solid; border-top: #99ccff 0.05em solid;
                    border-left: #99ccff 0.05em solid; width: 499px; border-bottom: #99ccff 0.05em solid;
                    height: 121px">
                    <tr>
                        <td colspan="2" style="height: 37px; text-align: center">
                            密码重置</td>
                    </tr>
                    <tr>
                        <td style="width: 195px; height: 25px; text-align: right">
                            修改对象:&nbsp;</td>
                        <td style="width: 278px; height: 25px; text-align: left">
                            <asp:DropDownList ID="ddlObject" runat="server" Width="145px">
                            </asp:DropDownList>&nbsp;</td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 195px; height: 25px; text-align: right">
                            编 &nbsp; &nbsp; &nbsp;&nbsp; 号:&nbsp;
                        </td>
                        <td style="width: 278px; height: 25px; text-align: left">
                            <asp:TextBox ID="txtNumber" runat="server" Width="140px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNumber"
                                ErrorMessage="*" Width="5px"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 195px; height: 25px; text-align: right">
                            新 密 码:&nbsp;
                        </td>
                        <td style="width: 278px; height: 25px; text-align: left">
                            <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNewPwd"
                                ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr style="color: #000000">
                        <td style="width: 195px; height: 25px; text-align: right">
                            新 密 码:&nbsp;</td>
                        <td style="width: 278px; height: 25px; text-align: left">
                            <asp:TextBox ID="txtReNewPwd" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtReNewPwd"
                                ErrorMessage="*"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr style="color: #000000">
                        <td colspan="2" style="height: 23px; text-align: center">
                            &nbsp; &nbsp; &nbsp;&nbsp;
                            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Width="177px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 25px; text-align: center">
                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="btnChangePwd" runat="server"
                                OnClick="btnChangePwd_Click" Text="修 改" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<input id="GoBacK"
                                type="button" value="返 回" onclick="return GoBacK_onclick()" />&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="background-image: url(Images/bottom_bg.gif); height: 23px;
                text-align: right">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
            </td>
        </tr>
    </table>
</asp:Content>

