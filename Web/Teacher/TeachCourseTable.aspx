<%@ Page Language="C#" MasterPageFile="~/Teacher/TeacherMasterPage.master" AutoEventWireup="true" CodeFile="TeachCourseTable.aspx.cs" Inherits="Teacher_TeachCourseTable" Title="现代教务管理系统" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function btnReturn_onclick() {
location.replace('Default.aspx');
}

// ]]>
</script>

<TABLE style="BORDER-RIGHT: #99ccff 0.1em solid; BORDER-LEFT: #99ccff 0.1em solid; WIDTH: 100%; margin-top:15px; HEIGHT: 100%"><TBODY><TR><TD 
style="BACKGROUND-IMAGE: url(Images/main_top_bg.gif); WIDTH: 929px; HEIGHT: 13px" 
colSpan="3"><asp:Image id="Image1" runat="server" Height="14px" Width="14px" ImageUrl="~/Teacher/Images/main_top_1.gif"></asp:Image> 教师授课表</TD></TR><TR><TD 
style="BORDER-RIGHT: #99ccff 0.1em solid; BORDER-TOP: #99ccff 0.1em solid; VERTICAL-ALIGN: top; BORDER-LEFT: #99ccff 0.1em solid; WIDTH: 929px; BORDER-BOTTOM: #99ccff 0.1em solid; HEIGHT: 434px; TEXT-ALIGN: left" 
colSpan=3><TABLE style="BORDER-RIGHT: #99ccff 1px solid; BORDER-TOP: #99ccff 1px solid; MARGIN-LEFT: 0px; BORDER-LEFT: #99ccff 1px solid; WIDTH: 107%; MARGIN-RIGHT: 0px; BORDER-BOTTOM: #99ccff 1px solid; HEIGHT: 180px"><TBODY><TR><TD 
style="BORDER-RIGHT: #99ccff 0.1em solid; BORDER-TOP: #99ccff 0.1em solid; BORDER-LEFT: #99ccff 0.1em solid; WIDTH: 100%; BORDER-BOTTOM: #99ccff 0.1em solid; HEIGHT: 413px" 
vAlign=top align=center colSpan=6 rowSpan=2>
<asp:GridView id="gv_TeachCoures" runat="server" Width="100%" DataKeyNames="pc_id"  PageSize="15" Font-Names="tahoma,arial" Font-Size="13px" AutoGenerateColumns="False" GridLines="None" ForeColor="#333333" CellPadding="4" OnRowCommand="gv_TeachCoures_RowCommand">
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"  />
                                <EmptyDataRowStyle Height="20px"  />
                                <RowStyle BackColor="#EFF3FB" Font-Size="12px"  />
                                <EditRowStyle BackColor="#2461BF" Height="20px"  />
                                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"  />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center"  />
                                <HeaderStyle BackColor="SkyBlue" Font-Bold="True" ForeColor="White" Font-Size="12px" Height="12px"  />
                                <AlternatingRowStyle BackColor="White"  />
                                <Columns>
                                    <asp:BoundField DataField="cb_id" HeaderText="课程代码" ></asp:BoundField>
                                    <asp:BoundField DataField="cb_name" HeaderText="课程名称" ></asp:BoundField>
                                    <asp:BoundField DataField="cb_credithour" HeaderText="学  时" ></asp:BoundField>
                                    <asp:BoundField DataField="ct_type" HeaderText="课程类型" ></asp:BoundField>
                                    <asp:BoundField DataField="pc_personcount" HeaderText="限选人数" ></asp:BoundField>
                                    <asp:BoundField DataField="pc_year" HeaderText="学  年" />
                                    <asp:BoundField DataField="pc_term" HeaderText="学 期" />
                                    <asp:BoundField DataField="pc_weeks" HeaderText="上课周数" />
                                    <asp:BoundField DataField="pc_classtime" HeaderText="上课时间" />
                                    <asp:BoundField DataField="pc_personcount" HeaderText="限选人数" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbtnViewStudents" runat="server"  CommandArgument='<%#Eval("pc_id")%>'>查看选课学生</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView> </TD></TR><TR></TR><TR><TD 
style="BORDER-RIGHT: #99ccff 0.1em solid; BORDER-TOP: #99ccff 0.1em solid; BORDER-LEFT: #99ccff 0.1em solid; WIDTH: 100%; BORDER-BOTTOM: #99ccff 0.1em solid; TEXT-ALIGN: center; height: 18px;" 
colSpan=6>
                                <input id="btnReturn" type="button" value="返 回" onclick="return btnReturn_onclick()" />&nbsp;</TD></TR></TBODY></TABLE></TD></TR><TR><TD 
style="BORDER-RIGHT: #99ccff 0.1em solid; BORDER-TOP: #99ccff 0.1em solid; BACKGROUND-IMAGE: url(Images/bottom_bg.gif); BORDER-LEFT: #99ccff 0.1em solid; WIDTH: 100%; BORDER-BOTTOM: #99ccff 0.1em solid; HEIGHT: 25px; TEXT-ALIGN: right" 
vAlign=middle align=right colSpan=3>   
                                    <%--
                        power &nbsp;by  &nbsp;&nbsp;
                        --%>       
 </TD></TR></TBODY></TABLE>
</asp:Content>

