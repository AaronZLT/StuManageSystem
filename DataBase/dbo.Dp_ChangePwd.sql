



-- =============================================
-- Description:部门修改密码
-- =============================================
CREATE  PROCEDURE [dbo].[Dp_ChangePwd]
(
  @Dp_id  varchar(20),
  @Dp_oldpwd varchar(20),
  @Dp_newpwd varchar(20),
  @Dp_renewpwd varchar(20)
)
AS
BEGIN
IF @Dp_newpwd <>@Dp_renewpwd
RETURN -1 --密码不一致
ELSE
    IF (SELECT COUNT(*) FROM department WHERE dp_id=@Dp_id AND dp_pwd=@Dp_oldpwd)=0
    RETURN -2  --密码错误
    ELSE   
	UPDATE department SET dp_pwd=@Dp_newpwd WHERE dp_id=@Dp_id AND dp_pwd=@Dp_oldpwd
	--IF (SELECT COUNT(*) FROM student WHERE st_id=@St_id AND st_pwd=@St_newpwd)>0
	IF @@rowcount=1
	RETURN 1  --密码修改成功
	ELSE
	RETURN 0 --修改失败
END