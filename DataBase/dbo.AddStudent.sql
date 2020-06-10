


-- =============================================
-- Description:添加学生
-- =============================================
CREATE PROCEDURE [dbo].[AddStudent]
(
@St_id varchar(20), 
@Cl_id  char(30), 
@St_name varchar(20), 
@St_sex  char(2) , 
@St_birthday datetime, 
@Mz_name  varchar(16), 
@St_identity char(18), 
@St_tel char(11), 
@St_province varchar(10), 
@St_face varchar(10), 
@St_address varchar(20), 
@St_remark varchar(600)
)
AS
BEGIN
select * from student where st_id=@st_id 
if @@rowcount=1
begin
return -2 --学生号已存在
end
else
begin
insert into student(st_id, cl_id, st_name, st_sex, st_birthday, mz_name, st_identity, st_tel, st_province, st_face, st_address, st_remark)
values
( 
@St_id, 
@Cl_id, 
@St_name, 
@St_sex, 
@St_birthday, 
@Mz_name , 
@St_identity , 
@St_tel, 
@St_province , 
@St_face, 
@St_address, 
@St_remark
)
if @@rowcount=1
return 1 --添加成功
else
return 0 --添加失败
end
END