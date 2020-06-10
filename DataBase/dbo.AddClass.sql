

-- =============================================
-- Description:添加班级
-- =============================================
create PROCEDURE AddClass
(
@Cl_id char(30),
@Sp_id char(20), 
@Cl_name varchar(40),
@Cl_remark varchar(600)
)
AS
BEGIN
select * from class  where cl_id=@Cl_id 
if @@rowcount=1
begin
return -2 --班级已存在
end
else
begin
insert into class
values
( 
@Cl_id ,
@Sp_id ,
@Cl_name,
@Cl_remark
)
if @@rowcount=1
return 1 --添加成功
else
return 0 --添加失败
end
END