

-- =============================================
-- Description:获取教师授课表
-- =============================================
create PROCEDURE  [dbo].[ViewTeachCourses]
(
 @Te_id  varchar(10)
)
AS
BEGIN
select * from vw_TeachCourses where te_id=@Te_id
END