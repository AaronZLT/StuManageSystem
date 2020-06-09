


-- =============================================
-- Description:获取对应学院教师列表
-- =============================================
CREATE PROCEDURE  [dbo].[GetTeacherList]
@Dp_id char(2)
AS
BEGIN
if( @Dp_id='01')
select te_id ,te_name from teacher
else
select te_id ,te_name from teacher where dp_id=@Dp_id
END