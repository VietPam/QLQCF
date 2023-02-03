CREATE DATABASE QuanLyQuanCafeGKMoi
go
USE QuanLyQuanCafeGKMoi
go
set dateformat dmy
go
--tao bang
CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) DEFAULT N'Bàn chưa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống',	-- Trống hoặc có người
	Active int default 1,
	Type int default 0 -- 0:thuong 1: vip
)

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Tên hiển thị',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0, -- 0: admin && 1: staff
	Active int default 1,
	Picture image,
)

CREATE TABLE FoodCategory
(
	ID_FoodCategory INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	Active int default 1
)

CREATE TABLE Food
(
	ID_Food INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	ID_FoodCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	Active int default 1,
	TotalCount int default 0,
	
	FOREIGN KEY (ID_FoodCategory) REFERENCES FoodCategory(ID_FoodCategory)
)

CREATE TABLE Bill
(
	ID_Bill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETime NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	ID_TableFood INT NOT NULL, 
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán && -1:bill bị huỷ do huỷ món hoặc gộp bàn
	totalPrice int default 0,--them default
	discount INT default 0,--them default
	ID_User NVARCHAR(100)
	
	FOREIGN KEY (ID_TableFood) REFERENCES TableFood(ID_TableFood)
)

CREATE TABLE BillInfo
(
	ID_BillInfo int IDENTITY PRIMARY KEY,
	ID_Bill INT not null,
	ID_Food INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (ID_Bill) REFERENCES Bill(ID_Bill),
	FOREIGN KEY (ID_Food) REFERENCES dbo.Food(ID_Food)
)

Create Table Shop
(
NameShop NVARCHAR(100) NOT NULL DEFAULT N'CoffeShop',
Wifi NVARCHAR(100) NOT NULL DEFAULT N'Chưa có',
PassWifi NVARCHAR(100) NOT NULL DEFAULT N'Chưa có',
NumberTable int NOT NULL DEFAULT 0,
Slogan Nvarchar(100) not null default N'Vui Lòng Khách Đến Vừa Lòng Khách Đi!',
Encouragement Nvarchar(100) not null default N'Hãy Hết Mình Về Công Việc',
ShopAddress Nvarchar(100) default N'Chưa Có',
PhoneNumber Varchar(10) not null default '0000000000',
GoodByeSentence Nvarchar(100) default N'Xin Chào Và Hẹn Gặp Lại',
SurCharge int default 0,
VipCost int default 5000
)


Create Table Discount
(
Rate float primary key,
Money int default -1 -- !=-1 => co giam giam ,= -1 => khong giam gia
)

Create Table DiscountCode
(
Code nvarchar(10) primary key,
Rate float,
DayTake Smalldatetime,
foreign key (Rate) references Discount(Rate),
Number int default 1
)
go

Create Table SurCharge
(
iHour int default 0, --thuoc tinh =0 -> không cài đặt =1 -> cài đặt
iDay int default 0, 
iDayofWeek int default 0,
HourStart int default 0,
HourEnd int default 0,
DayStart datetime default 1/1/1900,
DayEnd datetime default 1/1/1900,
DateofWeek varchar(7) default '0000000'
)


--insert
insert into SurCharge(iHour) values(0)

insert into Discount(Rate) values(0)
insert into Discount(Rate) values(0.05)
insert into Discount(Rate) values(0.1)
insert into Discount(Rate) values(0.15)
insert into Discount(Rate) values(0.2)
insert into Discount(Rate) values(0.25)
insert into Discount(Rate) values(0.3)
insert into Discount(Rate) values(0.35)
insert into Discount(Rate) values(0.4)
insert into Discount(Rate) values(0.45)
insert into Discount(Rate) values(0.5)
insert into Shop(NameShop) values('CoffeShop')


insert into Account(UserName,DisplayName,Password,Type,Active)
values ('admin',N'Quản lý','1962026656160185351301320480154111117132155',0,1)



insert into Account(UserName,DisplayName,Password,Type,Active)
values ('tuan',N'Quản lý','1962026656160185351301320480154111117132155',0,1)

insert into Account(UserName,DisplayName,Password,Type,Active)
values ('viet',N'Quản lý','1962026656160185351301320480154111117132155',0,1)

insert into Account(UserName,DisplayName,Password,Type,Active)
values ('dong',N'Quản lý','1962026656160185351301320480154111117132155',0,1)

insert into Account(UserName,DisplayName,Password,Type,Active)
values ('tri',N'Quản lý','1962026656160185351301320480154111117132155',0,1)

--INSERT FOODCATE
INSERT INTO FoodCategory (name ) VALUES (N'Cafe')
INSERT INTO FoodCategory (name ) VALUES (N'Trà sữa')
INSERT INTO FoodCategory (name ) VALUES (N'Sinh tố')
INSERT INTO FoodCategory (name ) VALUES (N'Chè')
INSERT INTO FoodCategory (name ) VALUES (N'Ðá xay')
INSERT INTO FoodCategory (name ) VALUES (N'Nước ngọt')
INSERT INTO FoodCategory (name ) VALUES (N'Mì cay')
INSERT INTO FoodCategory (name ) VALUES (N'Ăn vặt')
INSERT INTO FoodCategory (name ) VALUES (N'Phụ Thu')
---- INSERT FOOD
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe đá',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe nóng',1, 18000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe sữa đá',1, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cafe sữa nóng',1, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa truyền thống',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa nho',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa socola',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa kiwi',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa dâu',2, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Trà sữa bạc hà',2, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố bơ',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố dâu',3, 30000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố mít',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố xoài',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố đu đủ',3, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sinh tố sapôchê',3, 25000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè thái',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè bưởi',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè thập cẩm',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè đậu xanh',4, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Chè đậu đen',4, 20000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Caramel đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Cacpuccino đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Matcha đá xay',5, 35000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Socola đá xay',5, 35000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Sting',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'CocaCola',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'7Up',6, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Pepsi',6, 10000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay bò',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay bò Mỹ',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay hải sản',7, 40000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Mì cay trứng',7, 40000)

INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bò cá viên chiên',8, 25000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh tráng trộn',8, 20000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh bao chiên',8, 10000)
INSERT INTO Food (NameFood, ID_FoodCategory, Price) VALUES (N'Bánh sầu riêng',8, 15000)


go


--CÁC HÀM SỬ DỤNG
--Thanh toán hóa đơn
Create PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			ID_TableFood,
			status,
			discount
			)
	VALUES (GETDATE(), --DataCheckIn - date
			NULL, --DataCheckOut - date
			@idTable, --ID_TableFood - int
			0,	-- status - int
			0
			)
END
go

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT dbo.BillInfo
			(ID_Bill,
			ID_Food,
			count
			)
	VALUES (@idBill,
			@idFood,
			@count
			)
END
go

--LoadTableFood
Create proc USP_LoadTableFood
as
begin
	select ID_TableFood as [ID], NameTable as [Tên Bàn] ,StatusTable as [Trạng Thái],Active,Type from TableFood where Active=1
end
go

--Login
CREATE PROC USP_Login
@username varchar(100),@password varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username AND Password = @password AND Active = 1
END
go
-- INSERT BAN AN
Create proc USP_InsertTable
@sl int
as
DECLARE @i INT = 1,@id_table int
select @id_table=max(ID_TableFood)+1 from TableFood
WHILE @i <= @sl
BEGIN
	INSERT DBO.TableFood(NameTable) values ('Bàn ' + CAST(@id_table AS nvarchar(100)))
	SET @i = @i + 1
END
go

--UPDATE ACCOUNT
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @userName and PassWord = @password
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE UserName = @userName
		END
		ELSE
			UPDATE Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
 	END
END
go
--cai dat shop
CREATE PROC USP_InsertShop
@nameShop nvarchar(100), @wifi nvarchar(100), @passwifi nvarchar(100),@numberTable int,@slogan nvarchar(100),@encouragement nvarchar(100),@shopAddress nvarchar(100),@phoneNumber nvarchar(100),@goodByeSentence nvarchar(100),@sucharge int,@vipcost int
AS
BEGIN
	Update dbo.Shop set NameShop=@nameShop,Wifi=@wifi,PassWifi=@passwifi,NumberTable=@numberTable,Slogan=@slogan,Encouragement=@encouragement,ShopAddress=@shopAddress,PhoneNumber=@phoneNumber,GoodByeSentence=@goodByeSentence,SurCharge=@sucharge,VipCost=@vipcost
END
go

CREATE PROC USP_GetListBillByDate
@checkIn date,@checkout date
AS
BEGIN
	SELECT /*b.ID_Bill AS [ID Bill],*/ t.NameTable AS [Tên bàn], /*b.ID_User AS [Người thu],*/ DateCheckIn AS [Ngày vào],DateCheckOut AS [Ngày ra], /*discount AS [Giảm giá],*/ b.totalPrice AS [Tổng tiền]
	FROM dbo.Bill as b, dbo.TableFood as t
	WHERE DateCheckIn>=@checkIn AND DateCheckOut<=@checkout AND b.status=1 AND t.ID_TableFood=b.ID_TableFood
END
go
--doi ten ban
create Trigger Ins_TableName
on TableFood
for insert
as
begin
Declare @id int
select @id=ID_TableFood from inserted 
if(@id is not null)
begin
	update TableFood set NameTable='Bàn ' + CAST(@id AS nvarchar(100)) where ID_TableFood=@id
	end
end
go
--tao code ngau nhien
create proc USP_InsertCode
@code varchar(10),@rate float
as
begin
	Insert into DiscountCode(Code,Rate,DayTake) values(@code,@rate,GETDATE())
end 
go
--lay ti le giam gia
create proc USP_GetRate
@code varchar(10)
as
begin
select Discount.Rate,Discount.Money from Discount,DiscountCode where Code=@code
and Discount.Rate=DiscountCode.Rate
end
go

--tao code co so luong
create proc USP_InsertCode2
@code nvarchar(10),@rate float,@number int
as
begin
	Insert into DiscountCode(Code,Rate,DayTake,Number) values(@code,@rate,GETDATE(),@number)
end 
go

create proc USP_UpdateCode
@code nvarchar(10),@rate float,@number int
as
begin
	update DiscountCode set Rate=@rate,Number=@number where Code=@code
end 
go

create proc USP_ChangeDay
@datestart datetime,@dateend datetime
as begin
	update SurCharge set DayStart=@datestart, DayEnd=@dateend
end
go

select * from Shop
