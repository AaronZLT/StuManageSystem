

-- =============================================
-- Description:获取班级列表信息绑定到下拉列表框
-- =============================================
CREATE PROCEDURE  [dbo].[GetClassList]
@sp_id char(20)
AS
BEGIN
if @sp_id='00'
select  cl_id,cl_name from class
else
select  cl_id,cl_name from class where sp_id=@sp_id
END