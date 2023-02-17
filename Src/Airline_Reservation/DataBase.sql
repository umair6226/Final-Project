create database Airline_Reservation_System

use Airline_Reservation_System

drop database Airline_Reservation_System

create table tbl_Admin(
AdminID int primary key identity(1,1),
AdminName nvarchar(max),
UserName nvarchar(max),
Password nvarchar(max),
Mobile_No nvarchar(max),
Gender nvarchar(max),
Address nvarchar(max),
IsDeleted bit,
Status int,
CreatedAt datetime
)

create table tbl_Users(
UserID int primary key identity(1,1),
Name nvarchar(max),
Mobile_No nvarchar(max),
DOB date,
Age int,
Gender nvarchar(max),
UserName nvarchar(max),
Password nvarchar(max),
Address nvarchar(max),
IsDeleted bit,
Status int,
CreatedAt datetime
)

create table tbl_Ticket(
PNR_No int primary key identity(1,1),
Seat_No int,
Flight_No nvarchar(max),
PassengerID int foreign key references tbl_Users(UserID),
Class nvarchar(max),
Date_Time datetime,
Source nvarchar(max),
Destination nvarchar(max),
IsDeleted bit,
Status int,
BookedAt datetime
)

create table tbl_Flight(
Flight_No int primary key identity(1,1),
Flight_Name nvarchar(max),
Departure_Time datetime,
Travel_Duration nvarchar(max),
Source nvarchar(max),
Destination nvarchar(max),
Seat_Avalaible nvarchar(max),
Distance nvarchar(max),
AirlineID int foreign key references tbl_Airline(AirlineID),
IsDeleted bit,
Status int,
CreatedAt datetime,
CreatedBy int,
)

create table tbl_Class(
ClassID int primary key identity(1,1),
Fare money,
Class_Type nvarchar(max),
IsDeleted bit,
Status int,
CreatedAt datetime,
CreatedBy int,
)

create table tbl_FlightClass(
ID int primary key identity(1,1),
FlightID int foreign key references tbl_Flight(Flight_No),
ClassID int foreign key references tbl_Class(ClassID)
)

create table tbl_Airline(
AirlineID int primary key identity(1,1),
Airline_Name nvarchar(max),
Image nvarchar(max),
IsDeleted bit,
Status int,
CreatedAt datetime,
CreatedBy int,
)

Create table tbl_Payment(
PaymentID int primary key identity(1,1),
Transaction_ID int,
Payment_Mode nvarchar(max),
Amount money,
Passenger_ID int foreign key references tbl_Users(UserID),
IsDeleted bit,
Status int,
CreatedAt datetime,
CreatedBy int,
)

go;
alter proc SP_Airline
@AirlineID int =null,
@Airline_Name nvarchar(max)=null,
@Image nvarchar(max)=null,
@Status int=null,
@CreatedAt datetime=null,
@CreatedBy int=null,
@Type int
As
BEGIN
if(@Type=1)
Begin
insert into tbl_Airline values(@Airline_Name,@Image,0,@Status,GETDATE(),@CreatedBy)
End
if(@Type=2)
Begin
update tbl_Airline set Airline_Name=@Airline_Name,Image=@Image,Status=@Status where AirlineID=@AirlineID
End
if(@Type=3)
Begin
update tbl_Airline set IsDeleted=1 where AirlineID=@AirlineID
End
if(@Type=4)
Begin
select *from tbl_Airline where IsDeleted=0
End
if(@Type=5)
Begin
select *from tbl_Airline where IsDeleted=0 and AirlineID=@AirlineID
End
END
Go;

alter proc SP_Flights
@Flight_No int=null,
@Flight_Name nvarchar(max)=null,
@Departure_Time datetime=null,
@Travel_Duration nvarchar(max)=null,
@Source nvarchar(max)=null,
@Destination nvarchar(max)=null,
@Seat_Avalaible nvarchar(max)=null,
@Distance nvarchar(max)=null,
@AirlineID int=null,
@ClassID int=null,
@Status int=null,
@CreatedAt datetime=null,
@CreatedBy int=null,
@Type int
As
BEGIN
if(@Type=1)
Begin
insert into tbl_Flight values(@Flight_Name,@Departure_Time,@Source,@Destination,
								@Seat_Avalaible,@Distance,@AirlineID,0,@Status,GETDATE(),@CreatedBy,@Travel_Duration)
End
if(@Type=2)
Begin
update tbl_Flight set Flight_Name=@Flight_Name,Departure_Time=@Departure_Time,Travel_Duration=@Travel_Duration,
					  Source=@Source,Destination=@Destination,Seat_Avalaible=@Seat_Avalaible,Distance=@Distance,
					  AirlineID=@AirlineID,Status=@Status where Flight_No=@Flight_No
End
if(@Type=3)
Begin
update tbl_Flight set IsDeleted=1 where Flight_No=@Flight_No
End
if(@Type=4)
Begin
select Flight_No,Flight_Name,Departure_Time,Source,Destination,Class_Type,Fare,Seat_Avalaible,Distance,F.AirlineID,F.Status,Image,Airline_Name,Travel_Duration
from tbl_Flight F inner join tbl_Airline A
on F.AirlineID=A.AirlineID inner join tbl_FlightClass FC
on F.Flight_No=FC.FlightID inner join tbl_Class C 
on C.ClassID=FC.ClassID where C.ClassID=@ClassID and (@Flight_No is null or Flight_No=@Flight_No) and F.IsDeleted=0
End
if(@Type=5)
Begin
select *from tbl_Flight where IsDeleted=0 and Flight_No=@Flight_No
End
END
Go;


alter proc SP_Class
@ClassID int =null,
@Fare money=null,
@Class_Type nvarchar(max)=null,
@Status int=null,
@CreatedAt datetime=null,
@CreatedBy int=null,
@Type int
As
BEGIN
if(@Type=1)
Begin
insert into tbl_Class values(@Fare,@Class_Type,0,@Status,GETDATE(),@CreatedBy)
End
if(@Type=2)
Begin
update tbl_Class set Fare=@Fare,Class_Type=@Class_Type,Status=@Status where ClassID=@ClassID
End
if(@Type=3)
Begin
update tbl_Class set IsDeleted=1 where ClassID=@ClassID
End
if(@Type=4)
Begin
select *from tbl_Class where IsDeleted=0
End
if(@Type=5)
Begin
select *from tbl_Class where IsDeleted=0 and ClassID=@ClassID
End
END
Go;

select Flight_No,Flight_Name,Departure_Time,Source,Destination,Class_Type,Fare,Seat_Avalaible,Distance,F.AirlineID,F.Status,Image,Airline_Name,Travel_Duration
from tbl_Flight F inner join tbl_Airline A
on F.AirlineID=A.AirlineID inner join tbl_FlightClass FC
on F.Flight_No=FC.FlightID inner join tbl_Class C 
on C.ClassID=FC.ClassID where C.ClassID=1

insert into tbl_FlightClass values(1,1),(1,3),(2,1),(2,3),(3,1),(3,1),(3,3)
select *from tbl_FlightClass