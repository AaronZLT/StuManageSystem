<%@ Page Language="C#" MasterPageFile="~/Teacher/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="SelfInf.aspx.cs" Inherits="Teacher_SelfInf" Title="�ִ��������ϵͳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function Button1_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; margin-top: 15px; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 95%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 100%;
                height: 19px">
                <asp:Image ID="Image2" runat="server" Height="14px" ImageUrl="~/Teacher/Images/main_top_1.gif"
                    Width="20px" />��ʦ��ϸ��Ϣ</td>
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
                            ��ʦ��ţ�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTEID" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ��ʦ������</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="LblTeName" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeSex" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ѧ &nbsp; &nbsp; &nbsp; ����</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeXueli" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ְ &nbsp; &nbsp; &nbsp; �ƣ�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeZhicheng" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ��ѧרҵ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeSp" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; �壺</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeMinzu" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ��&nbsp; Դ ʡ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTePro" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; ����</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeTel" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ������ò��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblZZFace" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ���֤�ţ�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeIdentity" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ����ѧԺ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTeCollege" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            ס &nbsp; &nbsp; &nbsp; ַ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblTeAddress" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            �������£�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblTeBirthday" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            ��ְʱ�䣺</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblTeTime" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 249px" valign="top">
                            ��&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; ע��</td>
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
                                value="�� ��" onclick="return Button1_onclick()" /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                background-image: url(Images/bottom_bg.gif); border-left: #99ccff 0.1em solid;
                width: 929px; border-bottom: #99ccff 0.1em solid; height: 25px; text-align: right"
                valign="middle">
                power &nbsp;by JLU
            </td>
        </tr>
    </table>
</asp:Content>

