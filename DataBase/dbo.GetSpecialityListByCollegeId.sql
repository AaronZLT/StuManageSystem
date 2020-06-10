





-- =============================================
-- Description:获取专业列表信息绑定到下拉列表框
-- =============================================
CREATE PROCEDURE  [dbo].[GetSpecialityListByCollegeId]
@Dp_id char(2)
AS
BEGIN
if @Dp_id='01'
select  sp_id,sp_name from speciality 
else
select  sp_id,sp_name from speciality where dp_id=@Dp_id
END