<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddAffiche.aspx.cs" Inherits="Department_AddAffiche" Title="现代教务管理系统" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script language="javascript" type="text/javascript">
// <!CDATA[

function Submit1_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>
 <table  class="tbAffiche" style="width: 100%; height: 106%; border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; border-left: #99ccff 1px solid; border-bottom: #99ccff 1px solid; vertical-align: top; margin-top:16px;" >
            <tr>
                <td style="height: 15px; background-image: url(Images/main_top_bg.gif); text-align: left;" colspan="2" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="13px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="21px" />公告信息</td>
            </tr>
            <tr>
                <td style="width: 72px;  text-align: right; border-bottom: #99ccff 0.1em solid; height: 24px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
                    公告标题:</td>
                <td style="border-bottom: #99ccff 0.1em solid; height: 24px; border-top: #99ccff 0.1em solid; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 676px;">
             
                    <asp:TextBox ID="txtAfficheTitle" runat="server" Width="342px" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAfficheTitle"
                        ErrorMessage="*"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 72px; height: 285px; vertical-align: top; text-align: right; border-right: #99ccff 0.05ex solid; border-top: #99ccff 0.05ex solid; border-left: #99ccff 0.05ex solid; border-bottom: #99ccff 0.05ex solid;">
                    公告内容:</td>
                <td style="height: 285px; vertical-align: top; text-align: left; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; width: 676px;">
                    <asp:TextBox ID="txtAfficheContent" runat="server" Height="253px" Width="877px" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAfficheContent"
                        ErrorMessage="*" Display="Dynamic" Width="9px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 72px; text-align: right; height: 20px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                    有效时间:</td>
                <td style="height: 20px; width: 676px; border-right: #99ccff 0.05em solid; border-top: #99ccff 0.05em solid; border-left: #99ccff 0.05em solid; border-bottom: #99ccff 0.05em solid;">
                    <asp:TextBox ID="txtEnbaleTime" runat="server" Width="132px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEnbaleTime"
                        ErrorMessage="*"></asp:RequiredFieldValidator>
                    例:2008-04-01</td>
            </tr>
            <tr>
                <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                    width: 72px; border-bottom: #99ccff 0.1em solid; height: 17px; text-align: right">
                    相关文件:</td>
                <td style="width: 676px; height: 17px; border-right: #99ccff 0.05ex solid; border-top: #99ccff 0.05ex solid; border-left: #99ccff 0.05ex solid; border-bottom: #99ccff 0.05ex solid;">
                    <asp:FileUpload ID="fluAfficheFile" runat="server" Width="313px" /></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                    border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 18px;
                    text-align: center">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                    border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 29px;
                    text-align: center">
                    <asp:Button ID="btnAddAffiche" runat="server" Text="添 加" OnClick="btnAddAffiche_Click" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<input id="Submit1" type="button" value="返 回" onclick="return Submit1_onclick()" causesvalidation="false" /></td>
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

