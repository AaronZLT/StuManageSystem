<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Classes.aspx.cs" Inherits="Department_Classes" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top: 15px; margin-left: 3px; width: 100%">
        <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
            width: 100%; padding-top: 1px; height: 100%">
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="21px" />班级列表信息</td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                    所属学院：
                    <asp:DropDownList ID="ddlCollege" runat="server" AutoPostBack="True" OnDataBinding="ddlCollege_DataBinding"
                        Width="174px">
                    </asp:DropDownList>
                    &nbsp; &nbsp;&nbsp; 所属专业：
                    <asp:DropDownList ID="ddlSpeciality" runat="server" AutoPostBack="True" OnDataBinding="ddlSpeciality_DataBinding"
                        Width="219px">
                    </asp:DropDownList>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                    <asp:GridView ID="gvClasses" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        DataKeyNames="cl_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                        GridLines="None" PageSize="15" Width="100%" OnRowCommand="gvClasses_RowCommand">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EmptyDataRowStyle Height="20px" />
                        <Columns>
                            <asp:BoundField DataField="cl_id" HeaderText="班级编号" />
                            <asp:BoundField DataField="cl_name" HeaderText="班级姓名" />
                            <asp:BoundField DataField="dp_name" HeaderText="学院名称" />
                            <asp:BoundField DataField="sp_name" HeaderText="专业名字" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnDeleteCL"　 CommandArgument='<%#Eval("cl_id")%>' runat="server">删 除</asp:LinkButton>
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
    </div>
</asp:Content>

