--CREATE DATABASE QLKS;
--drop database QLKS
--USE QLKS;

CREATE TABLE LUONG (
    MACHUCVU INT IDENTITY(1,1) NOT NULL,
	TENCHUCVU NVARCHAR(50) NOT NULL,
    LUONGCOBAN DECIMAL(15,2) NOT NULL,	
    CONSTRAINT PK_LUONG PRIMARY KEY (MACHUCVU)   
);

CREATE TABLE NHANVIEN (
    MANV NVARCHAR(10) NOT NULL,
    HOTEN NVARCHAR(30) NOT NULL,
    MACHUCVU INT NOT NULL,
	GIOITINH NVARCHAR(10) NOT NULL,
    SDT NVARCHAR(10) NOT NULL,
	ANH NVARCHAR(100),
    CONSTRAINT PK_NHANVIEN PRIMARY KEY (MANV),
	CONSTRAINT FK_NHANVIEN_MACHUCVU FOREIGN KEY (MACHUCVU) REFERENCES LUONG(MACHUCVU)
);
CREATE TABLE BANGLAMVIEC(
    MANV NVARCHAR(10) NOT NULL,
	NGAYLAMVIEC DATE,
	CONSTRAINT PK_BANGLAMVIEC PRIMARY KEY (MANV),
	CONSTRAINT FK_BANGLAMVIEC_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);
CREATE TABLE USERS (
    UserName NVARCHAR(50) PRIMARY KEY,
    Password NVARCHAR(50) NOT NULL,
	MANV NVARCHAR(10) NOT NULL,
	CONSTRAINT FK_USERS_MANV FOREIGN KEY (MANV)  REFERENCES NHANVIEN(MANV)
);

CREATE TABLE PHONG (
    SOPHONG INT NOT NULL,
    LOAIPHONG NVARCHAR(10) NOT NULL,
    TINHTRANG BIT NOT NULL,
    GIAPHONG INT NOT NULL,
	TANG INT NOT NULL,
    CONSTRAINT PK_PHONG PRIMARY KEY (SOPHONG)
);
CREATE TABLE DICHVU (
    MADV NVARCHAR(10) NOT NULL,
    TENDV NVARCHAR(50) NOT NULL,
    GIA INT NOT NULL,
    CONSTRAINT PK_DICHVU PRIMARY KEY (MADV)
);

CREATE TABLE KHACHHANG (
    MAKH NVARCHAR(10) NOT NULL,
    DIACHI NVARCHAR(30) NOT NULL,
    TUOI INT NOT NULL,
    HOTEN NVARCHAR(30) NOT NULL,
    SDT NVARCHAR(10) NOT NULL,
	SOLANTHUE INT,
    CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH),
	CONSTRAINT Unique_PhoneNumber UNIQUE (SDT)
);

CREATE TABLE HOADON (
    MAHD NVARCHAR(10) NOT NULL,
    TONGHD INT ,
    NGAYDEN DATETIME NOT NULL,
    NGAYDI DATETIME,
	THOIGIANTHUE INT ,
    MANV NVARCHAR(10),
    MAKH NVARCHAR(10),
    CONSTRAINT PK_HOADON PRIMARY KEY (MAHD),
    CONSTRAINT FK_HOADON_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
    CONSTRAINT FK_HOADON_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV)
);
CREATE TABLE CHITIETHOADON (
    MACTHD NVARCHAR(10) NOT NULL,
    MAHD NVARCHAR(10) NOT NULL,
	MADV NVARCHAR(10),
    SOPHONG INT NOT NULL,
	GIAPHONG INT,
	GIADV INT,
    CONSTRAINT PK_CHITIETHOADON PRIMARY KEY (MACTHD),
	CONSTRAINT FK_CHITIETHOADON_MAHD FOREIGN KEY (MAHD) REFERENCES HOADON (MAHD),
    CONSTRAINT FK_CHITIETHOADON_SOPHONG FOREIGN KEY (SOPHONG) REFERENCES PHONG (SOPHONG),
    CONSTRAINT FK_CHITIETHOADON_MADV FOREIGN KEY (MADV) REFERENCES DICHVU (MADV),
);




INSERT INTO KHACHHANG (MAKH, DIACHI, TUOI, HOTEN, SDT,SOLANTHUE)
VALUES
    (N'KH001', N'123 Duong ABC', 25, N'Nguyen Van Khach', N'1111111111',1),
    (N'KH002', N'456 Duong XYZ', 30, N'Tran Thi Thao', N'2222222222',1),
    (N'KH003', N'789 Duong KLM', 35, N'Le Van Quy', N'3333333333',1),
    (N'KH004', N'101 Duong RST', 28, N'Pham Thi My', N'4444444444',1),
    (N'KH005', N'111 Duong UVW', 22, N'Tran Van Hau', N'5555555555',1),
    (N'KH006', N'222 Duong XYZ', 40, N'Le Thi Hanh', N'6666666666',1),
    (N'KH007', N'333 Duong DEF', 29, N'Hoang Van Tuan', N'7777777777',1),
    (N'KH008', N'444 Duong GHI', 33, N'Nguyen Thi Thuy', N'8888888888',1),
    (N'KH009', N'555 Duong JKL', 26, N'Vu Van Quan', N'9999999999',1),
    (N'KH010', N'666 Duong NOP', 31, N'Dang Van Hieu', N'1010101010',1),
    (N'KH011', N'777 Duong MNO', 37, N'Tran Thi Cam', N'1116111111',1),
    (N'KH012', N'888 Duong XYZ', 24, N'Pham Van Tien', N'1212121212',1),
    (N'KH013', N'999 Duong ABC', 32, N'Le Thi Hoai', N'1313131313',1),
    (N'KH014', N'1010 Duong XYZ', 38, N'Hoang Van Vinh', N'1414141414',1),
    (N'KH015', N'1111 Duong KLM', 27, N'Nguyen Van Han', N'1515151515',1);

INSERT INTO LUONG (TENCHUCVU, LUONGCOBAN)
VALUES
    (N'Quản lý tổng', 5000.00),
    (N'Quản lý phòng', 4000.00),
    (N'Nhân viên lễ tân', 3500.00),
    (N'Nhân viên phục vụ', 3200.00),
    (N'Quản lý nhà hàng', 4500.00),
    (N'Nhân viên kỹ thuật', 3800.00),
    (N'Nhân viên bảo vệ', 3000.00);



INSERT INTO NHANVIEN (MANV, HOTEN, MACHUCVU, GIOITINH, SDT,ANH)
VALUES
    (N'NV001', N'Lê Văn Tùng', 1, N'Nam', N'0123456789','1.jpg'),
    (N'NV002', N'Lê Quang Vũ', 2, N'Nữ', N'0123456780','2.jpg'),
    (N'NV003', N'Vũ Hữu Tuy', 3, N'Nam', N'0123456781','3.jpg'),
    (N'NV004', N'Nguyễn Thị Hoa', 3, N'Nữ', N'0123456782','4.jpg'),
    (N'NV005', N'Phạm Minh Đức', 4, N'Nam', N'0123456783','5.jpg'),
    (N'NV006', N'Trần Thị Mai', 4, N'Nữ', N'0123456784','6.jpg'),
    (N'NV007', N'Nguyễn Hồng Quân', 5, N'Nam', N'0123456785','7.jpg'),
    (N'NV008', N'Lê Thị Thanh', 6, N'Nữ', N'0123456786','8.jpg'),
    (N'NV009', N'Hoàng Văn Thắng', 6, N'Nam', N'0123456787','9.jpg'),
    (N'NV010', N'Vũ Văn An', 7, N'Nam', N'0123456788','10.jpg'),
    (N'NV011', N'Nguyễn Văn Tâm', 7, N'Nam', N'0123456789','11.jpg'),
    (N'NV012', N'Phạm Thu Hà', 3, N'Nữ', N'0123456790','12.jpg'),
    (N'NV013', N'Nguyễn Hải Yến', 3, N'Nữ', N'0123456791','13.jpg'),
    (N'NV014', N'Trần Tuấn Anh', 4, N'Nam', N'0123456792','14.jpg'),
    (N'NV015', N'Phạm Thu Hằng', 4, N'Nữ', N'0123456793','15.jpg'),
    (N'NV016', N'Lê Thị Linh', 5, N'Nữ', N'0123456794','16.jpg'),
    (N'NV017', N'Nguyễn Văn Dũng', 6, N'Nam', N'0123456795','17.jpg'),
    (N'NV018', N'Hoàng Minh Thị', 6, N'Nữ', N'0123456796','18.jpg'),
    (N'NV019', N'Vũ Quang Khải', 7, N'Nam', N'0123456797','19.jpg'),
    (N'NV020', N'Nguyễn Thị Bích', 7, N'Nữ', N'0123456798','20.jpg'),
    (N'NV021', N'Trần Quang Lâm', 3, N'Nam', N'0123456799','21.jpg'),
    (N'NV022', N'Phạm Văn Nam', 3, N'Nam', N'0123456700','22.jpg'),
    (N'NV023', N'Lê Văn Hùng', 4, N'Nam', N'0123456701','23.jpg'),
    (N'NV024', N'Nguyễn Thị Nga', 4, N'Nữ', N'0123456702','24.jpg'),
    (N'NV025', N'Vũ Thị Ngọc', 5, N'Nữ', N'0123456703','25.jpg');


INSERT INTO BANGLAMVIEC (MANV, NGAYLAMVIEC)
VALUES
    (N'NV001', '2023-11-01'),
    (N'NV002', '2023-11-01'),
    (N'NV003', '2023-11-01'),
    (N'NV004', '2023-11-01'),
    (N'NV005', '2023-11-01'),
    (N'NV006', '2023-11-01'),
    (N'NV007', '2023-11-01'),
    (N'NV008', '2023-11-01'),
    (N'NV009', '2023-11-01'),
    (N'NV010', '2023-11-01'),
    (N'NV011', '2023-11-01'),
    (N'NV012', '2023-11-01'),
    (N'NV013', '2023-11-01'),
    (N'NV014', '2023-11-01'),
    (N'NV015', '2023-11-01'),
    (N'NV016', '2023-11-01'),
    (N'NV017', '2023-11-01'),
    (N'NV018', '2023-11-01'),
    (N'NV019', '2023-11-01'),
    (N'NV020', '2023-11-01'),
    (N'NV021', '2023-11-01'),
    (N'NV022', '2023-11-01'),
    (N'NV023', '2023-11-01'),
    (N'NV024', '2023-11-01'),
    (N'NV025', '2023-11-01');


INSERT INTO PHONG (SOPHONG, LOAIPHONG, TINHTRANG, GIAPHONG, TANG)
VALUES
    (101, N'Single', 1, 1000000, 1),
    (102, N'Double', 1, 1000000, 1),
    (103, N'Triple', 1, 1000000, 1),
    (104, N'VIP', 1, 1500000, 1),
    (105, N'Single', 1, 1500000, 1),
    (106, N'Single', 1, 2000000, 1),
    (107, N'Triple', 1, 2000000, 1),
    (108, N'Triple', 1, 2000000, 1),
    (109, N'Triple', 0, 2500000, 1),
    (110, N'Vip', 0, 2500000, 1),
    (111, N'Double', 0, 2500000, 1),
    (112, N'Double', 0, 2500000, 1),
    (113, N'Single', 1, 3000000, 1),
    (114, N'Vip', 1, 3000000, 1),
    (115, N'Triple', 1, 3000000, 1),
    (201, N'Single', 1, 1500000, 2),
    (202, N'Single', 1, 2000000, 2),
    (203, N'Triple', 1, 2000000, 2),
    (204, N'Triple', 1, 2000000, 2),
    (205, N'Triple', 0, 2500000, 2),
    (206, N'Vip', 0, 2500000, 2),
    (207, N'Double', 0, 2500000, 2),
    (208, N'Double', 0, 2500000, 2),
    (209, N'Single', 1, 3000000, 2),
    (210, N'Vip', 1, 3000000, 2),
	(301, N'Triple', 0, 2500000, 3),
    (302, N'Vip', 0, 2500000, 3),
    (303, N'Double', 0, 2500000, 3),
    (304, N'Double', 0, 2500000, 3),
    (305, N'Single', 1, 3000000, 3),
    (306, N'Vip', 1, 3000000, 3),
    (307, N'Triple', 1, 3000000, 3),
    (308, N'Single', 1, 1000000, 3),
    (309, N'Double', 1, 1000000, 3),
    (310, N'Triple', 1, 1000000, 3),
	(401, N'Single', 1, 3000000, 4),
    (402, N'Vip', 1, 3000000, 4),
    (403, N'Triple', 1, 3000000, 4),
    (404, N'Single', 1, 1000000, 4),
    (405, N'Double', 1, 1000000, 4),
    (406, N'Triple', 1, 1000000, 4),
    (407, N'Single', 1, 1500000, 4),
    (408, N'Single', 1, 2000000, 4),
    (409, N'Triple', 1, 2000000, 4),
    (410, N'Triple', 1, 2000000, 4),
	(501, N'Single', 1, 1000000, 5),
    (502, N'Double', 1, 1000000, 5),
    (503, N'Triple', 1, 1000000, 5),
    (504, N'VIP', 1, 1500000, 5),
    (505, N'Single', 1, 1500000, 5),
    (506, N'Single', 1, 2000000, 5),
    (507, N'Triple', 1, 2000000, 5),
    (508, N'Triple', 1, 2000000, 5),
    (509, N'Triple', 0, 2500000, 5),
    (510, N'Vip', 0, 2500000, 5),
	(601, N'Single', 1, 1500000, 6),
    (602, N'Single', 1, 2000000, 6),
    (603, N'Triple', 1, 2000000, 6),
    (604, N'Triple', 1, 2000000, 6),
    (605, N'Triple', 0, 2500000, 6),
    (606, N'Vip', 0, 2500000, 6),
    (607, N'Double', 0, 2500000, 6),
    (608, N'Double', 0, 2500000, 6),
    (609, N'Single', 1, 3000000, 6),
    (610, N'Vip', 1, 3000000, 6),
	(701, N'Triple', 0, 2500000, 7),
    (702, N'Vip', 0, 2500000, 7),
    (703, N'Double', 0, 2500000, 7),
    (704, N'Double', 0, 2500000, 7),
    (705, N'Single', 1, 3000000, 7),
    (706, N'Vip', 1, 3000000, 7),
    (707, N'Triple', 1, 3000000, 7),
    (708, N'Single', 1, 1000000, 7),
    (709, N'Double', 1, 1000000, 7),
    (710, N'Triple', 1, 1000000, 7);

INSERT INTO DICHVU (MADV, TENDV, GIA)
VALUES
    ('DV001', N'Dịch vụ phòng ăn sáng', 200),
    ('DV002', N'Dịch vụ đỗ xe', 50),
    ('DV003', N'Dịch vụ giặt ủi', 30),
    ('DV004', N'Dịch vụ spa', 100),
	('DV005', N'Dịch vụ đưa đón sân bay', 400),
    ('DV006', N'Dịch vụ hướng dẫn du lịch', 100),
    ('DV007', N'Dịch vụ phòng họp', 80),
    ('DV008', N'Dịch vụ cho thuê xe', 150),
    ('DV009', N'Dịch vụ internet tốc độ cao', 50);


INSERT INTO HOADON (MAHD, TONGHD, NGAYDEN, NGAYDI, THOIGIANTHUE, MANV, MAKH)
VALUES
    (N'HD001', 2000000, '2023-01-20', '2023-01-29', 10, N'NV001', N'KH001'),
    (N'HD002', 1500000, '2023-02-15', '2023-02-18', 3, N'NV002', N'KH002'),
    (N'HD003', 2200000, '2023-03-10', '2023-03-17', 7, N'NV003', N'KH003'),
    (N'HD004', 1800000, '2023-04-17', NULL, NULL, N'NV004', N'KH004'),
    (N'HD005', 3000000, '2023-05-25', '2023-05-29', 4, N'NV005', N'KH005'),
    (N'HD006', 2500000, '2023-06-13', '2023-06-17', 4, N'NV006', N'KH006'),
    (N'HD007', 2700000, '2023-07-20', NULL, NULL, N'NV007', N'KH007'),
    (N'HD008', 1900000, '2023-08-27', '2023-09-27', 31, N'NV008', N'KH008'),
    (N'HD009', 2100000, '2023-09-15', '2023-09-23', 8, N'NV009', N'KH009'),
    (N'HD010', 2300000, '2023-10-23', '2023-10-28', 5, N'NV010', N'KH010'),
    (N'HD011', 2600000, '2023-11-30', NULL, NULL, N'NV011', N'KH011'),
    (N'HD012', 1700000, '2023-12-10', '2023-12-16', 6, N'NV012', N'KH012'),
    (N'HD013', 2900000, '2024-01-20', '2024-01-27', 7, N'NV013', N'KH013'),
    (N'HD014', 1800000, '2024-02-25', '2024-02-28', 3, N'NV014', N'KH014'),
    (N'HD015', 2500000, '2024-03-15', '2024-03-17', 2, N'NV015', N'KH015');



INSERT INTO CHITIETHOADON (MACTHD, MAHD, SOPHONG, GIAPHONG, MADV, GIADV)
VALUES
    (N'CTHD001', N'HD001', 101, 500, N'DV001', 50),
    (N'CTHD002', N'HD001', 101, 600, N'DV002', 60),
    (N'CTHD003', N'HD001', 101, 700, N'DV003', 70),
    (N'CTHD004', N'HD002', 104, 800, N'DV004', 80),
    (N'CTHD005', N'HD002', 104, 900, N'DV005', 90),
    (N'CTHD006', N'HD003', 106, 500, N'DV006', 40),
    (N'CTHD007', N'HD004', 107, 600, NULL, NULL),
    (N'CTHD008', N'HD005', 108, 400, N'DV008', 40),
    (N'CTHD009', N'HD005', 108, 700, N'DV009', 70),
    (N'CTHD010', N'HD006', 110, 500, NULL, NULL),
    (N'CTHD011', N'HD007', 201, 600, N'DV001', 50),
    (N'CTHD012', N'HD007', 201, 400, N'DV002', 60),
    (N'CTHD013', N'HD008', 203, 700, N'DV003', 70),
    (N'CTHD014', N'HD009', 204, 500, N'DV004', 80),
    (N'CTHD015', N'HD010', 305, 600, N'DV005', 90),
    (N'CTHD016', N'HD010', 305, 600, N'DV006', 90),
    (N'CTHD017', N'HD011', 309, 600, N'DV005', 90),
    (N'CTHD018', N'HD011', 309, 600, N'DV002', 90),
    (N'CTHD019', N'HD012', 403, 600, N'DV005', 90),
    (N'CTHD020', N'HD013', 407, 600, N'DV005', 90),
    (N'CTHD021', N'HD014', 502, 600, N'DV005', 90),
    (N'CTHD022', N'HD015', 607, 600, N'DV005', 90),
    (N'CTHD023', N'HD015', 607, 600, N'DV001', 90);


INSERT INTO Users (UserName, Password, MaNV) VALUES 
('lequangvu', '12345678',  'NV002'),
('vuhuutuy', '12345678',  'NV003'),
('leVantung', '12345678',  'NV001');

go
CREATE OR ALTER VIEW ReservationView AS
SELECT DISTINCT HOADON.MAHD AS BillID, HOADON.MAKH AS GuestID, TUOI AS Age, KHACHHANG.HOTEN AS Name, DIACHI AS Address,
       KHACHHANG.SDT AS PhoneNumber, CHITIETHOADON.SOPHONG AS RoomNumber, NGAYDEN AS ArriveTime, NGAYDI AS LeaveTime, HOADON.MANV AS EmployeeID,TONGHD AS TOTALMONEY
FROM HOADON
JOIN CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
go

create or alter view ServiceView as
select CHITIETHOADON.MAHD,CHITIETHOADON.MADV,TENDV,DICHVU.GIA
from CHITIETHOADON 
join DICHVU on CHITIETHOADON.MADV=DICHVU.MADV

go
--select * from ServiceView

CREATE OR ALTER FUNCTION CreateMaHD () RETURNS CHAR(8) AS
BEGIN
    DECLARE @max INT;
    SELECT @max = MAX(CAST(SUBSTRING(MAHD, 3, 4) AS INT)) + 1
    FROM HOADON
    
    DECLARE @s CHAR(8);
    DECLARE @formattedMax CHAR(3) = RIGHT('000' + RTRIM(CAST(@max AS CHAR(2))), 3);
    
    SET @s = 'HD' + @formattedMax;
    RETURN @s;
END;

--select dbo.CreateMaHD()
go


CREATE OR ALTER FUNCTION CreateMaNV () RETURNS CHAR(8) AS
BEGIN
    DECLARE @max INT;
    SELECT @max = MAX(CAST(SUBSTRING(NHANVIEN.MANV, 3, 4) AS INT)) + 1
    FROM NHANVIEN;
    
    DECLARE @s CHAR(8);
    DECLARE @formattedMax CHAR(3) = RIGHT('000' + RTRIM(CAST(@max AS CHAR(2))), 3);
    
    SET @s = 'NV' + @formattedMax;
    RETURN @s;
END;

go
--select dbo.CreateMaNV()

CREATE OR ALTER FUNCTION CreateMaKH () RETURNS CHAR(8) AS
BEGIN
    DECLARE @max INT;
    SELECT @max = MAX(CAST(SUBSTRING(MAKH, 3, 4) AS INT)) + 1
    FROM KHACHHANG
    
    DECLARE @s CHAR(8);
    DECLARE @formattedMax CHAR(3) = RIGHT('000' + RTRIM(CAST(@max AS CHAR(2))), 3);
    
    SET @s = 'KH' + @formattedMax;
    RETURN @s;
END;

go
--select dbo.CreateMaKH()

CREATE OR ALTER FUNCTION CreateMaCTHD () RETURNS CHAR(8) AS
BEGIN
    DECLARE @max INT;
    SELECT @max = MAX(CAST(SUBSTRING(MACTHD, 5, 4) AS INT)) + 1
    FROM CHITIETHOADON
    
    DECLARE @s CHAR(8);
    DECLARE @formattedMax CHAR(3) = RIGHT('000' + RTRIM(CAST(@max AS CHAR(2))), 3);
    
    SET @s = 'CTHD' + @formattedMax;
    RETURN @s;
END;

--select dbo.CreateMaCTHD()
go

CREATE OR ALTER FUNCTION price (@sophong INT) RETURNS FLOAT AS
BEGIN
    DECLARE @GIA FLOAT
    SELECT @GIA=GIAPHONG FROM PHONG WHERE SOPHONG=@sophong
    RETURN @GIA;
END;
go
CREATE OR ALTER FUNCTION priceService (@Tendv nvarchar(50)) RETURNS FLOAT AS
BEGIN
    DECLARE @GIA FLOAT
    SELECT @GIA=GIA FROM DICHVU WHERE TENDV=@Tendv
    RETURN @GIA;
END;

go
CREATE OR ALTER FUNCTION RenderMaDV (@Tendv nvarchar(50)) RETURNS nvarchar(10) AS
BEGIN
    DECLARE @MA NVARCHAR(10)
    SELECT @MA=MADV FROM DICHVU WHERE TENDV=@Tendv
    RETURN @MA;
END;
go
CREATE OR ALTER FUNCTION RenderMaChucVu (@Tenchucvu nvarchar(50)) RETURNS nvarchar(10) AS
BEGIN
    DECLARE @MA NVARCHAR(10)
    SELECT @MA=MACHUCVU FROM LUONG WHERE TENCHUCVU=@Tenchucvu
    RETURN @MA;
END;

go
 --khi  nhập ngày đi thì cập nhập thời gian thuê
CREATE OR ALTER TRIGGER UpdateThoiGianThue
ON HOADON
FOR UPDATE
AS
BEGIN
-- update thoi gian thue
    IF UPDATE(NGAYDI)
	BEGIN 
	UPDATE HOADON
    SET THOIGIANTHUE = 
    CASE 
        WHEN inserted.NGAYDI IS NOT NULL AND HOADON.NGAYDEN = inserted.NGAYDI THEN 1
        ELSE DATEDIFF(DAY, HOADON.NGAYDEN, inserted.NGAYDI)
    END
    FROM HOADON
    JOIN inserted ON HOADON.MAHD = inserted.MAHD
    WHERE inserted.NGAYDI IS NOT NULL;

-- update tinh trang phong
	DECLARE @SOPHONG INT;
    UPDATE PHONG
    SET TINHTRANG = CASE
        WHEN inserted.NGAYDI IS NOT NULL THEN 0
        ELSE 1
        END
    FROM inserted
    JOIN CHITIETHOADON ON CHITIETHOADON.MAHD = inserted.MAHD
    JOIN PHONG ON CHITIETHOADON.SOPHONG = PHONG.SOPHONG
    WHERE PHONG.SOPHONG = @SOPHONG;


	-- update tong tien hoa don
	 UPDATE HOADON
    SET TONGHD = 
	(SELECT distinct CHITIETHOADON.GIAPHONG * THOIGIANTHUE
	from inserted join CHITIETHOADON on inserted.MAHD=CHITIETHOADON.MAHD
	where HOADON.MAHD=inserted.MAHD
    )          

	END


END;

go
CREATE OR ALTER TRIGGER UpdateTongHoaDon
ON CHITIETHOADON
FOR INSERT,UPDATE,DELETE
AS
BEGIN
DECLARE @GIADV FLOAT,@MAHD NVARCHAR(10),@GIADVCU FLOAT
SELECT @MAHD=MAHD,@GIADV=GIADV
FROM inserted
SELECT @GIADVCU=GIADV
FROM deleted
UPDATE HOADON SET TONGHD=ISNULL(TONGHD,0)+@GIADV-@GIADVCU
WHERE MAHD=@MAHD
END


CREATE FUNCTION LUONGF(@NAM INT,@THANG INT)
RETURNS DECIMAL(15,2) 
AS
BEGIN
   DECLARE @SONGAY INT
   SELECT @SONGAY=COUNT(*) 
FROM NHANVIEN NV
JOIN BANGLAMVIEC BLV ON NV.MANV = BLV.MANV
WHERE
    DATEPART(YEAR, BLV.NGAYLAMVIEC) = @NAM 
    AND DATEPART(MONTH, BLV.NGAYLAMVIEC) = @THANG 

DECLARE @LUONG DECIMAL(15,2)
  SELECT @LUONG=@SONGAY*LUONGCOBAN/26
  FROM NHANVIEN
  JOIN LUONG ON NHANVIEN.MACHUCVU=LUONG.MACHUCVU
  RETURN @LUONG
END

select dbo.LUONGF(2023,11)

CREATE VIEW TinhLuongTheoThang AS
SELECT
    NV.MANV AS 'Mã Nhân Viên',
    NV.HOTEN AS 'Tên Nhân Viên',
    DATEPART(YEAR, BLV.NGAYLAMVIEC) AS 'Năm',
    DATEPART(MONTH, BLV.NGAYLAMVIEC) AS 'Tháng',
    dbo.LUONGF(DATEPART(YEAR, BLV.NGAYLAMVIEC), DATEPART(MONTH, BLV.NGAYLAMVIEC)) AS 'Tiền Lương Tháng'
FROM NHANVIEN NV
JOIN BANGLAMVIEC BLV ON NV.MANV = BLV.MANV
GROUP BY NV.MANV, NV.HOTEN, DATEPART(YEAR, BLV.NGAYLAMVIEC), DATEPART(MONTH, BLV.NGAYLAMVIEC);

go

SELECT top 5  KHACHHANG.HOTEN, COUNT(HOADON.MAKH) AS SoLanDen
FROM KHACHHANG
LEFT JOIN HOADON ON KHACHHANG.MAKH = HOADON.MAKH
GROUP BY KHACHHANG.MAKH, KHACHHANG.HOTEN
ORDER BY SoLanDen DESC
SELECT
    MONTH(NGAYDEN) AS THANG,
    SUM((GIAPHONG + COALESCE(GIADV, 0))) AS DOANHTHU
FROM HOADON H
LEFT JOIN CHITIETHOADON C ON H.MAHD = C.MAHD
WHERE YEAR(NGAYDEN) = 2023
GROUP BY MONTH(NGAYDEN)
ORDER BY MONTH(NGAYDEN);
go
SELECT
    DAY(hd.NGAYDI) AS Ngay,
    SUM(cthd.GIAPHONG + cthd.GIADV) AS DoanhThuNgay
FROM HOADON AS hd
INNER JOIN CHITIETHOADON AS cthd ON hd.MAHD = cthd.MAHD
WHERE MONTH(hd.NGAYDI) = '5' AND YEAR(hd.NGAYDI) = '2023'
GROUP BY DAY(hd.NGAYDI)
ORDER BY Ngay;
CREATE TABLE Numbers (Num INT);
INSERT INTO Numbers VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10),
    (11), (12), (13), (14), (15), (16), (17), (18), (19), (20),
    (21), (22), (23), (24), (25), (26), (27), (28), (29), (30), (31);
SELECT
    n.Num AS Ngay,
    COALESCE(SUM(CASE WHEN MONTH(hd.NGAYDI) = 12 AND YEAR(hd.NGAYDI) = 2023 THEN cthd.GIAPHONG + cthd.GIADV ELSE 0 END), 0) AS DoanhThuNgay
FROM Numbers AS n
LEFT JOIN HOADON AS hd ON n.Num = DAY(hd.NGAYDI)
LEFT JOIN CHITIETHOADON AS cthd ON hd.MAHD = cthd.MAHD
GROUP BY n.Num
ORDER BY Ngay;