




-- =============================================
-- Description:获取课程列表
-- =============================================
CREATE PROCEDURE  [dbo].[GetCourseList]
AS
BEGIN
select cb_id,cb_name from course_library
END