<%@ Page Language="C#" MasterPageFile="~/Teacher/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="ViewStudentChoose.aspx.cs" Inherits="Teacher_ViewStudentChoose" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnReturn_onclick() {
history.go(-1);
}



// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%; margin-top:14px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                height: 13px">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Teacher/Images/main_top_1.gif"
                    Width="14px" />
                选课学生列表</td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 929px; border-bottom: #99ccff 0.1em solid;
                height: 435px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: 0px;
                    border-left: #99ccff 1px solid; width: 107%; margin-right: 0px; border-bottom: #99ccff 1px solid;
                    height: 180px">
                    <tr>
                        <td align="center" colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid;
                            border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 100%;
                            border-bottom: #99ccff 0.1em solid; height: 404px" valign="top">
                            <asp:GridView ID="gv_StudentTb" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                DataKeyNames="pc_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                                GridLines="None" PageSize="15" Width="100%">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EmptyDataRowStyle Height="20px" />
                                <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
                                <EditRowStyle BackColor="#2461BF" Height="20px" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="SkyBlue" Font-Bold="True" Font-Size="12px" ForeColor="White"
                                    Height="12px" />
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="st_id" HeaderText="学  号" />
                                    <asp:BoundField DataField="st_name" HeaderText="姓  名" />
                                    <asp:BoundField DataField="cl_name" HeaderText="班  级" />
                                    <asp:BoundField DataField="sp_name" HeaderText="专  业" />
                                    <asp:BoundField DataField="dp_name" HeaderText="学  院" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid; text-align: center">
                            <asp:Button ID="btnExportNames" runat="server" OnClick="btnExportNames_Click" Text="导出名单" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<input id="btnReturn"
                                type="button" value="返 回" onclick="return btnReturn_onclick()" /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                background-image: url(Images/bottom_bg.gif); border-left: #99ccff 0.1em solid;
                width: 100%; border-bottom: #99ccff 0.1em solid; height: 25px; text-align: right"
                valign="middle">
                power &nbsp;by yuhong
            </td>
        </tr>
    </table>
</asp:Content>

