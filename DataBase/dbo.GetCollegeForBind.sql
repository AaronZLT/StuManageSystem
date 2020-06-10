




-- =============================================
-- Description:获取学院列表
-- =============================================
CREATE PROCEDURE  [dbo].[GetCollegeForBind]
AS
BEGIN
select'00'as dp_id, '所有学院' as dp_name
union
select dp_id,dp_name from department where dp_flag=0
END