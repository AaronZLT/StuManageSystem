
-- =============================================
-- Description:教师修改密码
-- =============================================
CREATE  PROCEDURE [dbo].[Te_ChangePwd]
(
  @Te_id  varchar(20),
  @Te_oldpwd varchar(20),
  @Te_newpwd varchar(20),
  @Te_renewpwd varchar(20)
)
AS
BEGIN
IF @Te_newpwd <>@Te_renewpwd
RETURN -1 --两次密码不一致
ELSE
    IF (SELECT COUNT(*) FROM teacher WHERE te_id=@Te_id AND te_pwd=@Te_oldpwd)=0
    RETURN -2 --密码错误
    ELSE   
	UPDATE teacher SET te_pwd=@Te_newpwd WHERE te_id=@Te_id AND te_pwd=@Te_oldpwd
	IF @@rowcount=1 --修改成功
	RETURN 1
	ELSE
	RETURN 0 --修改失败
END