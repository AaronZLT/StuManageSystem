<%@ Page Language="C#" MasterPageFile="~/Student/StudentMasterPage.master" AutoEventWireup="true" CodeFile="SelfInf.aspx.cs" Inherits="Student_SelfInf" Title="�ִ��������ϵͳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="border-right: #99ccff 0.1em solid; margin-top: 15px; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 95%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 100%;
                height: 15px">
                <asp:Image ID="Image2" runat="server" Height="14px" ImageUrl="~/Student/Images/main_top_1.gif"
                    Width="20px" />ѧ����ϸ��Ϣ</td>
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
                            ѧ��ѧ�ţ�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblId" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ѧ��������</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="LblName" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblSex" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �������£�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblBirthday" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; �壺</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMinZu" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                ���֤�ţ�</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblIdentity" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �� &nbsp; &nbsp; &nbsp; ����</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblTel" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ��&nbsp; Դ ʡ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblPro" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ������ò��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblFace" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ��ͥ��ַ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblAddress" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            �����༶��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblClass" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 96px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            ����רҵ��</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblSp" runat="server" Width="187px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 80px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            �� &nbsp; &nbsp; &nbsp; ����</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            <asp:Label ID="lblGrade" runat="server" Width="158px"></asp:Label></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 91px; border-bottom: #99ccff 0.1em solid; height: 16px">
                            ����ѧԺ��</td>
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
                            ��&nbsp; &nbsp; &nbsp;&nbsp; ע��</td>
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
                power &nbsp;by yuhong
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

