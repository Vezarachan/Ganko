create database Ganko;

create user 'gankio'@'localhost' identified by 'GankIO';
grant all on testganko.* to 'gankio'@'localhost';

use testGanko;

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