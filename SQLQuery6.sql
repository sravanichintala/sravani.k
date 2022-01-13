create database salesman

create table salesmandetails
(
 salesmanID numeric(5) primary key,
 name varchar(30),
 city varchar(15),
 commission decimal(5,2)
 )

 insert into salesmandetails values(5001,'James Hoog ','New York', 0.15)
 insert into salesmandetails values(5002,'Nail Knite', 'Paris', 0.13)
 insert into salesmandetails values(5005,' Pit Alex ','London',  0.11)
 insert into salesmandetails values(5006,'  Mc Lyon ',' Paris',  0.14)
 insert into salesmandetails values(5007 ,' Paul Adam',  'Rome',  0.13)
 insert into salesmandetails values(5003,' Lauson Hen',' San Jose', 0.12)

 
 select name from salesmandetails 
 select commission from salesmandetails 