<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="Department_Courses" Title="�������ϵͳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div style="width:100% ; margin-left:3px; margin-top:15px;"> 
    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="21px" />�б���Ϣ</td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                ����ѧԺ��
                <asp:DropDownList ID="ddlCollege" runat="server" AutoPostBack="True" OnDataBinding="ddlCollege_DataBinding"
                    Width="261px" >
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                <asp:GridView ID="gCourses" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="cb_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                    GridLines="None" PageSize="15" Width="100%" OnRowCommand="gCourses_RowCommand">
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EmptyDataRowStyle Height="20px" />
                    <Columns>
                        <asp:BoundField DataField="cb_id" HeaderText="�γ̱��" />
                        <asp:BoundField DataField="cb_name" HeaderText="�γ�����" />
                        <asp:BoundField DataField="cb_credithour" HeaderText="ѧ    ��" />
                        <asp:BoundField DataField="ct_type" HeaderText="��         ��" />
                        <asp:BoundField DataField="cb_time" HeaderText="ѧ       ʱ" />
                        <asp:BoundField DataField="cb_ispublic" HeaderText="������Ŀ" />
                        <asp:BoundField DataField="dp_name" HeaderText="����ѧԺ" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbtnDeleteCourse" CommandArgument='<%#Eval("cb_id") %>' runat="server">ɾ ��</asp:LinkButton>
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

