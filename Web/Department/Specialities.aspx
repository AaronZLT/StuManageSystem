<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Specialities.aspx.cs" Inherits="Department_Specialities" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top: 15px; margin-left: 3px; width: 100%">
        <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
            width: 100%; padding-top: 1px; height: 100%">
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="21px" />专业列表信息</td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                    所属学院：
                    <asp:DropDownList ID="ddlCollege" runat="server" Width="261px" AutoPostBack="True" OnDataBinding="ddlCollege_DataBinding">
                    </asp:DropDownList>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 所属年级：
                    <asp:DropDownList ID="ddlGrade" runat="server" Width="219px" AutoPostBack="True">                       
                        <asp:ListItem Value="0000">所有年级</asp:ListItem>
                        <asp:ListItem Value="2015">2015级</asp:ListItem>
                        <asp:ListItem Value="2016">2016级</asp:ListItem>
                        <asp:ListItem Value="2017">2017级</asp:ListItem>
                        <asp:ListItem Value="2018">2018级</asp:ListItem>
                        <asp:ListItem Value="2019">2019级</asp:ListItem>
                        <asp:ListItem Value="2020">2020级</asp:ListItem>
                        <asp:ListItem Value="2021">2021级</asp:ListItem>
                        <asp:ListItem Value="2022">2022级</asp:ListItem>
                        <asp:ListItem Value="2023">2023级</asp:ListItem>

                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                    <asp:GridView ID="gvSpecialityList" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        DataKeyNames="sp_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                        GridLines="None" PageSize="15" Width="100%">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EmptyDataRowStyle Height="20px" />
                        <Columns>
                            <asp:BoundField DataField="sp_id" HeaderText="专业编号" />
                            <asp:BoundField DataField="sp_name" HeaderText="专业名称" />
                            <asp:BoundField DataField="dp_name" HeaderText="所属学院" />
                            <asp:BoundField DataField="sp_grade" HeaderText="年       级" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbtnDelSp" runat="server" CommandArgument='<%#Eval("sp_id")%>'>删 除</asp:LinkButton>
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
                        <EmptyDataTemplate>
                            <asp:LinkButton ID="lbtnDelSp" runat="server" CommandArgument="sp_id">删 除</asp:LinkButton>
                        </EmptyDataTemplate>
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

