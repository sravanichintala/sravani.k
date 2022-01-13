
create table salesmanorder
(
 ord_no numeric(5) ,
 purch_amt decimal(8,2) ,
 ord_date int,
 customer_id numeric(5),
 salesmanID numeric(5)  references salesmandetails (salesmanID) 
)

---------- ---------- ---------- ----------- -----------
insert into salesmanorder values (70001, 150.5 ,2012-10-05 ,3005, 5002)
insert into salesmanorder values (70009, 270.65, 2012-09-10, 3001, 5005)
insert into salesmanorder values (70002, 65.26, 2012-10-05, 3002, 5001)
insert into salesmanorder values (70004, 110.5, 2012-08-17, 3009, 5003)
insert into salesmanorder values (70007, 948.5, 2012-09-10, 3005, 5002)
insert into salesmanorder values (70005, 2400.6, 2012-07-27, 3007, 5001)
insert into salesmanorder values (70008, 5760, 2012-09-10, 3002, 5001)
insert into salesmanorder values (70010, 1983.43, 2012-10-10, 3004, 5006)
insert into salesmanorder values (70003, 2480.4, 2012-10-10, 3009, 5003)
insert into salesmanorder values (70012, 250.45, 2012-06-27, 3008, 5002)
insert into salesmanorder values (70011 ,75.29 ,2012-08-17, 3003, 5007)
insert into salesmanorder values (70013,45.6, 2012-04-25, 3002, 5001)

select ord_date from salesmanorder where salesmanID =5001 and purch_amt =65.26
select * from salesmanorder
drop table salesmanorder

create table customer
(
customer_id numeric(5),
cust_name varchar(30),
city varchar(15),
grade numeric(3),
salesmanID numeric(5)
)


-------------+----------------+------------+-------+------------

insert into customer values (3002, 'Nick Rimando',' New York', 100, 5001)
insert into customer values (3007, 'Brad Davis', 'New York',200,5001)
insert into customer values (3005,'Graham Zusi','California',200,5002)
insert into customer values (3008,'Julian Green','London',300,5002)
insert into customer values (3004, 'Fabian Johnson','Paris',300,5006)
insert into customer values (3009,'Geoff Cameron','Berlin',100,5003)
insert into customer values (3003,'Jozy Altidor','Moscow',200,5007)
insert into customer values (3001, 'Brad Guzan','London',00,  5005)


select * from customer
drop table customer
