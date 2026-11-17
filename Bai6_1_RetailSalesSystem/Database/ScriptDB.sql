-- =============================================
-- Script khởi tạo CSDL: SalesDB
-- Bài 6.1: Hệ thống Quản lý Bán hàng & Siêu thị Mini
-- =============================================

IF DB_ID('SalesDB') IS NULL
BEGIN
    CREATE DATABASE SalesDB;
END
GO

USE SalesDB;
GO

-- Xóa bảng theo thứ tự khóa ngoại nếu tạo lại
IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('SanPham', 'U') IS NOT NULL DROP TABLE SanPham;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
GO

-- 1. Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    ChucVu NVARCHAR(50)
);
GO

-- 2. Bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiemTichLuy INT DEFAULT 0
);
GO

-- 3. Bảng SanPham
CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(150) NOT NULL,
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan > 0),
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);
GO

-- 4. Bảng HoaDon
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    TongTien DECIMAL(18,2) NOT NULL
);
GO

-- 5. Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL,
    PRIMARY KEY (MaHD, MaSP)
);
GO

-- =============================================
-- DỮ LIỆU MẪU (SAMPLE DATA)
-- =============================================

INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES
(N'Lê Ngọc Quyền', '0901234501', N'Quản lý'),
(N'Nguyễn Thị Lan', '0901234502', N'Thu ngân'),
(N'Trần Văn Hùng', '0901234503', N'Thu ngân'),
(N'Phạm Minh Anh', '0901234504', N'Nhân viên kho');
GO

INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES
(N'Hoàng Văn Nam', '0912345601', 12),
(N'Vũ Thị Hương', '0912345602', 25),
(N'Đặng Quốc Bảo', '0912345603', 8),
(N'Bùi Ngọc Diệp', '0912345604', 40);
GO

INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES
('SP001', N'Sữa tươi Vinamilk 1L', 35000, 120),
('SP002', N'Mì gói Hảo Hảo Tôm Chua Cay (Thùng 30 gói)', 115000, 45),
('SP003', N'Nước suối Lavie 500ml (Lốc 6 chai)', 28000, 80),
('SP004', N'Dầu ăn Simply 1L', 62000, 60),
('SP005', N'Gạo ST25 Túi 5kg', 185000, 35),
('SP006', N'Nước ngọt Coca-Cola 1.5L', 22000, 90),
('SP007', N'Bánh quy bơ Danisa 454g', 145000, 20),
('SP008', N'Cà phê hòa tan G7 3in1 (Hộp 18 gói)', 58000, 50);
GO

INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) VALUES
(GETDATE(), 2, 1, 295000),
(GETDATE(), 3, 2, 412000),
(DATEADD(DAY, -2, GETDATE()), 2, 3, 555000),
(DATEADD(DAY, -5, GETDATE()), 1, 4, 340000);
GO

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
(1, 'SP001', 3, 35000),
(1, 'SP002', 1, 115000),
(1, 'SP003', 2, 28000),
(1, 'SP006', 1, 19000),

(2, 'SP005', 2, 185000),
(2, 'SP006', 2, 21000),

(3, 'SP005', 3, 185000),

(4, 'SP007', 2, 145000),
(4, 'SP001', 1, 50000);
GO
