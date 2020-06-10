
-- =============================================
-- Description:获取用户名基本欢迎信息
-- =============================================
CREATE PROCEDURE [dbo].[GetUserWelcomeInf]
(
  @Uid varchar(20),
  @Utable varchar(20),
  @Username varchar(20) output 
)
AS
BEGIN
IF @Utable='student'
set @Username=(SELECT st_name FROM student WHERE st_id=@Uid)
IF @Utable='teacher' 
set @Username=(SELECT te_name FROM teacher WHERE te_id=@Uid)
IF @Utable='department' 
set @Username=(SELECT dp_name FROM department WHERE dp_id=@Uid)
END