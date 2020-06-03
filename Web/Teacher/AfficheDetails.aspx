<%@ Page Language="C#" MasterPageFile="~/Teacher/MasterPage.master" AutoEventWireup="true" CodeFile="AfficheDetails.aspx.cs" Inherits="Guest_AfficheDetails" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table  class="tbAffiche" style="width: 100%; height: 100%; border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; border-left: #99ccff 1px solid; border-bottom: #99ccff 1px solid;font-family:Arial;color: #000000;font-size: 12px;" >
            <tr>
                <td style="height: 15px; background-image: url(Images/main_top_bg.gif); text-align: left;" colspan="2" valign="top">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Teacher/Images/main_top_1.gif"
                        Width="21px" />公告信息</td>
            </tr>
            <tr>
                <td style="width: 58px;  text-align: right; border-bottom: #99ccff 0.1em solid; height: 24px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
                    公告标题:</td>
                <td style="border-bottom: #99ccff 0.1em solid; height: 24px; border-top: #99ccff 0.1em solid; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 676px;">
                 <% =dr["af_title"]%>
                </td>
            </tr>
            <tr>
                <td style="width: 58px; height: 409px; vertical-align: top; text-align: right; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                    公告内容:</td>
                <td style="height: 409px; vertical-align: top; text-align: left; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; width: 676px;">
                <% =dr["af_content"]%>
                </td>
            </tr>
            <tr>
                <td style="width: 58px; text-align: right; height: 29px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                    相关文件:</td>
                <td style="height: 29px; width: 676px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                <a href="DownLoadFile.aspx?fname=<%=dr["af_filepath"].ToString().Substring(16) %>"><%=dr["af_filepath"].ToString().Substring(16) %></a>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="background-image: url(Images/bottom_bg.gif); height: 23px;
                    text-align: right">
                    power &nbsp;by JLU &nbsp;&nbsp;
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>

