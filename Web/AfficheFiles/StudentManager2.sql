/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('affiche') and o.name = 'FK_AFFICHE_RELATIONS_DEPARTME')
alter table affiche
   drop constraint FK_AFFICHE_RELATIONS_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('speciality') and o.name = 'FK_SPECIALI_RELATIONS_DEPARTME')
alter table speciality
   drop constraint FK_SPECIALI_RELATIONS_DEPARTME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('affiche')
            and   name  = 'Relationship_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index affiche.Relationship_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('affiche')
            and   type = 'U')
   drop table affiche
go

if exists (select 1
            from  sysobjects
           where  id = object_id('department')
            and   type = 'U')
   drop table department
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('speciality')
            and   name  = 'Relationship_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index speciality.Relationship_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('speciality')
            and   type = 'U')
   drop table speciality
go

/*==============================================================*/
/* Table: affiche                                               */
/*==============================================================*/
create table affiche (
   af_id                int                  not null,
   dep_dp_id            char(2)              not null,
   dp_id                char(2)              null,
   af_content           text                 null,
   af_time              datetime             null,
   af_enabletime        datetime             null,
   constraint PK_AFFICHE primary key nonclustered (af_id)
)
go

/*==============================================================*/
/* Index: Relationship_1_FK                                     */
/*==============================================================*/
create index Relationship_1_FK on affiche (
dep_dp_id ASC
)
go

/*==============================================================*/
/* Table: department                                            */
/*==============================================================*/
create table department (
   dp_id                char(2)              not null,
   dp_name              varchar(20)          null,
   dp_pwd               varchar(20)          null,
   dp_address           varchar(30)          null,
   dp_tel               char(11)             null,
   dp_remark            varchar(600)         null,
   constraint PK_DEPARTMENT primary key nonclustered (dp_id)
)
go

/*==============================================================*/
/* Table: speciality                                            */
/*==============================================================*/
create table speciality (
   sp_id                char(2)              not null,
   dep_dp_id            char(2)              not null,
   dp_id                char(2)              null,
   sp_name              varchar(20)          null,
   sp_remark            varchar(600)         null,
   constraint PK_SPECIALITY primary key nonclustered (sp_id)
)
go

/*==============================================================*/
/* Index: Relationship_2_FK                                     */
/*==============================================================*/
create index Relationship_2_FK on speciality (
dep_dp_id ASC
)
go

alter table affiche
   add constraint FK_AFFICHE_RELATIONS_DEPARTME foreign key (dep_dp_id)
      references department (dp_id)
go

alter table speciality
   add constraint FK_SPECIALI_RELATIONS_DEPARTME foreign key (dep_dp_id)
      references department (dp_id)
go

