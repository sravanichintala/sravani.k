--how to create database(DB)?
create database TutorialDB

--how to create tables?
create table Tutorial
(
 TutorialId int primary key,
 TutorialName  varchar(100),
 TutorialDesc varchar(max),
 Published int
 )

 --how to alter table,how to add column in existing table?
 alter table Tutorial add TutorialFees numeric

 --how to insrt a row table
 insert into Tutorial values (1,'c#','Multithreading',0)
 insert into Tutorial values (2,'SQL','SQL Commands',1 )
 insert into Tutorial values (3,'java','Javahybernate',1)
 insert into Tutorial values (4,'c#','OOPS',1)
 insert into Tutorial values (5,'c#','File Handling',1)
 insert into Tutorial values (6,'java','MVC',0)

 --how to delete row/rows from table?
 delete from Tutorial where Published=0 and TutorialName='java'

 

 --how to display table rows/view?
 select * from Tutorial
 drop table Tutorial

