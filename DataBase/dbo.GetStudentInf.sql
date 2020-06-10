








-- =============================================
-- Description:获取教师信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetStudentInf]
(
  @St_id varchar(20)
)
AS
BEGIN
select * from vw_Students where st_id =@St_id
END