create database Hotel_Management_System

set identity_insert tblroomtype on

create table tblRoomType
(
  RoomTypeID int primary key identity (1, 1),
  RoomType nvarchar(150) not null,
  RoomDescription nvarchar(150) not null,
  RoomStatus nvarchar(150) not null,
  RoomCost int not null
)

insert into tblRoomtype(RoomTypeID,roomtype,RoomDescription,RoomStatus,roomcost)values(50,'double','Good for all','available',5000);

create table tblRoom
(
  RoomID int primary key,
  RoomTypeID int references tblRoomType(RoomTypeID),
  RoomNumber nvarchar(150) not null,
  Room_Discription nvarchar(150) not null,
  Room_Status nvarchar(150) not null
)
alter table tblRoom
add Room_Cost int

insert into tblCustomers(customerID,CustomerName,CustomerAddress,ContactNo,Gender,CNIC)values(201,'ali','karachi',03002442006,'male',42301-41523347);
insert into tblCustomers(customerID,CustomerName,CustomerAddress,ContactNo,Gender,CNIC)values(202,'shahryar','karachi',03003465247,'male',42301-41523348);
insert into tblCustomers(customerID,CustomerName,CustomerAddress,ContactNo,Gender,CNIC)values(203,'imran','karachi',03003465147,'male',42301-41523448);

select * from tblEmployee

create table tblCustomers
(
  CustomerID int primary key ,
  CustomerName nvarchar(150) not null,
  CustomerAddress nvarchar(150) not null,
  ContactNo nvarchar(150) not null,
  Gender nvarchar(150) not null,
  CNIC nvarchar(150) not null,
  
)

create table tblBooking
(
  BookingID int primary key ,
  RoomID int references tblRoom(RoomID),
  CustomerID int references tblCustomers(CustomerID),
  BookingDate date not null,
  BookingStatus nvarchar(150) not null
)

create table tblCheckIN(

CustomerID int references tblCustomers(CustomerID),
Customer_Name nvarchar(150) not null,
C_Address nvarchar(150) not null,
Contact_No nvarchar(150) not null,
Country nvarchar(150) not null
  
)

create table tblPayment
(
  PaymentId int primary key ,
  BookingID int references tblBooking(BookingID),
  PaymentType nvarchar(150) not null,
  Amount int not null,
  PaymentDetails nvarchar(150) not null,
  PaymemntDate date not null,
  PaymentStatus nvarchar(150) not null
)
insert into tblPayment(PaymentId,BookingID,PaymentType,Amount,PaymentDetails,PaymemntDate,PaymentStatus)values(99958,998,'credit card',15000,'PayPal','1-1-22','Received')
insert into tblPayment(PaymentId,BookingID,PaymentType,Amount,PaymentDetails,PaymemntDate,PaymentStatus)values(99959,997,'credit card',17000,'PayPal','1-1-22','Received')
insert into tblPayment(PaymentId,BookingID,PaymentType,Amount,PaymentDetails,PaymemntDate,PaymentStatus)values(99960,991,'credit card',16000,'PayPal','1-1-22','Received')

create table tblFoodItem
(
  ItemID int primary key,
  ItemType nvarchar(150) not null,
  ItemName nvarchar(150) not null,
  ItemCost int not null,
  ItemDetails nvarchar(150) not null,
  ItemStatus nvarchar(150) not null
)
insert into tblFoodItem(ItemID,ItemType,ItemName,ItemCost,ItemDetails,ItemStatus)values(5889,'fast food','Chicken Burger',320,'with fries','available')
drop table tblOrder
create table tblOrder
(
  OrderID int primary key ,
  ItemID int references tblFoodItem(ItemID),
  BookingDate date not null,
  OrderDate date not null,
  Quantity int not null,
  Cost int not null,
  OrderDetails nvarchar(150) not null
)
alter table tblOrder 
add Customer_ID int references tblCustomers(CustomerID)

insert into tblOrder(OrderID,ItemID,BookingDate,OrderDate,Quantity,Cost,OrderDetails,Customer_ID)values(115,5889,'1-1-22','1-1-22',03,960,'Waiting',201)
insert into tblOrder(OrderID,ItemID,BookingDate,OrderDate,Quantity,Cost,OrderDetails,Customer_ID)values(116,5889,'1-1-22','1-1-22',03,960,'Waiting',202)
insert into tblOrder(OrderID,ItemID,BookingDate,OrderDate,Quantity,Cost,OrderDetails,Customer_ID)values(117,5889,'1-1-22','1-1-22',03,960,'Waiting',203)
select * from tblOrder

create table tblEmployee
(
  EmployeeID int primary key ,
  EmployeeName nvarchar(150) not null,
  LoginID nvarchar(150) not null,
  LoginPassword nvarchar(150) not null,
  EmployeeType nvarchar(150) not null,
  EmployeeStatus nvarchar(150) not null
)
insert into tblEmployee(EmployeeID,EmployeeName,LoginID,LoginPassword,EmployeeType,EmployeeStatus)values(11158,'Shahryar',89,'123','part time','available')



insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(992,12,201,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(993,13,202,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(994,101,203,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(995,100,202,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(996,99,201,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(997,10,203,'2-2-2021','Booked');
insert into tblBooking(BookingID,RoomID,CustomerID,BookingDate,BookingStatus)values(998,11,203,'2-2-2021','Booked');

CREATE TABLE tblFeedback
  (Feedback_ID INT IDENTITY(1,1) PRIMARY KEY, 
   Feedback_Sbj VARCHAR(500) not null,
   Feedback_Msg VARCHAR(MAX) not null,
   CustomerName  nVARCHAR(150) not null,
   CustomerID int references tblCustomers(CustomerID),
   Email VARCHAR(150) not null,
   ReceivedDate DATETIME Default(GETDATE()) 
   )

create table EmployeeAudit(
ID int,
Audit_Details nvarchar(255)
);

insert into tblFeedback(Feedback_Sbj,Feedback_Msg,CustomerName,CustomerID,Email)values('Quality of Food','Surprisingly! food quality is awesome','shahryar',201,'sheryar@gmail.com')
select * from tblFoodItem
delete from tblOrder where OrderID=115


--JOINS :

select CustomerName, OrderDate, Quantity,Cost from tblCustomers FULL JOIN tblOrder ON tblCustomers.CustomerID =
tblOrder.Customer_ID

select CustomerName, OrderDate, Quantity,Cost from tblCustomers Inner Join tblOrder ON tblCustomers.CustomerID =
tblOrder.Customer_ID


select CustomerName, OrderDate, Quantity,Cost from tblCustomers Left Join tblOrder ON tblCustomers.CustomerID =
tblOrder.Customer_ID

select CustomerName, OrderDate, Quantity,Cost from tblCustomers Right Join tblOrder ON tblCustomers.CustomerID =
tblOrder.Customer_ID

--union:

SELECT CustomerName, CustomerID FROM tblCustomers
WHERE CustomerID=201
UNION
SELECT CustomerName, CustomerID  FROM tblFeedback
WHERE CustomerID=201
ORDER BY CustomerName;

--Stored procedures

create procedure insert_records_tblFoodItem
@ItemID int,
@ItemType nvarchar(150), 
@ItemName nvarchar(150),
@ItemCost int,
@ItemDetails nvarchar(150),
@ItemStatus nvarchar(150)
as
begin
insert into tblFoodItem(ItemID,ItemType,ItemName,ItemCost,ItemDetails,ItemStatus)
values(@ItemID,@ItemType,@ItemName,@ItemCost,@ItemDetails,@ItemStatus);
end
exec insert_records_tblFoodItem 5990,'FastFood','Pizza',2000,'with extra topping','available'


create procedure update_records_tblFoodItem
@ItemID int,
@ItemName nvarchar(150)
as
begin
update tblFoodItem set ItemName=@ItemName where ItemID=@ItemID
end
exec update_records_tblFoodItem 5889, 'Zinger burger'

--triggers
select * from tblFoodItem

create trigger insert_trgerr
on tblEmployee
for insert
as
begin
declare @EmployeeID int
select @EmployeeID= EmployeeID from tblEmployee
insert into employeeaudit values (@EmployeeID,'Record is inserted on'+CAST(GETDATE() as nvarchar));
end
insert into tblEmployee values(10,'Shahryar',11158,'123','part time','available')

select * from tblEmployee
select * from EmployeeAudit

--wildcard:
SELECT * FROM tblCustomers
WHERE CustomerAddress LIKE '_arachi';

select * from tblEmployee