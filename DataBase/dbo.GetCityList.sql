
-- =============================================
-- Description:获取省列表信息
-- =============================================
create PROCEDURE  GetCityList
(
   @Province varchar(10)
)
AS
BEGIN
select ci_name from city where pr_name=@Province
END