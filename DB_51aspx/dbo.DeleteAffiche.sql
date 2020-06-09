

-- =============================================
-- Description:获取指定公告内容
-- =============================================
CREATE PROCEDURE  [dbo].[DeleteAffiche]
(
  @Af_id int,
  @Dp_id char(2)
)
AS
BEGIN
if exists(select * from affiche where af_id=@Af_id and dp_id=@Dp_id)
BEGIN
DELETE affiche where af_id=@Af_id
if @@rowcount=1
return  1 --删除成功
else
return  0 --删除失败
end
else
return -1  --没有权限(该部门没有对应的公告信息)
END