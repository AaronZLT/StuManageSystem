<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="SelfInf.aspx.cs" Inherits="Department_SelfInf" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
location.replace("Default.aspx");
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; margin-top: 15px; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 95%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 100%;
                height: 19px">
                <asp:Image ID="Image2" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />学院信息</td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid;
                height: 406px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: auto;
                    border-left: #99ccff 1px solid; width: 100%; margin-right: auto; border-bottom: #99ccff 1px solid;
                    height: 180px">
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 163px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            学院编号：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 25px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblDeptID" runat="server"  Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            学院名称：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="LblDeptName" runat="server" Width="212px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 58px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            地址：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblDeptAddress" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 163px; border-bottom: #99ccff 0.1em solid; height: 18px">
                            联系电话：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 18px" colspan="5">
                            <asp:Label ID="lblDeptTel" runat="server" Width="496px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 163px; border-bottom: #99ccff 0.1em solid; height: 258px" valign="top">
                            备 &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; 注：</td>
                        <td colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 258px" align="left" valign="top">
                            <asp:TextBox ID="txtRemark" runat="server" Height="323px" TextMode="MultiLine" Width="825px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 17px;
                            text-align: center">
                            <input id="Button1" causesvalidation="false" 
                                type="button" value="返 回" onclick="return Button1_onclick()" /></td>
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
</asp:Content>

