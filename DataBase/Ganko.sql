create database Ganko;

use Ganko;

create table resultTbl(
_id char(60) primary key,
createdAt datetime,
description char(120),
publishedAt datetime,
source char(20),
typeof char(20),
url char(100),
used bool,
who char(40)
);

create table images(
_id char(60),
imageurl char(120),
constraint fk_result foreign key (_id) references resultTbl(_id)
);

create table usrLogin(
_account varchar(80) primary key,
_password varchar(100) not null
);

create table usrHash(
_account varchar(80) primary key,
_password char(32) not null
);

create table usrDetail(
_account varchar(80) primary key,
_age smallint,
_company varchar(100),
_postion varchar(50)
);

create user 'gankio'@'localhost' identified by 'GankIO';
grant all on ganko.* to 'gankio'@'localhost';