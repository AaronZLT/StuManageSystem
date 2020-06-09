





-- =============================================
-- Description:获取要修改的公告内容
-- =============================================
CREATE PROCEDURE  [dbo].[GetAfficheForUpdate]
(
  @Af_id int,
  @Dp_id char(2),
  @Af_title nvarchar(100) output,
  @Af_content nvarchar(1000) output,
  @Af_enabletime datetime output,
  @Af_filepath  nvarchar(150) output
)
AS
BEGIN
if exists(
            select *  from  affiche where  af_id=@Af_id and dp_id=@Dp_id
         )
SELECT @Af_title=af_title,@Af_content=af_content,@Af_enabletime=af_enabletime,@Af_filepath=af_filepath  FROM affiche WHERE af_id=@Af_id
else
return -1 --返回没有权限修改
END