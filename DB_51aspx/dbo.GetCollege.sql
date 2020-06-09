


-- =============================================
-- Description:获取学院列表
-- =============================================
create PROCEDURE  GetCollege
AS
BEGIN
select dp_id,dp_name from department where dp_flag=0
END