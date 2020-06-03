<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Colleges.aspx.cs" Inherits="Department_Collegesaspx" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top: 15px; margin-left: 3px; width: 100%">
        <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
            width: 100%; padding-top: 1px; height: 100%">
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="21px" />学院列表信息</td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                    <asp:GridView ID="gvColleges" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        DataKeyNames="dp_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                        GridLines="None"                       
                        PageSize="15" Width="100%" OnRowCommand="gvColleges_RowCommand">
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
                            <asp:BoundField />
                            <asp:BoundField />
                            <asp:BoundField DataField="dp_id" HeaderText="学院编号" />
                            <asp:BoundField DataField="dp_name" HeaderText="学院名字" />
                            <asp:BoundField DataField="dp_address" HeaderText="学院地址" />
                            <asp:BoundField DataField="dp_tel" HeaderText="学院电话" />
                            <asp:BoundField />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnDelete" CommandArgument='<%#Eval("dp_id")%>' runat="server">删 除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
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
    </div>
</asp:Content>

