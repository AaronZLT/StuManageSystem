


-- =============================================
-- Description:发表公告
-- =============================================
create PROCEDURE  Add_Dept
(
   @Dp_id  char(2),
   @Dp_name varchar(20),
   @Dp_pwd  varchar(20),
   @Dp_address varchar(30),
   @Dp_tel char(11),
   @Dp_remark varchar(600)
)
AS
BEGIN
select * from department where dp_id=@Dp_id
if @@rowcount=1
return -1 --部门编号存在
else
begin
INSERT INTO department(dp_id,dp_name,dp_pwd,dp_address,dp_tel,dp_remark) values
(
   @Dp_id,
   @Dp_name,
   @Dp_pwd,
   @Dp_address,
   @Dp_tel,
   @Dp_remark
)
if @@rowCount=1
return 1
else
return 0
end
END