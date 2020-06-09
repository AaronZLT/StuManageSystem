




-- =============================================
-- Description:获取专业列表信息
-- =============================================
CREATE PROCEDURE  [dbo].[GetSpecialityList]
(
  @Dp_id  char(2),
  @Sp_grade char(4)
)
AS
BEGIN
if @Dp_id ='00' and @Sp_grade ='0000'
begin
SELECT  s.sp_id,s.sp_name,d.dp_name,s.sp_grade from speciality as s,department as d where s.dp_id=d.dp_id
end
if @DP_id <>'00' and @Sp_grade = '0000'
BEGIN
SELECT  s.sp_id,s.sp_name,d.dp_name,s.sp_grade from speciality as s,department as d where s.dp_id=d.dp_id and s.dp_id=@Dp_id
END
if @DP_id ='00' and @Sp_grade <>'0000'
BEGIN
SELECT  s.sp_id,s.sp_name,d.dp_name,s.sp_grade from speciality as s,department as d where s.dp_id=d.dp_id and s.sp_grade=@Sp_grade
END
if @DP_id <>'00' and @Sp_grade <> '0000'
BEGIN
SELECT  s.sp_id,s.sp_name,d.dp_name,s.sp_grade from speciality as s,department as d where s.dp_id=d.dp_id and s.sp_grade=@Sp_grade and s.dp_id=@Dp_id
END
END