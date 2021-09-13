


Create table Customer(Id int IDENTITY(1,1)Primary key,F_Name varchar(100),L_Name varchar(100),Dob Varchar(100),Mobile varchar(100),Email varchar(225),Locations varchar(225));
Select * from Customer;
Create table Login(Id int IDENTITY(1,1),UserName varchar(100),Password varchar(100),C_Id int foreign key references Customer(Id));
Select * from Login;

create PROC InsertReg  @F_Name varchar(max),@L_Name varchar(max),@Dob varchar(max),@Mobile varchar(max),  @Email varchar(max),@Locations varchar(max)
as
insert into Customer(F_Name, L_Name,Dob,Mobile, Email,Locations) values(@F_Name, @L_Name,@Dob,@Mobile, @Email,@Locations)SELECT SCOPE_IDENTITY();


EXEC InsertReg @Name="Abc", @Zipcode=1,@Email="Abc@gmail.com"
select * from Customer
select * from Login;

create PROC InsertLog  @Username varchar(max),  @Password varchar(max), @C_Id  int 
as
insert into Login(Username, Password, C_Id) values(@Username, @Password, @C_Id);


EXEC InsertReg @Name="Abc", @Zipcode=1,@Name="Abc@gmail.com"


create procedure LoginUser
(
@Username varchar(100),
@Password varchar(100)
)
AS 
BEGIN
	SET NOCOUNT ON
	declare @Userid int

	select @Userid = C_id from Login where UserName=@Username and [Password]=@Password

	if @Userid is not null
	Begin
	select @Userid
	end
	else
	Begin 
	select -1
	end
END


