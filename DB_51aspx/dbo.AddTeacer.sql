

-- =============================================
-- Description:添加老师
-- =============================================
CREATE PROCEDURE  [dbo].[AddTeacer]
(
@Te_id varchar(20),
@Dp_id  char(2),
@Lg_name varchar(10),
@Zc_name varchar(10),
@Te_name varchar(10),
@Te_sex char(2),
@Te_identity char(18),
@Te_speciality varchar(20),
@Te_address  varchar(50),
@Te_zzface  char(20),
@Te_minzu char(16),
@Te_tel char(11),
@Te_birthday  datetime,
@Te_teachtime  datetime,
@Tb_Province  varchar(16),
@Te_remark  varchar(600)
)
AS
BEGIN
select * from  teacher where te_id=@te_id
if @@rowcount=1
begin
return -2 --教师已存在
end
else
begin
insert into teacher(Te_id ,Dp_id,Lg_name,Zc_name ,Te_name,Te_sex ,Te_identity,Te_speciality,Te_address, Te_zzface,Te_minzu,Te_tel , Te_birthday,Te_teachtime ,Tb_Province, Te_remark ) 
values( 
@Te_id ,
@Dp_id ,
@Lg_name,
@Zc_name ,
@Te_name ,
@Te_sex ,
@Te_identity,
@Te_speciality ,
@Te_address ,
@Te_zzface,
@Te_minzu ,
@Te_tel,
@Te_birthday ,
@Te_teachtime,
@Tb_Province ,
@Te_remark 
)
if @@rowcount=1
return 1 --添加成功
else
return 0 --添加失败
end
END