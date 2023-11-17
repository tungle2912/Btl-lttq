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
	CONSTRAINT PK_BANGLAMVIEC PRIMARY KEY (MANV,NGAYLAMVIEC),
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
    (N'KH002', N'456 Duong XYZ', 30, N'Tran Thi Thao', N'2222222222',3),
    (N'KH003', N'789 Duong KLM', 35, N'Le Van Quy', N'3333333333',5),
    (N'KH004', N'101 Duong RST', 28, N'Pham Thi My', N'4444444444',2),
    (N'KH005', N'111 Duong UVW', 22, N'Tran Van Hau', N'5555555555',2),
    (N'KH006', N'222 Duong XYZ', 40, N'Le Thi Hanh', N'6666666666',7),
    (N'KH007', N'333 Duong DEF', 29, N'Hoang Van Tuan', N'7777777777',1),
    (N'KH008', N'444 Duong GHI', 33, N'Nguyen Thi Thuy', N'8888888888',1),
    (N'KH009', N'555 Duong JKL', 26, N'Vu Van Quan', N'9999999999',1),
    (N'KH010', N'666 Duong NOP', 31, N'Dang Van Hieu', N'1010101010',1),
    (N'KH011', N'777 Duong MNO', 37, N'Tran Thi Cam', N'1116111111',1),
    (N'KH012', N'888 Duong XYZ', 24, N'Pham Van Tien', N'1212121212',1),
    (N'KH013', N'999 Duong ABC', 32, N'Le Thi Hoai', N'1313131313',3),
    (N'KH014', N'1010 Duong XYZ', 38, N'Hoang Van Vinh', N'1414141414',1),
    (N'KH015', N'1111 Duong KLM', 27, N'Nguyen Van Han', N'1515151515',1),
    (N'KH016', N'1212 Duong ABC', 23, N'Nguyen Van A', N'1616161616', 2),
    (N'KH017', N'1313 Duong XYZ', 36, N'Tran Thi B', N'1717171717', 4),
    (N'KH018', N'1414 Duong KLM', 29, N'Le Van C', N'1818181818', 3),
    (N'KH019', N'1515 Duong RST', 33, N'Pham Thi D', N'1919191919', 1),
    (N'KH020', N'1616 Duong UVW', 27, N'Tran Van E', N'2020202020', 2),
    (N'KH021', N'1717 Duong XYZ', 42, N'Le Thi F', N'2121212121', 6),
    (N'KH022', N'1818 Duong DEF', 35, N'Hoang Van G', N'2222222232', 4),
    (N'KH023', N'1919 Duong GHI', 28, N'Nguyen Thi H', N'2333333333', 2),
    (N'KH024', N'2020 Duong JKL', 31, N'Vu Van I', N'2444444444', 1),
    (N'KH025', N'2121 Duong NOP', 26, N'Dang Van J', N'2555555555', 1),
    (N'KH026', N'2222 Duong MNO', 38, N'Tran Thi K', N'2666666666', 3),
    (N'KH027', N'2323 Duong XYZ', 25, N'Pham Van L', N'2777777777', 1),
    (N'KH028', N'2424 Duong ABC', 34, N'Le Thi M', N'2888888888', 5),
    (N'KH029', N'2525 Duong XYZ', 30, N'Hoang Van N', N'2999999999', 2),
    (N'KH030', N'2626 Duong KLM', 37, N'Nguyen Van O', N'3030303030', 1);


INSERT INTO LUONG (TENCHUCVU, LUONGCOBAN)
VALUES
    (N'Quản lý tổng', 50000000.00),
    (N'Quản lý phòng', 4000000.00),
    (N'Nhân viên lễ tân', 1500000.00),
    (N'Nhân viên phục vụ', 12000000.00),
    (N'Quản lý nhà hàng', 30000000.00),
    (N'Nhân viên kỹ thuật', 15000000.00),
    (N'Nhân viên bảo vệ', 8000000.00);



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

go

CREATE PROCEDURE InsertEmployeeData
AS
BEGIN
    DECLARE @StartMonth INT = 1;
    DECLARE @EndMonth INT = 12;
    DECLARE @CurrentMonth INT = @StartMonth;

    WHILE @CurrentMonth <= @EndMonth
    BEGIN
        DECLARE @CurrentDate DATE = '2023-' + CAST(@CurrentMonth AS NVARCHAR(2)) + '-01';
        INSERT INTO BANGLAMVIEC (MANV, NGAYLAMVIEC)
        VALUES
            (N'NV001', @CurrentDate),
            (N'NV002', @CurrentDate),
            (N'NV003', @CurrentDate),
            (N'NV004', @CurrentDate),
            (N'NV005', @CurrentDate),
            (N'NV006', @CurrentDate),
            (N'NV007', @CurrentDate),
            (N'NV008', @CurrentDate),
            (N'NV009', @CurrentDate),
            (N'NV010', @CurrentDate),
            (N'NV011', @CurrentDate),
            (N'NV012', @CurrentDate),
            (N'NV013', @CurrentDate),
            (N'NV014', @CurrentDate),
            (N'NV015', @CurrentDate),
            (N'NV016', @CurrentDate),
            (N'NV017', @CurrentDate),
            (N'NV018', @CurrentDate),
            (N'NV019', @CurrentDate),
            (N'NV020', @CurrentDate),
            (N'NV021', @CurrentDate),
            (N'NV022', @CurrentDate),
            (N'NV023', @CurrentDate),
            (N'NV024', @CurrentDate),
            (N'NV025', @CurrentDate);

        SET @CurrentMonth = @CurrentMonth + 1;
    END
END;

go
exec InsertEmployeeData


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


/*INSERT INTO HOADON (MAHD, TONGHD, NGAYDEN, NGAYDI, THOIGIANTHUE, MANV, MAKH)
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
	*/

go
CREATE or alter PROCEDURE InsertHoaDonData
AS
BEGIN
DECLARE @InvoiceCounter INT = 1; -- Biến tạm để lưu trữ giá trị mã đơn hiện tại
-- Thêm dữ liệu cho hóa đơn và chi tiết hóa đơn
DECLARE @StartDate DATE = '2022-01-01';
DECLARE @EndDate DATE = '2023-12-30';
DECLARE @CurrentDate DATE = @StartDate;
DECLARE @EmployeeCounter INT = 1;
DECLARE @Detail INT = 1;

WHILE @CurrentDate <= @EndDate
BEGIN
  
        DECLARE @EmployeeCode NVARCHAR(5) = 'NV' + RIGHT('000' + CAST(@EmployeeCounter AS NVARCHAR(3)), 3);
		SELECT TOP 1 @EmployeeCode = MANV FROM NHANVIEN ORDER BY NEWID();
		DECLARE @GuestCode NVARCHAR(5) ;
		SELECT TOP 1 @GuestCode = MAKH FROM KHACHHANG ORDER BY NEWID();
        DECLARE @InvoiceCode NVARCHAR(5) = 'HD' + RIGHT('000' + CAST(@InvoiceCounter AS NVARCHAR(3)), 3); -- Sử dụng biến tạm này
		DECLARE @LeaveDate date = DATEADD(DAY, ROUND(RAND() * 20, 0), @CurrentDate);
		DECLARE @RentalPeriod int =DATEDIFF(DAY,@CurrentDate, @LeaveDate) +1;
		DECLARE @RoomNumber INT;
        SELECT TOP 1 @RoomNumber = SOPHONG FROM PHONG ORDER BY NEWID();
		DECLARE @RoomPrice INT;
		SELECT @RoomPrice= GIAPHONG FROM PHONG WHERE SOPHONG=@RoomNumber

        INSERT INTO HOADON (MAHD, TONGHD, NGAYDEN, NGAYDI, THOIGIANTHUE, MANV, MAKH)
        VALUES
            (@InvoiceCode,@RoomPrice*@RentalPeriod, @CurrentDate,@LeaveDate,@RentalPeriod, @EmployeeCode, @GuestCode);

        DECLARE @DetailCounter INT = 1;

        WHILE @DetailCounter <= ROUND(RAND() * 3, 0) + 1 -- Tạo từ 1 đến 6 chi tiết hóa đơn
        BEGIN
            DECLARE @DetailCode NVARCHAR(7) = 'CTHD' + RIGHT('000' + CAST(@Detail AS NVARCHAR(3)), 3);

            -- Lựa chọn ngẫu nhiên từ bảng DICHVU
            DECLARE @ServiceCode NVARCHAR(5);
            SELECT TOP 1 @ServiceCode = MADV FROM DICHVU ORDER BY NEWID();
			DECLARE @ServicePrice FLOAT;
		    SELECT @ServicePrice= GIA FROM DICHVU WHERE MADV=@ServiceCode

            INSERT INTO CHITIETHOADON (MACTHD, MAHD, SOPHONG, GIAPHONG, MADV, GIADV)
            VALUES
                (@DetailCode, @InvoiceCode, @RoomNumber,@RoomPrice, @ServiceCode, @ServicePrice); 
            update hoadon set tonghd +=@ServicePrice where mahd=@InvoiceCode

            SET @DetailCounter = @DetailCounter + 1;
			SET @Detail = @Detail + 1;
        END
        SET @EmployeeCounter = @EmployeeCounter + 1;
        SET @InvoiceCounter = @InvoiceCounter + 1; -- Tăng giá trị mã đơn
        SET @CurrentDate = DATEADD(DAY, 10, @CurrentDate);
END
end;

go
exec InsertHoaDonData

/*INSERT INTO CHITIETHOADON (MACTHD, MAHD, SOPHONG, GIAPHONG, MADV, GIADV)
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
    (N'CTHD023', N'HD015', 607, 600, N'DV001', 90);*/


INSERT INTO Users (UserName, Password, MaNV) VALUES 
('LeQuangVu', '12345678',  'NV002'),
('VuHuuTuy', '12345678',  'NV003'),
('leVanTung', '12345678',  'NV001');
go
CREATE FUNCTION billview
(
    @hoten nvarchar(50) = NULL,
    @ngay datetime = NULL
)
RETURNS TABLE
AS
RETURN
(
    SELECT MAHD AS N'Bill ID', 
     MAKH AS N'Guest ID',                      
     NGAYDEN AS 'Arrive Time', 
     NGAYDI AS 'Leave Time', 
     THOIGIANTHUE AS N'Rental period',
     TONGHD AS N'Total '
     FROM HOADON   
     WHERE 
        (@hoten IS NULL OR MAKH in (SELECT MAKH FROM KHACHHANG WHERE HOTEN LIKE N'%'+@hoten+'%'))
        AND (@ngay IS NULL OR (NGAYDEN = @ngay OR NGAYDI=@ngay))
);

go
CREATE OR ALTER VIEW ReservationView AS
SELECT DISTINCT HOADON.MAHD AS BillID, HOADON.MAKH AS GuestID, TUOI AS Age, KHACHHANG.HOTEN AS Name, DIACHI AS Address,
       KHACHHANG.SDT AS PhoneNumber, CHITIETHOADON.SOPHONG AS RoomNumber, NGAYDEN AS ArriveTime, NGAYDI AS LeaveTime, HOADON.MANV AS EmployeeID,TONGHD AS TOTALMONEY
FROM HOADON
left JOIN CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
JOIN KHACHHANG ON HOADON.MAKH = KHACHHANG.MAKH
go

create or alter view ServiceView as
select CHITIETHOADON.MAHD,CHITIETHOADON.MADV,TENDV,DICHVU.GIA
from CHITIETHOADON 
join DICHVU on CHITIETHOADON.MADV=DICHVU.MADV

go

CREATE OR ALTER VIEW totalcounter AS
SELECT
    (SELECT COUNT(*) FROM PHONG) AS sophong,
    (SELECT COUNT(*) FROM PHONG WHERE TINHTRANG = 1) AS sophong_available,
    (SELECT COUNT(*) FROM PHONG WHERE TINHTRANG = 0) AS sophong_booked,
    (SELECT COUNT(*) FROM NHANVIEN) AS NhanVien;

go
create or alter view top5khachhang as
SELECT top 5  KHACHHANG.HOTEN,KHACHHANG.SOLANTHUE as SoLanDen
FROM KHACHHANG
ORDER BY KHACHHANG.SOLANTHUE DESC
--select * from ServiceView
go
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
    DECLARE @formattedMax CHAR(3) = RIGHT('000' + RTRIM(CAST(@max AS CHAR(3))), 3);
    
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

go

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

GO
CREATE or alter FUNCTION DOANHTHUF(@NAM INT,@THANG INT)
RETURNS DECIMAL(15,2) 
AS
BEGIN
   DECLARE @tongtien DECIMAL(15,2) 
   SELECT @tongtien = ISNULL(SUM(ISNULL(TONGHD, 0)), 0)
FROM HOADON
WHERE
    DATEPART(YEAR,NGAYDI) = @NAM 
    AND DATEPART(MONTH, NGAYDI) = @THANG 
  RETURN @tongtien	
END

go
CREATE OR ALTER FUNCTION NUMBERORDER(@NAM INT,@THANG INT)
RETURNS INT
AS
BEGIN
   DECLARE @SOHOADON INT
   SELECT @SOHOADON=COUNT(*)
FROM HOADON
WHERE
    DATEPART(YEAR,NGAYDI) = @NAM 
    AND DATEPART(MONTH, NGAYDI) = @THANG 
  RETURN @SOHOADON	
END

go
CREATE TABLE Numbers (Num INT);
go
INSERT INTO Numbers VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10),
    (11), (12);
go

CREATE OR ALTER FUNCTION LOINHUANNAM(@NAM INT)
RETURNS TABLE
RETURN (
    SELECT DISTINCT
        YEAR(CalendarDate) AS NAM,
        MONTH(CalendarDate) AS THANG,
        ISNULL(dbo.DOANHTHUF(YEAR(CalendarDate), MONTH(CalendarDate)), 0) AS DOANHTHU,
        ISNULL(dbo.LUONGF(YEAR(CalendarDate), MONTH(CalendarDate)), 0) AS LUONG,
        CAST((ISNULL(dbo.DOANHTHUF(YEAR(CalendarDate), MONTH(CalendarDate)), 0) - ISNULL(dbo.LUONGF(YEAR(CalendarDate), MONTH(CalendarDate)), 0)) / 23000.0 AS DECIMAL(15,2)) AS LOINHUAN_USD
    FROM (
        SELECT DATEADD(MONTH, Num - 1, CONVERT(VARCHAR, @NAM) + '-01-01') AS CalendarDate
        FROM Numbers
    ) Calendar
    LEFT JOIN HOADON HD ON YEAR(Calendar.CalendarDate) = YEAR(HD.NGAYDI) AND MONTH(Calendar.CalendarDate) = MONTH(HD.NGAYDI)
    LEFT JOIN NHANVIEN NV ON HD.MANV = NV.MANV
    LEFT JOIN BANGLAMVIEC BLV ON NV.MANV = BLV.MANV
);

go
 --khi  nhập ngày đi thì cập nhập thời gian thuê
CREATE OR ALTER TRIGGER UpdateThoiGianThue
ON HOADON
FOR INSERT,UPDATE,DELETE
AS
BEGIN

    DECLARE @NGAYDI DATETIME,@MAHD NVARCHAR(10)
	SELECT @MAHD=MAHD,@NGAYDI=NGAYDI
	FROM inserted
-- update thoi gian thue
    IF @NGAYDI IS NOT NULL
	BEGIN 
	/*UPDATE HOADON
    SET THOIGIANTHUE = 
    CASE 
        WHEN @NGAYDI IS NOT NULL AND HOADON.NGAYDEN = @NGAYDI THEN 1
        ELSE DATEDIFF(DAY, HOADON.NGAYDEN, @NGAYDI) +1
    END
    FROM HOADON
    WHERE MAHD=@MAHD;*/

-- update tinh trang phong
	DECLARE @SOPHONG INT;
    UPDATE PHONG
    SET TINHTRANG = 0 WHERE SOPHONG IN (SELECT SOPHONG FROM CHITIETHOADON WHERE MAHD=@MAHD)   
	-- update tong tien hoa don
	DECLARE @TONGTIEN FLOAT,@GIAPHONG FLOAT,@TONGTIENCU FLOAT

	SELECT @GIAPHONG= SUM(GIAPHONG) FROM CHITIETHOADON WHERE MAHD=@MAHD
	SELECT @TONGTIEN=@GIAPHONG* THOIGIANTHUE FROM inserted
	SELECT @TONGTIENCU=@GIAPHONG* THOIGIANTHUE FROM deleted

 /*   UPDATE HOADON
    SET TONGHD =ISNULL(TONGHD,0)+ @TONGTIEN-@TONGTIENCU
    WHERE MAHD = @MAHD;    */ 
	END
	ELSE  -- SET TINH TRANG PHONG KHI THEM HOA DON
	BEGIN
    UPDATE PHONG
    SET TINHTRANG = 1 WHERE SOPHONG IN (SELECT SOPHONG FROM CHITIETHOADON WHERE MAHD=@MAHD)   
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
