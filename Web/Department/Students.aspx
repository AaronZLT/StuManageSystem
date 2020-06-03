<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="Department_Students" Title="�ִ��������ϵͳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-top: 15px; margin-left: 3px; width: 100%">
        <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
            width: 100%; padding-top: 1px; height: 100%">
            <tr>
                <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                        Width="21px" />ѧ���б���Ϣ</td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 22px; text-align: center">
                    ����ѧԺ��
                    <asp:DropDownList ID="ddlCollege" runat="server" Width="174px" AutoPostBack="True" OnDataBinding="ddlCollege_DataBinding">
                    </asp:DropDownList>
                    &nbsp; &nbsp;&nbsp; ����רҵ��
                    <asp:DropDownList ID="ddlSpeciality" runat="server" Width="219px" AutoPostBack="True" OnDataBinding="ddlSpeciality_DataBinding">                       
                    </asp:DropDownList>
                    &nbsp; �����༶��<asp:DropDownList ID="ddlClassList" runat="server" Width="206px" AutoPostBack="True" OnDataBinding="ddlClassList_DataBinding">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="3" style="vertical-align: top; height: 430px; text-align: left">
                    <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="False" CellPadding="4"
                        DataKeyNames="st_id" Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                        GridLines="None" PageSize="15" Width="100%">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EmptyDataRowStyle Height="20px" />
                        <Columns>
                            <asp:BoundField DataField="st_id" HeaderText="ѧ       ��" />
                            <asp:BoundField DataField="st_name" HeaderText="��       ��" />
                            <asp:BoundField DataField="st_sex" HeaderText="��       ��" />
                            <asp:BoundField DataField="st_birthday" HeaderText="��������" />
                            <asp:BoundField DataField="st_face" HeaderText="������ò" />
                            <asp:BoundField DataField="st_tel" HeaderText="��ϵ�绰" />
                            <asp:BoundField DataField="sp_name" HeaderText="����רҵ" />
                            <asp:BoundField DataField="cl_name" HeaderText="�����༶" />
                            <asp:BoundField DataField="dp_name" HeaderText="����ѧԺ" />
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

