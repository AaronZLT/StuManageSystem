






-- =============================================
-- Description:获取部门信息
-- =============================================
create PROCEDURE  [dbo].[GetDeptInf]
(
  @Dp_id char(2)
)
AS
BEGIN
select * from department where dp_id =@Dp_id
END