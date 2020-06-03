<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddCollege.aspx.cs" Inherits="Department_AddCollege" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
window.location.replace('Default.aspx');
}

// ]]>
</script>


     <table style="width:100% ; height:95%; padding-top:1px; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; margin-top:15px;">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px; width: 100%;">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />添加学院信息</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 430px; vertical-align: top; text-align: left; width: 100%; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                <table style="width: 100%; height: 180px; margin-right:auto; margin-left :auto;border-left: 1 solid  #99ccff; border-right: 1 solid  #99ccff ; border-bottom: 1 solid  #99ccff; border:1 solid  #99ccff">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 26px;
                            text-align: center; color: #ff0000;">
                            建议学院编号为两位数字(如09)</td>
                    </tr>
                    <tr>
                        <td style="width: 155px; height: 17px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            学院编号:</td>
                        <td style="width: 36px; height: 17px ; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtCollegeNumber" runat="server"  Width="141px"></asp:TextBox>
                            </td>
                        <td style="width: 68px; height: 17px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            学院名称:</td>
                        <td style="width: 16px; height: 17px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtCollegeName" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        <td style="width: 67px; height: 17px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            系统密码:</td>
                        <td style="width: 30px; height: 17px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtSysPwd" runat="server" TextMode="Password" Width="131px"></asp:TextBox>
                            </td>
                    </tr>
                    <tr>
                        <td style="width: 155px; height: 18px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            地 &nbsp; &nbsp;&nbsp; 址:</td>
                        <td style="width: 36px; height: 18px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtAddress" runat="server" Width="141px"></asp:TextBox>
                            </td>
                        <td style="width: 68px; height: 18px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            联系电话:</td>
                        <td style="height: 18px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" colspan="3">
                            <asp:TextBox ID="txtTel" runat="server" Width="171px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 155px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" valign="top">
                            备 &nbsp; &nbsp;&nbsp; 注:</td>
                        <td style="height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" colspan="5">
                            <asp:TextBox ID="txtRemark" runat="server" Height="180px" Width="843px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="height: 38px; text-align: center; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:Button ID="btnAddStudent" runat="server" Text="添 加" OnClick="btnAddStudent_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            &nbsp;<input id="btnCancel" type="button" value="返 回" onclick="return btnCancel_onclick()" causesvalidation="false" /></td>
                    </tr>
                </table>

            </td>
        </tr>
        <tr>
            <td colspan="3" style="background-image: url(Images/bottom_bg.gif); height: 25px; width: 929px; text-align: right;; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" align="right" valign="middle">
                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
        </tr>
    </table>
<%--    </div>--%>
</asp:Content>

