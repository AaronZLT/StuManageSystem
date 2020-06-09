<%@ Page Language="C#" MasterPageFile="~/Teacher/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeachList.aspx.cs" Inherits="Teacher_TeachList" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnReturn_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; margin-top: 15px; border-left: #99ccff 0.1em solid;
        width: 100%; height: 100%">
        <tbody>
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                    height: 13px">
                    <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Teacher/Images/main_top_1.gif"
                        Width="14px" />
                    教师授课表</td>
            </tr>
            <tr>
                <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                    vertical-align: top; border-left: #99ccff 0.1em solid; width: 929px; border-bottom: #99ccff 0.1em solid;
                    height: 434px; text-align: left">
                    <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: 0px;
                        border-left: #99ccff 1px solid; width: 107%; margin-right: 0px; border-bottom: #99ccff 1px solid;
                        height: 180px">
                        <tbody>
                            <tr>
                                <td align="center" colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid;
                                    border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 100%;
                                    border-bottom: #99ccff 0.1em solid; height: 413px" valign="top">
                                    <asp:GridView ID="gv_TeachList" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                        DataKeyNames="cb_id,pc_year,pc_term" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                                        GridLines="None" OnRowCommand="gv_TeachCoures_RowCommand" PageSize="15" Width="100%">
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <EmptyDataRowStyle Height="20px" />
                                        <Columns>
                                            <asp:BoundField DataField="cb_id" HeaderText="课程代码" />
                                            <asp:BoundField DataField="cb_name" HeaderText="课程名称" />
                                            <asp:BoundField DataField="pc_year" HeaderText="学  年" />
                                            <asp:BoundField DataField="pc_term" HeaderText="学 期" />
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbtnViewStudents" runat="server" CommandArgument='<%#Eval("pc_id")%>'>成绩录入</asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
                                        <EditRowStyle BackColor="#2461BF" Height="20px" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <HeaderStyle BackColor="SkyBlue" Font-Bold="True" Font-Size="12px" ForeColor="White"
                                            Height="12px" />
                                        <AlternatingRowStyle BackColor="White" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                            </tr>
                            <tr>
                                <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                                    border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid;
                                    height: 18px; text-align: center">
                                    <input id="btnReturn" type="button" value="返 回" onclick="return btnReturn_onclick()" />
                                    &nbsp; &nbsp;&nbsp;</td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                    background-image: url(Images/bottom_bg.gif); border-left: #99ccff 0.1em solid;
                    width: 100%; border-bottom: #99ccff 0.1em solid; height: 25px; text-align: right"
                    valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

