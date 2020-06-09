



-- =============================================
-- Description:获取班级列表信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetClassesList]
(
 @Dp_name varchar(20),
 @Sp_name varchar(40)
)
AS
if @Dp_name=''
set @Dp_name='%'
if @Sp_name=''
set @Sp_name='%'
BEGIN
select * from dbo.vw_Classes where dp_name like @Dp_name  and  sp_name like @Sp_name
END