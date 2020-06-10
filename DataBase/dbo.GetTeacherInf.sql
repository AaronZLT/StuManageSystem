






-- =============================================
-- Description:获取学生信息
-- =============================================
create PROCEDURE  [dbo].[GetTeacherInf]
(
  @Te_id char(10)
)
AS
BEGIN
select * from vw_teachers where te_id =@Te_id
END