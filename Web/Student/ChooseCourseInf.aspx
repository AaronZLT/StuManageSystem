<%@ Page Language="C#" MasterPageFile="~/Student/StudentMasterPage.master" AutoEventWireup="true" CodeFile="ChooseCourseInf.aspx.cs" Inherits="Student_ChooseCourseInf" Title="�ִ��������ϵͳ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
        width: 100%; padding-top: 1px; height: 100%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 929px;
                height: 13px">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Student/Images/main_top_1.gif"
                    Width="14px" />
                ѧ��ѡ�ν����Ϣ &nbsp;
                            <asp:Label ID="lblTitle" runat="server" Width="658px"></asp:Label></td>
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
                            ѧ��
                            <asp:DropDownList ID="ddlLearnTerm" runat="server" OnSelectedIndexChanged="ddlLearnTerm_SelectedIndexChanged"
                                Width="78px">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                            </asp:DropDownList>ѧ��&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click"
                                Text="�� ��" />
                            &nbsp; &nbsp; &nbsp;
                            <asp:Button ID="btnviewAll" runat="server" OnClick="btnviewAll_Click" Text="�鿴������ѡ�γ�" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="6" rowspan="2" style="border-right: #99ccff 0.1em solid;
                            border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; width: 100%;
                            border-bottom: #99ccff 0.1em solid; height: 402px" valign="top">
                            <asp:GridView ID="gv_ChooseClassTb" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                 Font-Names="tahoma,arial" Font-Size="13px" ForeColor="#333333"
                                GridLines="None"  PageSize="15" Width="100%">
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
                                    <asp:BoundField DataField="cb_id" HeaderText="�γ̴���" />
                                    <asp:BoundField DataField="cb_name" HeaderText="�γ�����" />
                                    <asp:BoundField DataField="cb_credithour" HeaderText="ѧʱ" />
                                    <asp:BoundField DataField="ct_type" HeaderText="�γ�����" />        
                                    <asp:BoundField DataField="cb_ispublic" HeaderText="�Ƿ񹫹���Ŀ" />
                                    <asp:BoundField DataField="learn_year" HeaderText="ѧ ��" />
                                    <asp:BoundField DataField="learn_term" HeaderText="ѧ ��" />
                                    <asp:BoundField DataField="dp_name" HeaderText="����ѧԺ" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid; text-align: center; height: 28px;">
                            <input id="btnCancel" onclick="return btnCancel_onclick()" type="button" value="��  ��" /></td>
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

