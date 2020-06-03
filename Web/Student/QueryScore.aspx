<%@ Page Language="C#" MasterPageFile="~/Student/StudentMasterPage.master" AutoEventWireup="true" CodeFile="QueryScore.aspx.cs" Inherits="Student_QueryScore" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; font-size:12px;
        width: 100%;  margin-top:14px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                height: 13px">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Student/Images/main_top_1.gif"
                    Width="14px" />
                学生成绩查询<asp:Label ID="lblTitle" runat="server" Text="Label" Width="658px"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 929px; border-bottom: #99ccff 0.1em solid;
                height: 435px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid; margin-left: 0px;
                    border-left: #99ccff 1px solid; width: 107%; margin-right: 0px; border-bottom: #99ccff 1px solid;
                    height: 180px">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid;
                            height: 21px; text-align: left">
                            <asp:DropDownList ID="ddlLearnYear" runat="server" Width="85px">
                                <asp:ListItem>2004-2005</asp:ListItem>
                                <asp:ListItem>2005-2006</asp:ListItem>
                                <asp:ListItem>2006-2007</asp:ListItem>
                                <asp:ListItem>2007-2008</asp:ListItem>
                                <asp:ListItem>2008-2009</asp:ListItem>
                                <asp:ListItem>2009-2010</asp:ListItem>
                            </asp:DropDownList>
                            学年
                            <asp:DropDownList ID="ddlLearnTerm" runat="server" 
                                Width="78px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                            </asp:DropDownList>学期&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click"
                                Text="查 看" />
                            &nbsp; &nbsp; &nbsp;
                            <asp:Button ID="btnviewAll" runat="server" OnClick="btnviewAll_Click" Text="查看在校所有成绩" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid;
                            border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 100%;
                            border-bottom: #99ccff 0.1em solid; height: 359px" valign="top">
                            <asp:GridView ID="gv_ScoreTable" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333" GridLines="None"
                                 PageSize="15" Width="100%">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EmptyDataRowStyle Height="20px" />
                                <Columns>
                                    <asp:BoundField DataField="cb_id" HeaderText="课程代码" />
                                    <asp:BoundField DataField="cb_name" HeaderText="课程名称" />
                                    <asp:BoundField DataField="sc_score" HeaderText="成 绩" />
                                    <asp:BoundField DataField="cb_credithour" HeaderText="学 分" />
                                    <asp:BoundField DataField="ct_type" HeaderText="课程类型" />
                                    <asp:BoundField DataField="sc_year" HeaderText="学  年" />
                                    <asp:BoundField DataField="sc_term" HeaderText="学  期" />
                                    <asp:BoundField DataField="relearnflag" HeaderText="重修标记" />
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
                            border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid; text-align: center">
                            <input id="btnCancel"
                                    type="button" value="返 回" onclick="return btnCancel_onclick()" /></td>
                    </tr>
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
    </table>
</asp:Content>

