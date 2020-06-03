<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AfficheInf.aspx.cs" Inherits="Student_AfficheInf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>现代教务管理系统</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border-right: #ccff99 0px solid; border-top: #ccff99 0px solid; border-left: #ccff99 0px solid; padding-left:auto; padding-right:auto;
            border-bottom: #ccff99 0px solid; height: 359px; width: 955px;">
            <tr>
                <td colspan="3" style="height: 257px">
                    &nbsp;<asp:DetailsView ID="AffDetails" runat="server" AutoGenerateRows="False" Width="1000px" Caption="公告信息" CaptionAlign="Top" BorderWidth="0px" HorizontalAlign="Center" >
                        <Fields>
                            <asp:BoundField DataField="af_title" HeaderText="公告标题:">
                                <ControlStyle Width="100%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="af_content" HeaderText="公告内容:">
                                <ControlStyle Width="90%" />
                            </asp:BoundField>                         
                            <asp:TemplateField HeaderText="相关文件:">
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
                                公告信息</td>
                            <td style="height: 40px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px">
                                公告标题:</td>
                            <td>
                            </td>
                            <td>
                             <%#Eval("af_content")%>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px; height: 173px">
                                公告内容:</td>
                            <td style="height: 173px">
                            </td>
                            
                            <td style="height: 173px">
                            <%#Eval("af_content")%>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 86px">
                                相关文件:</td>
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
