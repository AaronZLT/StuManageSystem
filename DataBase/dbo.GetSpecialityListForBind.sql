


-- =============================================
-- Description:获取专业列表信息绑定到下拉列表框
-- =============================================
CREATE PROCEDURE  [dbo].[GetSpecialityListForBind]
AS
BEGIN
select  sp_id,sp_name  as sp_name from speciality
END