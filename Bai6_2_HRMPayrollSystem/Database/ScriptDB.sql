-- =============================================
-- Script khởi tạo CSDL: HRMDB
-- Bài 6.2: Hệ thống Quản lý Nhân sự & Tính lương (HRM & Payroll System)
-- =============================================

IF DB_ID('HRMDB') IS NULL
BEGIN
    CREATE DATABASE HRMDB;
END
GO

USE HRMDB;
GO

IF OBJECT_ID('BangLuong', 'U') IS NOT NULL DROP TABLE BangLuong;
IF OBJECT_ID('BangChamCong', 'U') IS NOT NULL DROP TABLE BangChamCong;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('PhongBan', 'U') IS NOT NULL DROP TABLE PhongBan;
GO

-- 1. Bảng PhongBan
CREATE TABLE PhongBan (
    MaPB INT IDENTITY(1,1) PRIMARY KEY,
    TenPB NVARCHAR(100) NOT NULL,
    Mota NVARCHAR(255)
);
GO

-- 2. Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME,
    CCCD VARCHAR(20) UNIQUE,
    MaPB INT NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPB),
    LuongCoBan DECIMAL(18,2) NOT NULL CHECK (LuongCoBan > 0),
    HeSoLuong FLOAT DEFAULT 1.0
);
GO

-- 3. Bảng BangChamCong
CREATE TABLE BangChamCong (
    MaCong INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL,
    SoNgayCong FLOAT NOT NULL CHECK (SoNgayCong >= 0 AND SoNgayCong <= 31),
    SoGioOT FLOAT DEFAULT 0 CHECK (SoGioOT >= 0),
    DaKhoa BIT DEFAULT 0,
    CONSTRAINT UQ_ChamCong_NV_Thang UNIQUE (MaNV, ThangNam)
);
GO

-- 4. Bảng BangLuong
CREATE TABLE BangLuong (
    MaLuong INT IDENTITY(1,1),
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL,
    ThucLinh DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaNV, ThangNam)
);
GO

-- =============================================
-- DỮ LIỆU MẪU (SAMPLE DATA)
-- =============================================

INSERT INTO PhongBan (TenPB, Mota) VALUES
(N'Phòng Kỹ thuật & Phần mềm', N'Phát triển và bảo trì hệ thống CNTT'),
(N'Phòng Kinh doanh', N'Tìm kiếm khách hàng và phát triển thị trường'),
(N'Phòng Nhân sự & Hành chính', N'Quản lý nhân sự, tuyển dụng và hành chính'),
(N'Phòng Kế toán & Tài chính', N'Quản lý thu chi, ngân sách và tính lương');
GO

INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) VALUES
(N'Lê Ngọc Quyền', '2004-10-25', '038204001234', 1, 12000000, 1.5),
(N'Nguyễn Minh Tuấn', '1998-05-12', '001098005678', 1, 10000000, 1.3),
(N'Trần Thị Thu Hà', '1999-08-20', '034199002345', 2, 9500000, 1.2),
(N'Phạm Văn Long', '1995-02-14', '036095008765', 2, 11000000, 1.4),
(N'Hoàng Ngọc Mai', '2000-11-30', '001300004321', 3, 8500000, 1.1),
(N'Vũ Đức Anh', '1996-07-09', '030096009876', 4, 10500000, 1.35);
GO

INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, DaKhoa) VALUES
(1, '11/2026', 22, 10, 0),
(2, '11/2026', 21, 5, 0),
(3, '11/2026', 22, 8, 0),
(4, '11/2026', 20, 4, 0),
(5, '11/2026', 22, 0, 0),
(6, '11/2026', 22, 6, 0);
GO
