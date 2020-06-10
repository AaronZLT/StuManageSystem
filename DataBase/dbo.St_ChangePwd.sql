


-- =============================================
-- Description:学生修改密码
-- =============================================
CREATE  PROCEDURE [dbo].[St_ChangePwd]
(
  @St_id  varchar(20),
  @St_oldpwd varchar(20),
  @St_newpwd varchar(20),
  @St_renewpwd varchar(20)
)
AS
BEGIN
IF @St_newpwd <>@St_renewpwd
RETURN -1
ELSE
    IF (SELECT COUNT(*) FROM student WHERE st_id=@St_id AND st_pwd=@St_oldpwd)=0
    RETURN -2
    ELSE   
	UPDATE student SET st_pwd=@St_newpwd WHERE st_id=@St_id AND st_pwd=@St_oldpwd
	--IF (SELECT COUNT(*) FROM student WHERE st_id=@St_id AND st_pwd=@St_newpwd)>0
	IF @@rowcount=1
	RETURN 1
	ELSE
	RETURN 0
END