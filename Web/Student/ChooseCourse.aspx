<%@ Page Language="C#" MasterPageFile="~/Student/StudentMasterPage.master" AutoEventWireup="true" CodeFile="ChooseCourse.aspx.cs" Inherits="Student_ChooseCourse" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
location.replace('Default.aspx');
}



function otherSpChoose_onclick() {
location.replace('OtherSPChooseCourse.aspx');
}

// ]]>
</script>

    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%;  margin-top:-3px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                height: 13px">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Student/Images/main_top_1.gif"
                    Width="14px" />
                学生选课<asp:Label ID="lblTime" runat="server" Text="Label" Width="466px"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 929px; border-bottom: #99ccff 0.1em solid;
                height: 349px; text-align: left">
                <table style="border-right: #99ccff 1px solid; border-top: #99ccff 1px solid;
                    border-left: #99ccff 1px solid;  border-bottom: #99ccff 1px solid; margin-left:0px; margin-right:0px;
                    height: 180px; width:107%">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;
                            height: 21px; text-align: left; width: 100%;">
                            <asp:Label ID="lblTitle" runat="server" Text="Label" Width="658px"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 299px; width: 100%;" align="center" valign="top">
                            <asp:GridView ID="gv_ChooseClassTb" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                                Width="100%" AutoGenerateColumns="False" Font-Size="13px" Font-Names="tahoma,arial" PageSize="15" OnRowCommand="gv_ChooseClassTb_RowCommand"  DataKeyNames="pc_id,te_id">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EmptyDataRowStyle Height="20px" />
                                <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
                                <EditRowStyle BackColor="#2461BF" Height="20px" />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <HeaderStyle BackColor="SkyBlue" Font-Bold="True" ForeColor="White" Font-Size="12px" Height="12px" />
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="cb_id" HeaderText="课程代码" />
                                    <asp:BoundField DataField="cb_name" HeaderText="课程名称" />
                                    <asp:BoundField DataField="cb_credithour" HeaderText="学时" />
                                    <asp:BoundField DataField="ct_type" HeaderText="课程类型" />
                                    <asp:BoundField DataField="te_name" HeaderText="上课老师" />
                                    <asp:BoundField DataField="pc_classtime" HeaderText="上课时间" />
                                    <asp:BoundField DataField="pc_personcount" HeaderText="限选人数" />
                                    <asp:TemplateField HeaderText="状  态">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# GetChooseStstue()%>'></asp:Label>&nbsp;
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbtnOperate" runat="server" CommandArgument='<%#Eval("pc_id")%>' Text='<%# SetCommandText()%>' CommandName='<%# SetCommandName()%>'  OnClick="lbtnOperate_Click"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 33px;
                            text-align: center; width: 100%;">
                            <input id="ourSpChoose" type="button" value="本专业选课" onserverclick="ourSpChoose_ServerClick" />
                            &nbsp; &nbsp; &nbsp;&nbsp;
                            <input id="otherSpChoose" type="button" value="跨专业选课" onserverclick="otherSpChoose_ServerClick" onclick="return otherSpChoose_onclick()" />&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<input id="btnCancel"  type="button" value="退出选课" onclick="return btnCancel_onclick()" /></td>
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

