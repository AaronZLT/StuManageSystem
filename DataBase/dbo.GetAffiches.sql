


-- =============================================
-- Description:获取公告信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetAffiches]
AS
BEGIN
SELECT affiche.af_id, affiche.af_title,affiche.af_content,department.dp_name,affiche.af_time,affiche.af_enabletime FROM affiche,department WHERE   affiche.dp_id=department.dp_id
END