CREATE DATABASE RestaurantManagement

USE RestaurantManagement

Create Table [Table](
       id int identity primary key,
	   name nvarchar(100),
	   status bit
)
go
Create Table [Account](
	   displayName nvarchar(100) primary key,
	   userName nvarchar(100) not null,
	   password nvarchar(1000) not null,
	   role nvarchar(30) not null
)
go
Create Table [FoodCategory](
       id int identity primary key,
	   name nvarchar(100) default N'N/a'
)
go
Create Table [Food](
       id int identity primary key,
	   name nvarchar(100) not null default N'N/a',
	   idCategory int not null,
	   price float

	   foreign key (idCategory) references dbo.FoodCategory(id)
)

go
Create Table [Bill](
       id int identity primary key,
	   dateCheckIn Date not null Default getdate(),
	   dateCheckOut Date,
	   idTable int not null,
	   status bit not null

	   foreign key (idTable) references dbo.[Table](id)
)
go
Create table [BillInfo](
       id int identity primary key,
	   idBill int not null,
	   idFood int not null,
	   count int not null

	   foreign key (idBill) references dbo.Bill(id), 
	   foreign key (idFood) references dbo.Food(id)
)

