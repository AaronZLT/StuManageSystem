<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Teachers.aspx.cs" Inherits="Department_Teachers" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div style="width:100% ; margin-left:3px; margin-top:15px;">
    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="21px" />教师列表信息</td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                所属学院：
                <asp:DropDownList ID="ddlCollege" runat="server" AutoPostBack="True" OnDataBinding="ddlCollege_DataBinding"
                    Width="174px">
                </asp:DropDownList>&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                <asp:GridView ID="gvTeachers" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="te_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                    GridLines="None" PageSize="15" Width="100%">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EmptyDataRowStyle Height="20px" />
                    <Columns>
                        <asp:BoundField DataField="te_id" HeaderText="教师编号" />
                        <asp:BoundField DataField="te_name" HeaderText="教师姓名" />
                        <asp:BoundField DataField="te_sex" HeaderText="性      别" />
                        <asp:BoundField DataField="te_speciality" HeaderText="所学专业" />
                        <asp:BoundField DataField="lg_name" HeaderText="学      历" />
                        <asp:BoundField DataField="zc_name" HeaderText="职       称" />
                        <asp:BoundField DataField="te_zzface" HeaderText="政治面貌" />
                        <asp:BoundField DataField="dp_name" HeaderText=" 学         院" />
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

