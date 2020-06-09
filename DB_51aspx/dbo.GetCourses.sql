





-- =============================================
-- Description:获取学院所有开课
-- =============================================
CREATE PROCEDURE  [dbo].[GetCourses]
(
@Dp_id char(2)
)
AS
BEGIN
if @Dp_id='00'
begin
select * from  vw_Courses
end
else
begin
select * from vw_Courses  where dp_id=@Dp_id
end
END