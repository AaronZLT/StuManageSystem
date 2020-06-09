










-- =============================================
-- Description:学生选课
-- =============================================
CREATE  PROCEDURE  [dbo].[NoChooseCourse]
(
  @St_id varchar(20),
  @Pc_id bigint ,
  @Pc_year char(10),
  @Pc_term int
) 
AS
declare @Coutperson  int,@Realcount int,@Cb_id varchar(10)
BEGIN
delete from class_table where st_id=@St_id and pc_id=@Pc_id and learn_year=@Pc_year and learn_term=@Pc_term
if(@@rowcount>0)
begin
select @Cb_id=cb_id from plan_course where pc_id=@Pc_id
delete from score  where st_id=@St_id and cb_id=@Cb_id and sc_year=@Pc_year and sc_term=@Pc_term
return 1 --退选成功
end
else
begin
return -1 --退选失败
end
END