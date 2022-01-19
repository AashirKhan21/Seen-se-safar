Create Database SeenseSafar
Use SeenseSafar
GO
create table tbl_Booking(
	Booking_ID int primary key identity(1,1),
	Booking_Title varchar(50),
	Booking_Type varchar(50),
	Booking_Date datetime,
	Booking_Desc varchar(50)
)


create table tbl_User(
	[User_ID] int primary key identity(1,1),
	[User_Name] varchar(100),
	[User_Email] varchar(100),
	[User_Password] varchar(100),
	[User_Contact] bigint,
	[User_Role] varchar(100)
)


create table tbl_Hotel(
	Hotel_ID int primary key identity(1,1),
	Hotel_Name varchar(50),
	Hotel_Type varchar(50),
	Hotel_Desc varchar(150),
	Hotel_Contact varchar(50),
	Hotel_Address nvarchar(200)
)

create table tbl_Room(
	Room_ID int primary key identity(1,1),
	Room_Hotel_ID int foreign key references tbl_Hotel(Hotel_ID),
	Room_Type nvarchar(150),
	Room_Rent_Per_Day decimal(18,2)
)

create table tbl_Food(
	Food_ID int primary key identity(1,1),
	Food_Name varchar(50),
	Food_Type varchar(50),
	Food_Price decimal(18,2)
)


create table tbl_Airplane(
	Airplane_ID int primary key identity(1,1),
	Airplane_Model_Number int,
	Airplane_Capacity int
)

create table tbl_Flight(
	Flight_ID int primary key identity(1,1),
	Flight_From varchar(100),
	Flight_To varchar(100),
	Flight_Departure_Date date,
	Flight_Departure_Time datetime,
	Flight_Arrival_Date date,
	Flight_Arrival_Time datetime
)


create table tbl_Package(
	Package_ID int primary key identity(1,1),
	Package_Name varchar(50),
	Package_Price decimal(18,2),
	Package_Desc varchar(100),
	Package_Days int
)

/*STORED PROCEDURES*/
/* USER GET PROCEDURE */
CREATE PROCEDURE sp_Get_Users
AS
  BEGIN
	Select User_ID, User_Name, User_Email, User_Role, User_Contact from tbl_User
   END
GO
/*USER DELETE PROCEDURE*/
CREATE PROCEDURE sp_Delete_User(
	@id int
)
AS
BEGIN
	Delete from tbl_User where User_ID like @id
END
/*HOTEL INSERT PROCEDURE*/
Create Procedure sp_Insert_Hotel(
	@name varchar(50),
	@type varchar(50),
	@desc varchar(150),
	@contact nvarchar(50),
	@address nvarchar(200)
)
AS
BEGIN
	Insert into tbl_Hotel(Hotel_Name, Hotel_Type, Hotel_Desc, Hotel_Contact, Hotel_Address)
	values (@name, @type, @desc, @contact, @address)
END
/* GET HOTELS */
CREATE PROCEDURE sp_Get_Hotels
AS
  BEGIN
	Select Hotel_ID, Hotel_Name, Hotel_Type, Hotel_Desc, Hotel_Contact, Hotel_Address from tbl_Hotel
   END
GO
/* UPDATE HOTELS */
Create Procedure sp_Update_Hotel(
    @id int,
	@name varchar(50),
	@type varchar(50),
	@desc varchar(150),
	@contact nvarchar(50),
	@address nvarchar(200)
)
AS
BEGIN
	Update tbl_Hotel set Hotel_Name = @name, Hotel_Type = @type, Hotel_Desc = @desc,
	Hotel_Contact = @contact, Hotel_Address = @address where Hotel_ID like @id
END
/* DELETE HOTEL */
CREATE PROCEDURE sp_Delete_Hotel(
	@id int
)
AS
BEGIN
	Delete from tbl_Hotel where Hotel_ID like @id
END
/*=======================================================*/

/*========================ROOM========================*/
/*INSERT ROOMS*/
/*ROOM INSERT PROCEDURE*/
Create Procedure sp_Insert_Room(
	@hid int,
	@type nvarchar(150),
	@rent decimal(18,2)
)
AS
BEGIN
	Insert into tbl_Room(Room_Hotel_ID, Room_Type, Room_Rent_Per_Day)
	values (@hid, @type, @rent)
END

/* GET ROOM */
CREATE PROCEDURE sp_Get_Room
AS
  BEGIN
	Select Room_ID,Room_Hotel_ID,Room_Type,Room_Rent_Per_Day from tbl_Room
   END
GO

/*ROOM UPDATE PROCEDURE*/
Create Procedure sp_Update_Room(
    @id int,
	@hid int,
	@type nvarchar(150),
	@rent decimal(18,2)
)
AS
BEGIN
	Update tbl_Room set Room_Hotel_ID = @hid	, Room_Type = @type, Room_Rent_Per_Day = @rent
	where Room_ID like @id
END

/* DELETE HOTEL */
CREATE PROCEDURE sp_Delete_Room(
	@id int
)
AS
BEGIN
	Delete from tbl_Room where Room_ID like @id
END
