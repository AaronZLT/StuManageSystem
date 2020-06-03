<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Department_Default" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width: 100%; margin-left:3px; margin-top:15px;  ">
     <table style="width: 100%; height:100%; padding-top:1px; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px;">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="21px" />公告列表</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 400px; vertical-align: top; text-align: left; ">
              <asp:GridView ID="gdvAffiche" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            Width="100%" AutoGenerateColumns="False" Font-Size="13px" Font-Names="tahoma,arial" PageSize="15" OnRowDeleted="gdvAffiche_RowDeleted" OnSelectedIndexChanged="gdvAffiche_SelectedIndexChanged" DataKeyNames="af_id" OnRowDeleting="gdvAffiche_RowDeleting" OnSelectedIndexChanging="gdvAffiche_SelectedIndexChanging">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EmptyDataRowStyle Height="20px" />
            <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
            <EditRowStyle BackColor="#2461BF" Height="20px" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="SkyBlue" Font-Bold="True" ForeColor="White" Font-Size="12px" Height="12px" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:HyperLinkField HeaderText="公告标题" DataTextField="af_title" DataNavigateUrlFields="af_id" DataNavigateUrlFormatString="AfficheDetails.aspx?id={0}" Target="_blank" />
                <asp:BoundField HeaderText="发布部门" DataField="dp_name" >
                    <ItemStyle Width="12%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="发布时间" DataField="af_time" DataFormatString="{0:yyyy/MM/dd}" HtmlEncode="False" >
                    <ItemStyle Width="8%" />
                </asp:BoundField>
                <asp:BoundField HeaderText="有效期" DataField="af_enabletime" DataFormatString="{0:yyyy/MM/dd}" HtmlEncode="False" >
                    <ItemStyle Width="8%" />
                </asp:BoundField>
                <asp:CommandField DeleteText="删    除 " EditText="edit" ShowDeleteButton="True"  >
                    <ItemStyle Width="4%" ForeColor="RoyalBlue" />
                </asp:CommandField>
                <asp:TemplateField>
                    <ItemTemplate>
                         <a href='<%# "UpdateAffiche.aspx?af_id="+Eval("af_id")%> '>修改</a>
                    </ItemTemplate>
                    <ItemStyle Width="4%" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="background-image: url(Images/bottom_bg.gif); height: 25px; width: 929px; text-align: right;" align="right" valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
        </tr>
    </table>
    </div>
</asp:Content>

