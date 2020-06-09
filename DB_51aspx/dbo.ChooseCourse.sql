











-- =============================================
-- Description:学生选课
-- =============================================
CREATE PROCEDURE  [dbo].[ChooseCourse]
(
  @St_id varchar(20),
  @Pc_id bigint ,
  @Pc_year char(10),
  @Pc_term int
) 
AS
declare @Coutperson  int,@Realcount int,@Cb_id varchar(10)
BEGIN
select @Coutperson=pc_personcount from plan_course where pc_id=@Pc_id 
select @Realcount=count(*) from class_table where pc_id=@Pc_id and learn_year=@Pc_year and learn_term=@Pc_term
if(@Realcount<@Coutperson)
   begin
     if exists (select * from class_table where st_id=@St_id and pc_id=@Pc_id and flag='1'  and learn_year=@Pc_year and learn_term=@Pc_term)
     begin
       return -2 --已经选了该课程了
     end
     else
	   begin
		 if  exists (select * from class_table where st_id=@St_id and pc_id=@Pc_id and flag='0'  and learn_year=@Pc_year and learn_term=@Pc_term)
		 begin
		 update class_table set flag='1' where st_id=@St_id and pc_id=@Pc_id  and learn_year=@Pc_year and learn_term=@Pc_term --更新选定参数
		 end
		 else
		 begin
		   insert into class_table(st_id, pc_id,learn_year,learn_term) values(@St_id ,@Pc_id, @Pc_year, @Pc_term ) --选定课程
		   if(@@rowcount>0)
		   begin
			 select @Cb_id=cb_id from plan_course where pc_id=@Pc_id
			 insert into score(st_id, cb_id,  sc_year, sc_term) values(@St_id,@Cb_id,@Pc_year,@Pc_term)
			 return 1 --选课成功
		   end
		   else
		   begin
		   return 0 --选课失败
		   end
		 end
	   end
     end
else
begin
return -1 --超出人数限制了
end
END