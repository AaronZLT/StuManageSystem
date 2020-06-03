<%@ Page Language="C#" MasterPageFile="~/Department/DepartmentMasterPage.master" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="Department_AddStudent" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnCancel_onclick() {
window.location.replace('Default.aspx');
}

// ]]>
</script>

 <div style="width:100% ; margin-left:3px; margin-top:15px">
     <table style="width:100% ; height:100%; padding-top:1px; border-right: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); height: 19px; width: 929px;">
                <asp:Image ID="Image1" runat="server" Height="14px" ImageUrl="~/Department/Images/main_top_1.gif"
                    Width="22px" />添加学生信息</td>
        </tr>
        <tr>
            <td colspan="3" style="height: 430px; vertical-align: top; text-align: left; width: 929px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                <table style="width: 100%; height: 180px; margin-right:auto; margin-left :auto;border-left: 1 solid  #99ccff; border-right: 1 solid  #99ccff border-top:  1 solid  #99ccff; border-bottom: 1 solid  #99ccff; border:1 solid  #99ccff">
                    <tr>
                        <td colspan="6" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; color: #ff0000; border-bottom: #99ccff 0.1em solid;
                            height: 21px; text-align: center">
                            建议学号标准:年级+学院编号+专业编号+班级编号+学生序号(如200409010525)</td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            所属学院:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 25px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            <asp:DropDownList ID="ddlCollegeList" runat="server" Width="154px" AutoPostBack="True" OnDataBinding="ddlCollegeList_DataBinding" >
                                <asp:ListItem Value="00">所有学院</asp:ListItem>
                            </asp:DropDownList></td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 76px; border-bottom: #99ccff 0.1em solid; height: 21px">
                            所属专业:</td>
                        <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                            border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 21px; color: #ff0000;">
                            <asp:DropDownList ID="ddlSpeciality" runat="server" Width="358px" AutoPostBack="True" OnDataBinding="ddlSpeciality_DataBinding" OnSelectedIndexChanged="ddlSpeciality_SelectedIndexChanged" >
                            </asp:DropDownList>请先选择所属学院</td>
                    </tr>
                    <tr>
                        <td style="width: 78px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            学 &nbsp; &nbsp;&nbsp; 号:</td>
                        <td style="width: 25px; height: 21px ; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtStudentNumber" runat="server"></asp:TextBox></td>
                        <td style="width: 76px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            姓 &nbsp; &nbsp; &nbsp;名:</td>
                        <td style="width: 20px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox></td>
                        <td style="width: 94px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            性 &nbsp; &nbsp;&nbsp; 别:</td>
                        <td style="width: 33px; height: 21px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlSex" runat="server" Width="155px">
                                <asp:ListItem>男</asp:ListItem>
                                <asp:ListItem>女</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 78px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            所属班级:</td>
                        <td style="width: 25px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlClass" runat="server" Width="155px">
                            </asp:DropDownList></td>
                        <td style="width: 76px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            出生日期:</td>
                        <td style="width: 20px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox></td>
                        <td style="width: 94px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            身份证号:</td>
                        <td style="width: 33px; height: 15px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtIdentity" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 78px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            联系电话:</td>
                        <td style="width: 25px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox></td>
                        <td style="width: 76px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            政治面貌:</td>
                        <td style="width: 20px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlStuFace" runat="server" Width="154px">
                            </asp:DropDownList></td>
                        <td style="width: 94px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            民 &nbsp; &nbsp;&nbsp; 族:</td>
                        <td style="width: 33px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlMingZu" runat="server" Width="155px">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td style="width: 78px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            来 源 省:</td>
                        <td style="width: 25px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:DropDownList ID="ddlProvince" runat="server" Width="155px">
                            </asp:DropDownList></td>
                        <td style="width: 76px; height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            家庭地址:</td>
                        <td style="height: 2px; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;" colspan="3">
                            <asp:TextBox ID="txtHomeAddress" runat="server" Width="147px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 78px; border-bottom: #99ccff 0.1em solid; height: 2px" valign="top">
                            备 &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; 注:</td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid; height: 2px" colspan="5">
                            <asp:TextBox ID="txtRemark" runat="server" Height="218px" Width="787px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" rowspan="2" style=" border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="6" style="height: 36px; text-align: center; border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid; border-bottom: #99ccff 0.1em solid;">
                            <asp:Button ID="btnAddStudent" runat="server" Text="添 加" OnClick="btnAddStudent_Click" />
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            &nbsp;<input id="btnCancel" type="button" value="返 回" onclick="return btnCancel_onclick()" /></td>
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
    </div>
</asp:Content>

