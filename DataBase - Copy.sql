create database BloodBank

use BloodBank

select * from Nurse

create table Nurse
(
id int primary key ,
firstname varchar(30),
lastname varchar(30),
password varchar(30),
dn datetime,
)


create table Hospital
(
hosid int primary key identity,
nom varchar(50),
ville varchar(50),
phone varchar (30),
adress varchar (30)
)

alter table hospital add adress varchar (30)

create table Commande
(
NumCom int primary key identity,
DateCom datetime,
hosid int foreign key references Hospital (hosid)
)

create table Blood
(
BloodGroup  char(3) Primary key,
pu float,
qstock int
)



create table donor
(
DonorId int primary key identity,
firstname varchar(30),
lastname varchar(30),
cin varchar (12),
datebirth datetime,
age int ,
phone varchar (20),
city varchar (20),
sex varchar (8),
Adress varchar(30),
Height int,
Dweight int,
diseases varchar (50),
BloodGroup char (3)foreign key references blood (bloodgroup),
datedonation datetime,
donotedBefor char(3),
)

create table Labo
(
bloodid int primary key identity,
Donorid int foreign key references donor (donorid),
Verf char(3),
BloodGroup char (3)foreign key references blood (bloodgroup),
statu varchar (300),
)



create table Detaildonor
(
ddid int primary key identity,
dated datetime, 
Donorid int foreign key references donor (donorid),
)

create table DetailCom
(
NumCom int foreign key references Commande(NumCom),
Bloodid int foreign key references labo(Bloodid),
Qte int,
primary key(numcom,Bloodid)
)


insert into blood values ('A-',600,0)
insert into blood values ('A+',700,68)
insert into blood values ('AB-',650,90)
insert into blood values ('AB+',730,71)
insert into blood values ('B-',620,59)
insert into blood values ('B+',550,1)
insert into blood values ('O-',800,80)
insert into blood values ('O+',880,53)


drop database BloodBank
drop table Hospital
SELECT * FROM donor
insert into Nurse values (1,'Lina','Atmani','123456','1995/05/05')

insert into  Detaildonor values ('2017/01/11',1 )

select * from Detaildonor