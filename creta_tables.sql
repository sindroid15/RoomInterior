use Room_Interior
go
create table [Role]
(
IdRole int identity(1,1) primary key not null,
NameRole nvarchar(100) not null
)
go 
create table [User]
(
IdUser int identity(1,1) primary key not null,
IdRole int not null,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Patronymic nvarchar(100) not null,
Phone nvarchar(10) not null,
EMail nvarchar(50) not null,
PhotoUser varbinary(max) null,
Login nvarchar(50) not null,
[Password] nvarchar(50) not null,
foreign key (IdRole) references [Role](IdRole)
)
go
create table Category
(
IdCategory int identity(1,1) primary key not null,
NameCategory nvarchar(100) not null
)
go
create table Product
(
IdProduct int identity (1,1) primary key not null,
IdCategory int not null,
Price decimal(12,2) not null,
PhotoProduct varbinary(max) null,
Material nvarchar(100) not null,
[Description] nvarchar(100) not null,
NameProduct nvarchar(50) null,
foreign key (IdCategory) references Category(IdCategory)
)
go
create table Basket
(
IdBasket int identity (1,1) primary key not null,
IdProduct int not null,
IdUser int not null,
Price decimal(12,2) not null,
foreign key (IdProduct) references Product(IdProduct),
foreign key (IdUser) references [User](IdUser)
)
go
create table [Order]
(
IdOrder int identity(1,1) primary key not null,
IdBasket int not null,
[Date] date not null,
foreign key (IdBasket) references Basket(IdBasket)
)