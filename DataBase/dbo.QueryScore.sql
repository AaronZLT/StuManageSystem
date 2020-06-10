











-- =============================================
-- Description:学生成绩查询
CREATE  PROCEDURE  [dbo].[QueryScore]
(
  @St_id char(20),
  @Pc_year char(10),
  @Pc_term int
) 
AS
BEGIN
if(@Pc_year='all'and @Pc_term=0)
begin
select * from vw_Score where st_id=@St_id
end
else
begin
select * from vw_Score where st_id = @St_id and sc_year=@Pc_year and sc_term=@Pc_term
end
END