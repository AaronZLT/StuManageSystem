/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     2008-3-20 22:27:48                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('affiche') and o.name = 'FK_AFFICHE_REFERENCE_DEPARTME')
alter table affiche
   drop constraint FK_AFFICHE_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('choose_course') and o.name = 'FK_CHOOSE_C_REFERENCE_CLASSROO')
alter table choose_course
   drop constraint FK_CHOOSE_C_REFERENCE_CLASSROO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('choose_course') and o.name = 'FK_CHOOSE_C_REFERENCE_PLAN_COU')
alter table choose_course
   drop constraint FK_CHOOSE_C_REFERENCE_PLAN_COU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('choose_course') and o.name = 'FK_CHOOSE_C_REFERENCE_TEACHER')
alter table choose_course
   drop constraint FK_CHOOSE_C_REFERENCE_TEACHER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('class') and o.name = 'FK_CLASS_REFERENCE_SPECIALI')
alter table class
   drop constraint FK_CLASS_REFERENCE_SPECIALI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('course') and o.name = 'FK_COURSE_REFERENCE_STUDENT')
alter table course
   drop constraint FK_COURSE_REFERENCE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('course') and o.name = 'FK_COURSE_REFERENCE_PLAN_COU')
alter table course
   drop constraint FK_COURSE_REFERENCE_PLAN_COU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grade') and o.name = 'FK_GRADE_REFERENCE_PLAN_COU')
alter table grade
   drop constraint FK_GRADE_REFERENCE_PLAN_COU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('grade') and o.name = 'FK_GRADE_REFERENCE_STUDENT')
alter table grade
   drop constraint FK_GRADE_REFERENCE_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('plan_course') and o.name = 'FK_PLAN_COU_REFERENCE_DEPARTME')
alter table plan_course
   drop constraint FK_PLAN_COU_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('speciality') and o.name = 'FK_SPECIALI_REFERENCE_DEPARTME')
alter table speciality
   drop constraint FK_SPECIALI_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('student') and o.name = 'FK_STUDENT_REFERENCE_CLASS')
alter table student
   drop constraint FK_STUDENT_REFERENCE_CLASS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('teacher') and o.name = 'FK_TEACHER_REFERENCE_DEPARTME')
alter table teacher
   drop constraint FK_TEACHER_REFERENCE_DEPARTME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('affiche')
            and   name  = 'affiche_aid_indx'
            and   indid > 0
            and   indid < 255)
   drop index affiche.affiche_aid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('affiche')
            and   type = 'U')
   drop table affiche
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('choose_course')
            and   name  = 'choose_course_id_indx'
            and   indid > 0
            and   indid < 255)
   drop index choose_course.choose_course_id_indx
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('choose_course')
            and   name  = 'choose_course_cid_indx'
            and   indid > 0
            and   indid < 255)
   drop index choose_course.choose_course_cid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('choose_course')
            and   type = 'U')
   drop table choose_course
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('class')
            and   name  = 'class_clid_index'
            and   indid > 0
            and   indid < 255)
   drop index class.class_clid_index
go

if exists (select 1
            from  sysobjects
           where  id = object_id('class')
            and   type = 'U')
   drop table class
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('classroom')
            and   name  = 'classroom_crid_indx'
            and   indid > 0
            and   indid < 255)
   drop index classroom.classroom_crid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('classroom')
            and   type = 'U')
   drop table classroom
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('course')
            and   name  = 'course_stid_indx'
            and   indid > 0
            and   indid < 255)
   drop index course.course_stid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('course')
            and   type = 'U')
   drop table course
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('department')
            and   name  = 'department_did_index'
            and   indid > 0
            and   indid < 255)
   drop index department.department_did_index
go

if exists (select 1
            from  sysobjects
           where  id = object_id('department')
            and   type = 'U')
   drop table department
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('grade')
            and   name  = 'grade_stid_indx'
            and   indid > 0
            and   indid < 255)
   drop index grade.grade_stid_indx
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('grade')
            and   name  = 'grade_gid_indx'
            and   indid > 0
            and   indid < 255)
   drop index grade.grade_gid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('grade')
            and   type = 'U')
   drop table grade
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('plan_course')
            and   name  = 'plan_course_did_indx'
            and   indid > 0
            and   indid < 255)
   drop index plan_course.plan_course_did_indx
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('plan_course')
            and   name  = 'plan_course_cid_indx'
            and   indid > 0
            and   indid < 255)
   drop index plan_course.plan_course_cid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('plan_course')
            and   type = 'U')
   drop table plan_course
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('speciality')
            and   name  = 'speciality_did_index'
            and   indid > 0
            and   indid < 255)
   drop index speciality.speciality_did_index
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('speciality')
            and   name  = 'speciality_spid_index'
            and   indid > 0
            and   indid < 255)
   drop index speciality.speciality_spid_index
go

if exists (select 1
            from  sysobjects
           where  id = object_id('speciality')
            and   type = 'U')
   drop table speciality
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('student')
            and   name  = 'student_clid_indx'
            and   indid > 0
            and   indid < 255)
   drop index student.student_clid_indx
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('student')
            and   name  = 'student_stid_indx'
            and   indid > 0
            and   indid < 255)
   drop index student.student_stid_indx
go

if exists (select 1
            from  sysobjects
           where  id = object_id('student')
            and   type = 'U')
   drop table student
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('teacher')
            and   name  = 'teacher_did_index'
            and   indid > 0
            and   indid < 255)
   drop index teacher.teacher_did_index
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('teacher')
            and   name  = 'teacher_tid_index'
            and   indid > 0
            and   indid < 255)
   drop index teacher.teacher_tid_index
go

if exists (select 1
            from  sysobjects
           where  id = object_id('teacher')
            and   type = 'U')
   drop table teacher
go

/*==============================================================*/
/* Table: affiche                                               */
/*==============================================================*/
create table affiche (
   a_id                 int                  not null,
   d_id                 nvarchar(4)          not null,
   a_content            text                 null,
   a_time               datetime             null,
   a_enable_time        datetime             null,
   a_accessories        nvarchar(30)         null,
   constraint PK_AFFICHE primary key (a_id)
)
go

/*==============================================================*/
/* Index: affiche_aid_indx                                      */
/*==============================================================*/
create unique index affiche_aid_indx on affiche (
a_id ASC
)
go

/*==============================================================*/
/* Table: choose_course                                         */
/*==============================================================*/
create table choose_course (
   id                   int                  not null,
   c_id                 nvarchar(10)         null,
   t_id                 nvarchar(10)         null,
   cc_time              nvarchar(20)         null,
   cr_id                nvarchar(8)          null,
   constraint PK_CHOOSE_COURSE primary key nonclustered (id)
)
go

/*==============================================================*/
/* Index: choose_course_cid_indx                                */
/*==============================================================*/
create clustered index choose_course_cid_indx on choose_course (
c_id ASC
)
go

/*==============================================================*/
/* Index: choose_course_id_indx                                 */
/*==============================================================*/
create unique index choose_course_id_indx on choose_course (
id ASC
)
go

/*==============================================================*/
/* Table: class                                                 */
/*==============================================================*/
create table class (
   cl_id                nvarchar(10)         not null,
   cl_name              nvarchar(30)         null,
   sp_id                nvarchar(4)          null,
   t_id                 nvarchar(10)         null,
   cl_remark            nvarchar(100)        null,
   constraint PK_CLASS primary key (cl_id)
)
go

/*==============================================================*/
/* Index: class_clid_index                                      */
/*==============================================================*/
create unique index class_clid_index on class (
cl_id ASC
)
go

/*==============================================================*/
/* Table: classroom                                             */
/*==============================================================*/
create table classroom (
   cr_id                nvarchar(8)          not null,
   cr_type              nvarchar(6)          null,
   cr_capacity          int                  null,
   constraint PK_CLASSROOM primary key (cr_id)
)
go

/*==============================================================*/
/* Index: classroom_crid_indx                                   */
/*==============================================================*/
create unique index classroom_crid_indx on classroom (
cr_id ASC
)
go

/*==============================================================*/
/* Table: course                                                */
/*==============================================================*/
create table course (
   co_id                int                  not null,
   c_id                 nvarchar(10)         null,
   st_id                nvarchar(12)         null,
   constraint PK_COURSE primary key nonclustered (co_id)
)
go

/*==============================================================*/
/* Index: course_stid_indx                                      */
/*==============================================================*/
create clustered index course_stid_indx on course (
st_id ASC
)
go

/*==============================================================*/
/* Table: department                                            */
/*==============================================================*/
create table department (
   d_id                 nvarchar(4)          not null,
   d_name               nvarchar(20)         not null,
   d_passwd             nvarchar(20)         null,
   d_tel                nvarchar(11)         not null,
   d_remark             nvarchar(300)        null,
   constraint PK_DEPARTMENT primary key (d_id)
)
go

/*==============================================================*/
/* Index: department_did_index                                  */
/*==============================================================*/
create index department_did_index on department (
d_id ASC
)
go

/*==============================================================*/
/* Table: grade                                                 */
/*==============================================================*/
create table grade (
   g_id                 int                  not null,
   c_id                 nvarchar(10)         null,
   g_grade              float                null,
   st_id                nvarchar(12)         null,
   constraint PK_GRADE primary key nonclustered (g_id)
)
go

/*==============================================================*/
/* Index: grade_gid_indx                                        */
/*==============================================================*/
create unique index grade_gid_indx on grade (
g_id ASC
)
go

/*==============================================================*/
/* Index: grade_stid_indx                                       */
/*==============================================================*/
create clustered index grade_stid_indx on grade (
st_id ASC
)
go

/*==============================================================*/
/* Table: plan_course                                           */
/*==============================================================*/
create table plan_course (
   c_id                 nvarchar(10)         not null,
   c_name               nvarchar(20)         null,
   c_credithour         float                null,
   c_time               int                  null,
   c_kind               nvarchar(10)         null,
   d_id                 nvarchar(4)          null,
   c_ispublic           bit                  null,
   c_year               nvarchar(10)         null,
   c_term               nvarchar(8)          null,
   c_remark             nvarchar(100)        null,
   constraint PK_PLAN_COURSE primary key nonclustered (c_id)
)
go

/*==============================================================*/
/* Index: plan_course_cid_indx                                  */
/*==============================================================*/
create unique index plan_course_cid_indx on plan_course (
c_id ASC
)
go

/*==============================================================*/
/* Index: plan_course_did_indx                                  */
/*==============================================================*/
create clustered index plan_course_did_indx on plan_course (
d_id ASC
)
go

/*==============================================================*/
/* Table: speciality                                            */
/*==============================================================*/
create table speciality (
   sp_id                nvarchar(4)          not null,
   d_id                 nvarchar(4)          null,
   sp_name              nvarchar(20)         null,
   sp_remark            nvarchar(300)        null,
   constraint PK_SPECIALITY primary key nonclustered (sp_id)
)
go

/*==============================================================*/
/* Index: speciality_spid_index                                 */
/*==============================================================*/
create unique index speciality_spid_index on speciality (
sp_id ASC
)
go

/*==============================================================*/
/* Index: speciality_did_index                                  */
/*==============================================================*/
create clustered index speciality_did_index on speciality (
d_id ASC
)
go

/*==============================================================*/
/* Table: student                                               */
/*==============================================================*/
create table student (
   st_id                nvarchar(12)         not null,
   cl_id                nvarchar(10)         not null,
   st_name              nvarchar(10)         not null,
   st_sex               nchar(2)             not null,
   st_brityday          smalldatetime        not null,
   st_people            nvarchar(10)         null,
   st_native_place      nvarchar(20)         null,
   st_politics_face     nvarchar(10)         null,
   st_identity          char(18)             null,
   st_tel               char(11)             null,
   st_xueli             nvarchar(8)          null,
   st_address           nvarchar(30)         null,
   st_photo             image                null,
   constraint PK_STUDENT primary key nonclustered (st_id)
)
go

/*==============================================================*/
/* Index: student_stid_indx                                     */
/*==============================================================*/
create unique index student_stid_indx on student (
st_id ASC
)
go

/*==============================================================*/
/* Index: student_clid_indx                                     */
/*==============================================================*/
create clustered index student_clid_indx on student (
cl_id ASC
)
go

/*==============================================================*/
/* Table: teacher                                               */
/*==============================================================*/
create table teacher (
   t_id                 nvarchar(10)         not null,
   d_id                 nvarchar(4)          not null,
   t_name               nvarchar(10)         not null,
   t_sex                char(2)              not null,
   t_identity           char(18)             null,
   t_birthday           smalldatetime        null,
   t_photo              image                null,
   t_worktime           smalldatetime        null,
   t_zhicheng           nvarchar(8)          null,
   t_tel                char(11)             null,
   t_remark             nvarchar(300)        null,
   constraint PK_TEACHER primary key nonclustered (t_id)
)
go

/*==============================================================*/
/* Index: teacher_tid_index                                     */
/*==============================================================*/
create unique index teacher_tid_index on teacher (
t_id ASC
)
go

/*==============================================================*/
/* Index: teacher_did_index                                     */
/*==============================================================*/
create clustered index teacher_did_index on teacher (
d_id ASC
)
go

alter table affiche
   add constraint FK_AFFICHE_REFERENCE_DEPARTME foreign key (d_id)
      references department (d_id)
go

alter table choose_course
   add constraint FK_CHOOSE_C_REFERENCE_CLASSROO foreign key (cr_id)
      references classroom (cr_id)
go

alter table choose_course
   add constraint FK_CHOOSE_C_REFERENCE_PLAN_COU foreign key (c_id)
      references plan_course (c_id)
go

alter table choose_course
   add constraint FK_CHOOSE_C_REFERENCE_TEACHER foreign key (t_id)
      references teacher (t_id)
go

alter table class
   add constraint FK_CLASS_REFERENCE_SPECIALI foreign key (sp_id)
      references speciality (sp_id)
go

alter table course
   add constraint FK_COURSE_REFERENCE_STUDENT foreign key (st_id)
      references student (st_id)
go

alter table course
   add constraint FK_COURSE_REFERENCE_PLAN_COU foreign key (c_id)
      references plan_course (c_id)
go

alter table grade
   add constraint FK_GRADE_REFERENCE_PLAN_COU foreign key (c_id)
      references plan_course (c_id)
go

alter table grade
   add constraint FK_GRADE_REFERENCE_STUDENT foreign key (st_id)
      references student (st_id)
go

alter table plan_course
   add constraint FK_PLAN_COU_REFERENCE_DEPARTME foreign key (d_id)
      references department (d_id)
go

alter table speciality
   add constraint FK_SPECIALI_REFERENCE_DEPARTME foreign key (d_id)
      references department (d_id)
go

alter table student
   add constraint FK_STUDENT_REFERENCE_CLASS foreign key (cl_id)
      references class (cl_id)
go

alter table teacher
   add constraint FK_TEACHER_REFERENCE_DEPARTME foreign key (d_id)
      references department (d_id)
go

