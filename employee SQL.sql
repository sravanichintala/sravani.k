--create database HRDB
create database HRDB

--create table region
create table region( 
 region_ID int primary key,
 region_NAME varchar(25)
)
drop table region
--create table countries
create table countries(
country_ID char(12) primary key,
country_NAME varchar(40),
region_ID int references region(region_ID)
)

--create a table locations
create table locations(
location_ID int primary key,
street_ADDRESS varchar(25),
postal_CODE varchar(12),
city varchar(30),
sate_PROVINCE varchar(12),
country_ID char(12) references countries(country_ID)
)

--create a table departments
create table departments(
department_ID int primary key,
department_NAME varchar(30),
manager_ID int,
location_ID int references locations(location_ID)
)

--create a table jobs
create table jobs(
job_ID varchar(20) primary key,
job_TITTLE varchar(35),
min_SALARY int,
max_SALARY int
)

--create table employees
create table employees(
employee_ID int primary key,
first_NAME varchar(20),
last_NAME varchar(25),
email varchar(25),
phone_NUMBER varchar(20),
hire_DATE date,
job_ID varchar(20) references jobs(job_ID),
salary int,
commission_PCT int,
manager_ID int,
department_ID int references departments(department_ID)
)

--create a table job_history
create table job_history(
employee_ID int references employees(employee_ID),
start_DATE date primary key,
end_DATE date,
job_ID varchar(20) references jobs(job_ID),
department_ID int references departments(department_ID)
)

--create a table job_grades
create table job_grades(
gradelevel varchar(2) primary key,
lowestsal int,
highestsal int
)