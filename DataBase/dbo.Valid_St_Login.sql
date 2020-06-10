
-- =============================================
-- Description:学生修改密码
-- =============================================
CREATE PROCEDURE [dbo].[Valid_St_Login]
(
  @St_id  varchar(20),
  @St_pwd varchar(20)
)
AS
BEGIN
IF (SELECT COUNT(*) FROM student WHERE st_id=@St_id AND st_pwd=@St_pwd)>0
RETURN 1
ELSE
RETURN 0
END