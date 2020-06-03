/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     2008-3-20 21:02:57                           */
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
   where r.fkeyid = object_id('plan_course') and o.name = 'FK_PLAN_COU_REFERENCE_XUEYUAN')
alter table plan_course
   drop constraint FK_PLAN_COU_REFERENCE_XUEYUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('speciality') and o.name = 'FK_SPECIALI_REFERENCE_XUEYUAN')
alter table speciality
   drop constraint FK_SPECIALI_REFERENCE_XUEYUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('student') and o.name = 'FK_STUDENT_REFERENCE_CLASS')
alter table student
   drop constraint FK_STUDENT_REFERENCE_CLASS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('teacher') and o.name = 'FK_TEACHER_REFERENCE_XUEYUAN')
alter table teacher
   drop constraint FK_TEACHER_REFERENCE_XUEYUAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('xueyuan') and o.name = 'FK_XUEYUAN_FK_D_TO_D_DEPARTME')
alter table xueyuan
   drop constraint FK_XUEYUAN_FK_D_TO_D_DEPARTME
go

if exists (select 1
            from  sysobjects
           where  id = object_id('affiche')
            and   type = 'U')
   drop table affiche
go

if exists (select 1
            from  sysobjects
           where  id = object_id('choose_course')
            and   type = 'U')
   drop table choose_course
go

if exists (select 1
            from  sysobjects
           where  id = object_id('class')
            and   type = 'U')
   drop table class
go

if exists (select 1
            from  sysobjects
           where  id = object_id('classroom')
            and   type = 'U')
   drop table classroom
go

if exists (select 1
            from  sysobjects
           where  id = object_id('course')
            and   type = 'U')
   drop table course
go

if exists (select 1
            from  sysobjects
           where  id = object_id('department')
            and   type = 'U')
   drop table department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('grade')
            and   type = 'U')
   drop table grade
go

if exists (select 1
            from  sysobjects
           where  id = object_id('plan_course')
            and   type = 'U')
   drop table plan_course
go

if exists (select 1
            from  sysobjects
           where  id = object_id('speciality')
            and   type = 'U')
   drop table speciality
go

if exists (select 1
            from  sysobjects
           where  id = object_id('student')
            and   type = 'U')
   drop table student
go

if exists (select 1
            from  sysobjects
           where  id = object_id('teacher')
            and   type = 'U')
   drop table teacher
go

if exists (select 1
            from  sysobjects
           where  id = object_id('xueyuan')
            and   type = 'U')
   drop table xueyuan
go

/*==============================================================*/
/* Table: affiche                                               */
/*==============================================================*/
create table affiche (
   a_id                 int                  not null,
   dp_id                nvarchar(4)          null,
   dept_id              nvarchar(4)          not null,
   a_content            text                 null,
   a_time               datetime             null,
   a_enable_time        datetime             null,
   a_accessories        nvarchar(30)         null,
   constraint PK_AFFICHE primary key (a_id)
)
go

/*==============================================================*/
/* Table: choose_course                                         */
/*==============================================================*/
create table choose_course (
   c_id                 nvarchar(10)         null,
   t_id                 nvarchar(10)         null,
   cc_time              nvarchar(20)         null,
   cr_id                nvarchar(8)          null
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
/* Table: course                                                */
/*==============================================================*/
create table course (
   co_id                int                  not null,
   c_id                 nvarchar(10)         null,
   st_id                nvarchar(12)         null,
   constraint PK_COURSE primary key (co_id)
)
go

/*==============================================================*/
/* Table: department                                            */
/*==============================================================*/
create table department (
   dp_id                nvarchar(4)          not null,
   dp_name              nvarchar(20)         not null,
   dp_remark            nvarchar(300)        null,
   constraint PK_DEPARTMENT primary key (dp_id)
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
   constraint PK_GRADE primary key (g_id)
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
   constraint PK_PLAN_COURSE primary key (c_id)
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
   constraint PK_SPECIALITY primary key (sp_id)
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
   constraint PK_STUDENT primary key (st_id)
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
   constraint PK_TEACHER primary key (t_id)
)
go

/*==============================================================*/
/* Table: xueyuan                                               */
/*==============================================================*/
create table xueyuan (
   d_id                 nvarchar(4)          not null,
   dp_id                nvarchar(4)          null,
   dept_id              nvarchar(4)          not null,
   d_name               nvarchar(20)         not null,
   d_tel                nvarchar(11)         not null,
   d_remark             nvarchar(300)        null,
   constraint PK_XUEYUAN primary key (d_id)
)
go

alter table affiche
   add constraint FK_AFFICHE_REFERENCE_DEPARTME foreign key (dp_id)
      references department (dp_id)
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
   add constraint FK_PLAN_COU_REFERENCE_XUEYUAN foreign key (d_id)
      references xueyuan (d_id)
go

alter table speciality
   add constraint FK_SPECIALI_REFERENCE_XUEYUAN foreign key (d_id)
      references xueyuan (d_id)
go

alter table student
   add constraint FK_STUDENT_REFERENCE_CLASS foreign key (cl_id)
      references class (cl_id)
go

alter table teacher
   add constraint FK_TEACHER_REFERENCE_XUEYUAN foreign key (d_id)
      references xueyuan (d_id)
go

alter table xueyuan
   add constraint FK_XUEYUAN_FK_D_TO_D_DEPARTME foreign key (dp_id)
      references department (dp_id)
go

