


-- =============================================
-- Description:学生修改密码
-- =============================================
CREATE PROCEDURE [dbo].[Valid_Te_Login]
(
  @Te_id  varchar(10),
  @Te_pwd varchar(20)
)
AS
BEGIN
IF (SELECT COUNT(*) FROM teacher WHERE te_id=@Te_id AND te_pwd=@Te_pwd)>0
RETURN 1
ELSE
RETURN 0
END