CREATE DATABASE QuanLyQuanCafeGKMoi
go
USE QuanLyQuanCafeGKMoi
go

CREATE TABLE TableFood
(
	ID_TableFood INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống',	-- Trống hoặc có người
	Active int default 1
)
go


CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Tên hiển thị',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0, -- 0: admin && 1: staff
	Active int default 1,
	Picture image,
)
go

CREATE TABLE FoodCategory
(
	ID_FoodCategory INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	Active int default 1
)
go

CREATE TABLE Food
(
	ID_Food INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	ID_FoodCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	Active int default 1,

	
	FOREIGN KEY (ID_FoodCategory) REFERENCES FoodCategory(ID_FoodCategory)
)
go

CREATE TABLE Bill
(
	ID_Bill INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	ID_TableFood INT NOT NULL, 
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán && -1:bill bị huỷ do huỷ món hoặc gộp bàn
	totalPrice int default 0,--them default
	discount INT default 0,--them default
	ID_User NVARCHAR(100)
	
	FOREIGN KEY (ID_TableFood) REFERENCES TableFood(ID_TableFood)
)
go
CREATE TABLE BillInfo
(
	ID_BillInfo int IDENTITY PRIMARY KEY,
	ID_Bill INT not null,
	ID_Food INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (ID_Bill) REFERENCES Bill(ID_Bill),
	FOREIGN KEY (ID_Food) REFERENCES dbo.Food(ID_Food)
)
go



--//CSDL Form đăng nhập
		
insert into Account(UserName,DisplayName,Password,Type,Active)
values ('admin',N'Quản lý','1962026656160185351301320480154111117132155',0,1)
go
insert into Account(UserName,DisplayName,Password,Type,Active)
values ('tuan',N'Quản lý','1962026656160185351301320480154111117132155',0,1)
go
insert into Account(UserName,DisplayName,Password,Type,Active)
values ('viet',N'Quản lý','1962026656160185351301320480154111117132155',0,1)
go
insert into Account(UserName,DisplayName,Password,Type,Active)
values ('dong',N'Quản lý','1962026656160185351301320480154111117132155',0,1)
go
insert into Account(UserName,DisplayName,Password,Type,Active)
values ('tri',N'Quản lý','1962026656160185351301320480154111117132155',0,1)
go





--INSERT FOODCATE
INSERT INTO FoodCategory (name ) VALUES (N'Cafe')
INSERT INTO FoodCategory (name ) VALUES (N'Trà sữa')
INSERT INTO FoodCategory (name ) VALUES (N'Sinh tố')
INSERT INTO FoodCategory (name ) VALUES (N'Chè')
INSERT INTO FoodCategory (name ) VALUES (N'Ðá xay')
INSERT INTO FoodCategory (name ) VALUES (N'Nước ngọt')
INSERT INTO FoodCategory (name ) VALUES (N'Mì cay')
INSERT INTO FoodCategory (name ) VALUES (N'Ăn vặt')

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
GO	


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
GO


--LoadTableFood
Create proc USP_LoadTableFood
as
begin
	select ID_TableFood as [ID], NameTable as [Tên Bàn] ,StatusTable as [Trạng Thái],Active from TableFood
end
go
--Login
CREATE PROC USP_Login
@username varchar(100),@password varchar(100)
AS
BEGIN
	SELECT *FROM Account WHERE UserName = @username AND Password = @password AND Active = 1
END
GO



-- INSERT BAN AN
DECLARE @i INT = 1

WHILE @i <= 10
BEGIN
	INSERT DBO.TableFood(NameTable) VALUES ('Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
Go


select * from Account
