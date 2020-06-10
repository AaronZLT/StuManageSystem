





-- =============================================
-- Description:获取学院列表信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetCollegeList]
AS
BEGIN
SELECT d.dp_id,d.dp_name,d.dp_address,d.dp_tel from department as d  WHERE  d.dp_flag=0
END