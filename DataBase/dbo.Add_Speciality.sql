




-- =============================================
-- Description:发表公告
-- =============================================
CREATE PROCEDURE  [dbo].[Add_Speciality]
(
   @Sp_id  char(20),
   @Dp_id  char(2),
   @Sp_name varchar(35),
   @Sp_remark varchar(600),
   @Sp_grade char(4)
)
AS
BEGIN
select * from department where dp_id=@Dp_id
if @@rowcount=1
begin
select * from  speciality where sp_id =@Sp_id
if @@rowcount <> 1
begin
INSERT INTO speciality values
(
   @Sp_id,@Dp_id,@Sp_name,@Sp_remark ,@Sp_grade
)
if @@rowCount=1
return 1  --添加成功
else
return 0  --添加失败
end
else
return -2 --专业编号已存在
end
else
return -1 --学院不存在
END