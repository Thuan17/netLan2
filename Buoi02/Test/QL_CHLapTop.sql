Create Database QL_CHLapTop
go 

use QL_CHLapTop 
go

create table RoleUse(
 IdRole char(15),
 NameRole nvarchar(max),
)
go

DECLARE @char int = 0
DECLARE @charI INT = 0
DECLARE @password VARCHAR(100) = ''
DECLARE @len INT = 12 -- Cấu hình chiều dài mật khẩu
WHILE @len > 0
BEGIN
SET @charI = ROUND(RAND()*100,0)
SET @char = @charI
 
IF @charI > 48 AND @charI < 122
BEGIN
SET @password += @char
SET @len = @len - 1
END
END
SELECT @password [PassWord]

SELECT ch(RAND()*(10-5+1)+5);


DECLARE @charI INT = 0
SET @charI = ROUND(RAND()*10000,0)

SELECT @charI
SELECT FLOOR(RAND(123456)*(20-10+1))+10;

SELECT FLOOR(RAND()*(1000-5+1)+100);

CREATE TABLE NHANVIEN(

	IDNHANVIEN NCHAR(10) PRIMARY KEY,
	HOTENNHANVIEN NVARCHAR(100),
	GIOTINH NVARCHAR(10),
	CMND NVARCHAR(12),
	DIACHI NVARCHAR(100),
	EMAIL NVARCHAR(100),
	SDT NVARCHAR(12),
	USERNAME NCHAR(100),
	PASS NCHAR(100),
	Role nvarchar(50),
	
)
go 
select * from NHANVIEN
insert into NHANVIEN ()