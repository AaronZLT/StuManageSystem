











-- =============================================
-- Description:学生培养计划
CREATE  PROCEDURE  [dbo].[PlanCourseTable]
(
  @St_id char(20)
) 
AS
BEGIN
select * from vw_CoursePlan where sp_id in
(
   select distinct  sp_id from class where  cl_id in
(
   select cl_id from  student where st_id=@St_id
)
)
END