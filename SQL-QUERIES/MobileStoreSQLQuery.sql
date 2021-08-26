DROP TABLE Customer


CREATE tABLE Customer(
	C_id int identity(1,1) primary key,
	Username varchar(20) Unique not null,
	F_Name varchar(10) not null,
	L_Name varchar(10) not null,
	Dob datetime,
	Mobile varchar(10) not null,
	Email varchar(20) not null,
	Locations Varchar(20) not null
);

INSERT INTO Customer VALUES
	('Samuel123', 'Samuel', 'Joy', '2000-05-11', '1234567890', 'samuel@gmai.com', 'Thane'),
	('Kajal123', 'Kajal', 'Rajput', '2000-10-11', '1234567890', 'kajal@gmai.com', 'Ghatkopar'),
	('Raj123', 'Raj', 'Bhosale', '1999-02-14', '1234567890', 'raj@gmai.com', 'Thane'),
	('Lucky123', 'Lucky', 'Pareek', '1999-05-16', '1234567890', 'lucky@gmai.com', 'Kurla');


DROP TABLE Login

CREATE TABLE Login(
	L_id int identity(1,1) primary key,
	Pwd varchar(20) not null,
	Roles varchar(20) not null,
	Username varchar(20) foreign key references Customer(Username)
);

INSERT INTO Login VALUES
	('Samuel1', 'Customer', 'Samuel123'),
	('Kajal1', 'Customer', 'Kajal123'),
	('Raj11', 'Customer', 'Raj123'),
	('Lucky1', 'Customer', 'Lucky123');


DROP TABLE Company

CREATE TABLE Company(
	CN_id int identity(1,1) primary key,
	C_Name varchar(20) not null,
	M_Name varchar(20) not null
);

INSERT INTO Company VALUES
	('Redmi', 'Note12'),
	('Oppo', 'v27'),
	('Samsung', 'N32'),
	('Redmi', 'Note9');


DROP TABLE Store

CREATE TABLE Store(
	S_id int identity(1,1) primary key,
	Locations varchar(100) not null,
	S_Name varchar(100) not null
);


INSERT INTO Store VALUES
	('Mumbai', 'Top'),
	('Pune', 'Abcd'),
	('Thane', 'Pqrs'),
	('Kurla', 'Xyz');

SELECT * FROM Store;

DROP TABLE Product

CREATE TABLE Product(
	P_id int identity(1,1) primary key,
	Ram int not null,
	Storage int not null,
	Color varchar(20)  not null,
	Price int not null,
	Statuss bit not null,
	CN_id int foreign key references Company(CN_id),
	S_id int foreign key references Store(S_id)	
);

INSERT INTO Product VALUES
	(8, 128, 'Black', 25000, 1, 1,2),
	(6, 64, 'White', 15000, 1, 3,2),
	(8, 64, 'Blue', 30000, 1, 4,1),
	(6, 128, 'Purple', 20000, 1, 2,4);

SELECT * FROM Product;


DROP TABLE Cart

CREATE TABLE Cart(
	A_id int identity(1,1) primary key,
	T_Price int not null,
	Username varchar(20) foreign key references Customer(Username),
	P_id int foreign key references Product(P_id)	
);


DROP TABLE Orders

CREATE TABLE Orders(
	O_id int identity(1,1) primary key,
	Mode varchar(20) not null,
	Order_date datetime,
	A_id int foreign key references Cart(A_id)	
);






