






-- =============================================
-- Description:设置专业选课
-- =============================================
CREATE PROCEDURE [dbo].[AddChooseCourse]
(
@Cb_id  varchar(10), 
@Sp_id  char(20),
@Te_id  varchar(10),
@Cr_id  char(10), 
@Pc_year char(10), 
@Pc_term int, 
@Pc_weeks char(10), 
@Pc_personcount int, 
@Pc_classtime char(50),
@Pc_remark nvarchar(400)
)
AS
BEGIN
if exists(select * from plan_course where sp_id=@Sp_id and cb_id =@Cb_id)
    begin 
    return -1 --该专业已经开设了该课程
    end
else
	begin
	if exists(select * from plan_course where cr_id=@Cr_id and pc_classtime=@Pc_classtime)
		begin
		return -2 --该教室在该时间有人上课
		end
	else
		begin
		if exists(select * from plan_course where te_id=@Te_id and pc_classtime=@Pc_classtime)
			begin
			return -3 --该老师当前还有其他课
			end
        else
			begin
			INSERT INTO plan_course(cb_id, sp_id, te_id,cr_id, pc_year, pc_term, pc_weeks, pc_personcount, pc_classtime,pc_remark) values
			(
			@Cb_id , 
			@Sp_id , 
			@Te_id , 
			@Cr_id ,
			@Pc_year, 
			@Pc_term, 
			@Pc_weeks, 
			@Pc_personcount, 
			@Pc_classtime,
			@Pc_remark
			)
			if @@rowCount=1
				return 1 --添加选课成功
			else
				return 0 --添加选课失败
			end
		end
   end   
END