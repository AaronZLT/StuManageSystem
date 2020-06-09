

-- =============================================
-- Description:学生修改密码
-- =============================================
CREATE PROCEDURE [dbo].[Valid_Dp_Login]
(
  @Dp_id  varchar(2),
  @Dp_pwd varchar(20)
)
AS
BEGIN
IF (SELECT COUNT(*) FROM department WHERE dp_id=@Dp_id AND dp_pwd=@Dp_pwd)>0
RETURN 1
ELSE
RETURN 0
END