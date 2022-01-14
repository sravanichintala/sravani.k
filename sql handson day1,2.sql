--create a database sales
create  database sales
--create a table salesman
create  table salesman(
salesman_id int primary key,
name varchar(30),
city varchar(40),
commission real
)

 insert into salesman values(5001,'James Hoog ','New York', 0.15)
 insert into salesman values(5002,'Nail Knite', 'Paris', 0.13)
 insert into salesman values(5005,' Pit Alex ','London',  0.11)
 insert into salesman values(5006,'  Mc Lyon ',' Paris',  0.14)
 insert into salesman values(5007 ,' Paul Adam',  'Rome',  0.13)
 insert into salesman values(5003,' Lauson Hen',' San Jose', 0.12)

  
  select * from salesman

  create table customer(
  customer_id int primary key,
  customer_name varchar(30),
  city varchar(15),
  grade int,
  salesman_id int references salesman(salesman_id)
  )
  insert into customer values (3002, 'Nick Rimando',' New York', 100, 5001)
insert into customer values (3007, 'Brad Davis', 'New York',200,5001)
insert into customer values (3005,'Graham Zusi','California',200,5002)
insert into customer values (3008,'Julian Green','London',300,5002)
insert into customer values (3004, 'Fabian Johnson','Paris',300,5006)
insert into customer values (3009,'Geoff Cameron','Berlin',100,5003)
insert into customer values (3003,'Jozy Altidor','Moscow',200,5007)
insert into customer values (3001, 'Brad Guzan','London',100,  5005)

select * from customer
drop table customer

create table orders
(
ord_no int primary key,
purch_amt decimal(8,2),
order_date date,
customer_id int references customer(customer_id),
salesman_id int references salesman(salesman_id),
)

insert into orders values (70001, 150.5 ,'2012-10-05 ',3005, 5002)
insert into orders values (70009, 270.65, '2012-09-10', 3001, 5005)
insert into orders values (70002, 65.26, '2012-10-05', 3002, 5001)
insert into orders values (70004, 110.5, '2012-08-17', 3009, 5003)
insert into orders values (70007, 948.5, '2012-09-10', 3005, 5002)
insert into orders values (70005, 2400.6, '2012-07-27', 3007, 5001)
insert into orders values (70008, 5760, '2012-09-10', 3002, 5001)
insert into orders values (70010, 1983.43,' 2012-10-10', 3004, 5006)
insert into orders values (70003, 2480.4, '2012-10-10', 3009, 5003)
insert into orders values (70012, 250.45, '2012-06-27', 3008, 5002)
insert into orders values (70011 ,75.29 ,'2012-08-17', 3003, 5007)
insert into orders values (70013,45.6, '2012-04-25', 3002, 5001)

select* from orders
drop table orders
-------------------------------------------------------------------------------------------------------------
select name,commission from salesman
select order_date,salesman_id,ord_no,purch_amt from orders
select name,city from salesman where city='paris'
select*from customer where grade=200
select ord_no,order_date,purch_amt from orders where salesaman_id=5001


---------------------------------------------------------------------------------------------------------
--write a sql query to calculate average purchase amount of all orders.return average purchase amount.
select avg(purch_amt) from orders
--write a sql query to count the number of unique salespeople.return number of salespeople.
select count(distinct salesman_id) from orders
--write a sql query to count the number of customers.return number of customers.
select count(*) from customer
--write a sql query to find the maximum purchase amount
select max(purch_amt) from orders
--write a sql query to find the highest grade of the customers for each of the city.return city ,max grade.
select city,max(grade) from customer group by city
--write a sql query to find the highest purchase amount ordered by each customer.return customer id ,maxpurchase amount
select order_date,max(purch_amt) from orders group by order_date,customer_id

------------------------------------------------------------------------------------------------------------

--1.write a sql query to count number of orders by the combination of each order date andsalesperson.return order date ,salesperson id
select order_date,salesman_id ,count(ord_no) from orders group by order_date,salesman_id

--2.write a sql query to count number of salespeople who belongs to a city.return number of salespeople.
select count(*) from salesman where city is not null

--3.write a sql query to count all the orders generated on '2012-08-17'.return number of orders.
select count(ord_no) from orders where order_dATE='2021-08-17'

--4.WRITE A SQL QUERY TO FIND THE MAX ORDER (PURCHASE) amount generated by each salesperson.filter the rows for the salesperson id
select salesman_id ,max(purch_amt) from orders where salesman_id>=5003 and salesman_id<=5008 group by salesman_id