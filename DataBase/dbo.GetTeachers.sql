



-- =============================================
-- Description:获取教师列表信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetTeachers]
(
 @Dp_name varchar(20)
)
AS
if @Dp_name=''
set @Dp_name='%'

BEGIN
select * from dbo.vw_TeacherList where   dp_name like @Dp_name
END