

create database Batch31
use Batch31

create table Book
(
   Id int identity(1,1),
   BookName varchar(50),
   WriterName varchar(50),
   Price int
   );


Select * from Book

insert into Book values('C# Fundamentals','Bob',50)
insert into Book values('C# Fundamentals1','Bob1',50)
insert into Book values('C# Fundamentals2','Bob2',50)