
-- =============================================
-- Description:获取指定公告内容
-- =============================================
CREATE PROCEDURE  [dbo].[GetAffiche]
(
  @Af_id int
)
AS
BEGIN
SELECT  af_title ,af_content ,af_filepath  FROM affiche WHERE af_id=@Af_id
END