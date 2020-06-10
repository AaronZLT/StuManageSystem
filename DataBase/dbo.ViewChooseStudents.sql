

-- =============================================
-- Description:获取选某课程的学生信息列表
-- =============================================
create PROCEDURE  [dbo].[ViewChooseStudents]
(
 @Pc_id  bigint
)
AS
BEGIN
select * from vw_ChooseStudentsTb where pc_id=@Pc_id
END