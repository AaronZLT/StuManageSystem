




-- =============================================
-- Description:修改指定公告内容
-- =============================================
create PROCEDURE UpdateAffiche
(
  @Af_id int,
  @Dp_id char(2),
  @Af_title nvarchar(100) ,
  @Af_content nvarchar(1000),
  @Af_enabletime datetime,
  @Af_filepath  nvarchar(150) 
)
AS
BEGIN
update affiche set  dp_id=@Dp_id,af_title=@Af_title,af_content=@Af_content,af_enabletime=@Af_enabletime,af_filepath=@Af_filepath
if @@rowcount=1
return 1  --修改成功
else
return -1 --修改失败
END