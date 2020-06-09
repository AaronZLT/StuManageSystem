




-- =============================================
-- Description:获取教室列表
-- =============================================
CREATE PROCEDURE  [dbo].[GetCRList]
AS
BEGIN
select cr_id from classroom
END