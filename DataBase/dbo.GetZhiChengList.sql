
-- =============================================
-- Description:获取职称列表信息
-- =============================================
create PROCEDURE  GetZhiChengList
AS
BEGIN
SELECT zc_name from zhicheng
END