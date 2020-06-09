


-- =============================================
-- Description:获取学生列表信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetStudentList]
(
 @Dp_name varchar(20),
 @Sp_name varchar(35),
 @Cl_name varchar(40)
)
AS
if @Dp_name=''
set @Dp_name='%'
if @Sp_name=''
set @Sp_name='%'
if @Cl_name=''
set @Cl_name='%'
BEGIN
select * from dbo.vw_StudentList where dp_name like @Dp_name  and  sp_name like @Sp_name and cl_name like @Cl_name
END