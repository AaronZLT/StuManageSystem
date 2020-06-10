



-- =============================================
-- Description:学院添加开课课程
-- =============================================
CREATE PROCEDURE [dbo].[AddCourse]
(
@Cb_id varchar(10), 
@Dp_id char(2), 
@Cb_name varchar(40), 
@Cb_credithour real, 
@Ct_type varchar(12), 
@Cb_time int, 
@Cb_ispublic char(2), 
@Cb_remark varchar(600)
)
AS
BEGIN
if exists(select * from course_library where cb_id=@Cb_id)
begin 
return -1 --该课程编号存在
end
else
begin
INSERT INTO course_library values
(
@Cb_id, 
@Dp_id, 
@Cb_name, 
@Cb_credithour, 
@Ct_type , 
@Cb_time, 
@Cb_ispublic, 
@Cb_remark
)
if @@rowCount=1
return 1 --添加成功
else
return 0 --添加失败
end
END