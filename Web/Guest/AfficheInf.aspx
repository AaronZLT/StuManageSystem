<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AfficheInf.aspx.cs" Inherits="Student_AfficheInf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>�ִ��������ϵͳ</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border-right: #ccff99 0px solid; border-top: #ccff99 0px solid; border-left: #ccff99 0px solid; padding-left:auto; padding-right:auto;
            border-bottom: #ccff99 0px solid; height: 359px; width: 955px;">
            <tr>
                <td colspan="3" style="height: 257px">
                    &nbsp;<asp:DetailsView ID="AffDetails" runat="server" AutoGenerateRows="False" Width="1000px" Caption="������Ϣ" CaptionAlign="Top" BorderWidth="0px" HorizontalAlign="Center" >
                        <Fields>
                            <asp:BoundField DataField="af_title" HeaderText="�������:">
                                <ControlStyle Width="100%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="af_content" HeaderText="��������:">
                                <ControlStyle Width="90%" />
                            </asp:BoundField>                         
                            <asp:TemplateField HeaderText="����ļ�:">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnFileName" runat="server" Text="<%#GetFileName()%>"  OnClick="lbtnFileName_Click" Width="181px"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Fields>
                        <RowStyle Width="800px" />

                    </asp:DetailsView>
                    <table style="width: 1000px; height: 122px">
                        <tr>
                            <td style="width: 86px; height: 40px">
                            </td>
                            <td style="height: 40px; text-align: center">
                                ������Ϣ</td>
                            <td style="height: 40px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px">
                                �������:</td>
                            <td>
                            </td>
                            <td>
                             <%#Eval("af_content")%>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px; height: 173px">
                                ��������:</td>
                            <td style="height: 173px">
                            </td>
                            
                            <td style="height: 173px">
                            <%#Eval("af_content")%>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px">
                                ����ļ�:</td>
                            <td>
                                <asp:LinkButton ID="lbtnAdFile" Text="<%#GetFileName()%>" runat="server"></asp:LinkButton></td>
                            <td>
                            </td>
                        </tr>
                    </table>
                    </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 10px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
