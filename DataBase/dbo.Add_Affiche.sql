

-- =============================================
-- Description:发表公告
-- =============================================
CREATE PROCEDURE  Add_Affiche
(
   @Dp_id  char(2),
   @Af_title nvarchar(100),
   @Af_content  text,
   @Af_enabletime datetime,
   @Af_filepath nvarchar(150)
)
AS
BEGIN
INSERT INTO affiche(dp_id,af_title,af_content,af_enabletime,af_filepath) values
(
   @Dp_id,
   @Af_title,
   @Af_content,
   @Af_enabletime,
   @Af_filepath
)
if @@rowCount=1
return 1
else
return 0
END