use master;
go

if DB_ID('GamePuzzle') is not null
	drop database GamePuzzle;
go

create database GamePuzzle;
go

use GamePuzzle;
go

create table DBSCORE
	(	UserName		varchar(15),
		CountS		int,
		lv		int,
	 primary key (UserName)
	);

Go
