<%@ Page Language="C#" MasterPageFile="~/Student/StudentMasterPage.master" AutoEventWireup="true" CodeFile="SelfInf.aspx.cs" Inherits="Student_SelfInf" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="border-right: #99ccff 0.1em solid; margin-top: 15px; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 95%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 100%;
                height: 15px">
                <asp:Image ID="Image2" runat="server" Height="14px" ImageUrl="~/Student/Images/main_top_1.gif"
                    Width="20px" />学生详细信息</td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid;
                height: 430px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: auto;
                    border-left: #99ccff 1px solid; width: 100%; margin-right: auto; border-bottom: #99ccff 1px solid;
                    height: 180px">
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            学生学号：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblId" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            学生姓名：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="LblName" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            性 &nbsp; &nbsp; &nbsp; 别：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblSex" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            出身年月：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblBirthday" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            民 &nbsp; &nbsp; &nbsp; 族：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMinZu" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                身份证号：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblIdentity" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            电 &nbsp; &nbsp; &nbsp; 话：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTel" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            来&nbsp; 源 省：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblPro" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            政治面貌：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblFace" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            家庭地址：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblAddress" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            所属班级：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblClass" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            所属专业：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblSp" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            年 &nbsp; &nbsp; &nbsp; 级：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblGrade" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            所在学院：</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblCollege" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 16px">
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 16px">
                        </td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 249px" valign="top">
                            备&nbsp; &nbsp; &nbsp;&nbsp; 注：</td>
                        <td align="left" colspan="5" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 249px"
                            valign="top">
                            <asp:TextBox ID="txtRemark" runat="server" Height="246px" TextMode="MultiLine" Width="825px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 38px;
                            text-align: center">
                            <input id="Button1" causesvalidation="false" type="button"
                                value="返 回" onclick="return Button1_onclick()" /></td>
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
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>
					
</asp:Content>

