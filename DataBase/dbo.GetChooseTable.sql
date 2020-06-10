







-- =============================================
-- Description:获取学生选课课表
-- =============================================
CREATE PROCEDURE  [dbo].[GetChooseTable]
(
  @Dp_id char(2),
  @Sp_id char(20),
  @Pc_year char(10),
  @Pc_term int
)
AS
BEGIN
select * from vw_CourseChooseInf ,teacher where vw_CourseChooseInf.dp_id=@Dp_id and vw_CourseChooseInf.sp_id=@Sp_id and vw_CourseChooseInf.pc_year=@Pc_year and vw_CourseChooseInf.pc_term=@Pc_term  and teacher.te_id=vw_CourseChooseInf.te_id
end