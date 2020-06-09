<%@ Page Language="C#" MasterPageFile="~/Teacher/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="JoinScores.aspx.cs" Inherits="Teacher_JoinScores" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnDownLoadTempFile_onclick() {
window.open('DownLoadFile.aspx?fname=template.xls');
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; font-size:12px;
        width: 100%; padding-top: 1px; margin-top:15px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Teacher/Images/main_top_1.gif"
                    Width="21px" />成绩录入</td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="导出成绩模版" Visible="False" />&nbsp;
                <input id="btnDownLoadTempFile" type="button" value="下载成绩导入模版" onclick="return btnDownLoadTempFile_onclick()" />
                &nbsp;&nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp;<asp:FileUpload ID="FileUp" runat="server" Width="240px" />&nbsp;
                &nbsp;
                <asp:Button ID="btnPrivew" runat="server" OnClick="btnPrivew_Click" Text="查   看" />
                &nbsp; &nbsp;<asp:Button ID="BtnOKToImport" runat="server" OnClick="BtnOKToImport_Click" Text="确认导入"
                    Width="91px" /></td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                <asp:GridView ID="gCourses" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="st_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                    GridLines="None" PageSize="15" Width="100%">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EmptyDataRowStyle Height="20px" />
                    <Columns>
                        <asp:BoundField DataField="cb_id" HeaderText="课程编号" >
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="学生学号" DataField="st_id" >
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="sc_score" HeaderText="成      绩" >
                            <ItemStyle Width="80px" />
                        </asp:BoundField>
                        <asp:BoundField>
                            <ItemStyle Width="400px" />
                        </asp:BoundField>
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
                    <EditRowStyle BackColor="#2461BF" Height="20px" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="SkyBlue" Font-Bold="True" Font-Size="12px" ForeColor="White"
                        Height="12px" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" colspan="3" style="background-image: url(Images/bottom_bg.gif);
                width: 929px; height: 25px; text-align: right" valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
            </td>
        </tr>
    </table>
</asp:Content>

