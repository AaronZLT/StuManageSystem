










-- =============================================
-- Description:学生选课结果
-- =============================================
create  PROCEDURE  [dbo].[ChooseCourseTable]
(
  @St_id varchar(20),
  @Pc_year char(10),
  @Pc_term int
) 
AS
BEGIN
if(@Pc_year='all'and @Pc_term=0)
begin
select * from vw_ChooseTable where st_id=@St_id
end
else
begin
select * from vw_ChooseTable where st_id=@St_id and  learn_year=@Pc_year and learn_term=@Pc_term
end
END