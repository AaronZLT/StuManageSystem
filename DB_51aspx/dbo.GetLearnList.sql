
-- =============================================
-- Description:获取学历列表信息
-- =============================================
create PROCEDURE  GetLearnList
AS
BEGIN
SELECT lg_name from learn_garde
END