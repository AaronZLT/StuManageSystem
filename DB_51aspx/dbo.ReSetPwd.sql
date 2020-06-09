



-- =============================================
-- Description:密码重置
-- =============================================
CREATE  PROCEDURE ReSetPwd
(
  @Object  varchar(20),
  @Number  varchar(20),
  @Newpwd varchar(20)
)
AS
BEGIN
if @Object='教师' 
  begin
  if exists (select * from dbo.teacher where te_id=@Number)
     begin 
     update dbo.teacher set te_pwd=@Newpwd where te_id=@Number
     if @@rowcount=1
        return 1 ---修改成功
     else
        return -1 --修改失败
     end
    else
   begin
   return -2 --该对象不存在
   end
end
if @Object='学生' 
begin
    if exists (select * from dbo.student where st_id=@Number)
     begin 
     update dbo.student set st_pwd=@Newpwd where st_id=@Number
     if @@rowcount=1
     return 1 ---修改成功
     else
     return -1 --修改失败
     end
     else
     begin
     return -2 --该对象不存在
     end
end
if @Object='部门' 
  begin
  if exists (select * from dbo.department where dp_id=@Number)
     begin 
     update dbo.department set dp_pwd=@Newpwd where dp_id=@Number
     if @@rowcount=1
        return 1 ---修改成功
     else
        return -1 --修改失败
     end
    else
   begin
   return -2 --该对象不存在
   end
end
END