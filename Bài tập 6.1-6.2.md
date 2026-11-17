Bài 6.1: HỆ THỐNG QUẢN LÝ BÁN HÀNG & SIÊU THỊ MINI (RETAIL  SALES SYSTEM)  

Mục tiêu  

 Thực thi giao dịch SqlTransaction để xử lý tạo hóa đơn và trừ tồn kho tự  động (đảm bảo tính toàn vẹn dữ liệu ACID).  

 Áp dụng kiến trúc 3-Tier (DTO \- DAL \- BUS \- GUI) và phòng chống  100% lỗ hổng SQL Injection bằng SqlParameter.  

1\. Hướng dẫn chi tiết xây dựng CSDL (SalesDB)  

Tạo CSDL SQL Server bao gồm 5 bảng có quan hệ khóa ngoại:  1\. NhanVien (Nhân viên bán hàng) 

o MaNV (int, Primary Key, Identity)  

o TenNV (nvarchar(100), NOT NULL)  

o SoDienThoai (varchar(15), Unique)  

o ChucVu (nvarchar(50)) — Ví dụ: "Thu ngân", "Quản lý" 

2\. KhachHang (Khách hàng) 

o MaKH (int, Primary Key, Identity)  

o TenKH (nvarchar(100), NOT NULL)  

o DienThoai (varchar(15), Unique)  

o DiemTichLuy (int, Default 0\)  

3\. SanPham (Sản phẩm / Hàng hóa) 

o MaSP (varchar(20), Primary Key)  

o TenSP (nvarchar(150), NOT NULL)  

o GiaBan (decimal(18,2), Check \> 0\)  

o SoLuongTon (int, Check \>= 0\)  

4\. HoaDon (Hóa đơn bán hàng) 

o MaHD (int, Primary Key, Identity)  

o NgayLap (datetime, Default GetDate())   
o MaNV (int, Foreign Key NhanVien)  

o MaKH (int, Foreign Key KhachHang, Nullable)  

o TongTien (decimal(18,2))  

5\. ChiTietHoaDon (Chi tiết hóa đơn) 

o MaHD (int, Foreign Key HoaDon)  

o MaSP (varchar(20), Foreign Key SanPham)  

o SoLuong (int, Check \> 0\)  

o DonGia (decimal(18,2))  

o Primary Key: (MaHD, MaSP)  

2\. Yêu cầu chức năng hệ thống  

1\. Quản lý Danh mục (CRUD 3-Tier): 

o Xem, Thêm, Sửa, Xóa thông tin Sản phẩm, Khách hàng, Nhân  viên.  

o Tìm kiếm sản phẩm theo tên hoặc mã vạch bằng SqlParameter có  ký tự đại diện %.  

2\. Màn hình Bán hàng / Lập Hóa đơn (Bắt buộc dùng SqlTransaction):  

o Cho phép chọn/quét mã Sản phẩm, chọn số lượng và thêm vào giỏ  hàng (DataGridView).  

o Chọn Khách hàng (hoặc Khách lẻ). Tính tự động tổng tiền mặt và  điểm tích lũy.  

o Khi ấn "Thanh toán", mở một SqlTransaction thực hiện đồng thời:  1\. Chèn 1 bản ghi vào bảng HoaDon.  

2\. Chèn các bản ghi vào ChiTietHoaDon.  

3\. Trừ SoLuongTon tương ứng trong bảng SanPham (Nếu  

SoLuongTon \< SoLuong bán → gọi trans.Rollback() và báo  

lỗi).  

4\. Cộng điểm tích lũy cho Khách hàng (DiemTichLuy \+=  

TongTien / 100000).   
5\. Gọi trans.Commit() khi hoàn tất.  

3\. Báo cáo \- Thống kê: 

o Dùng ExecuteScalar tính tổng doanh thu trong ngày/tháng.  

o Dùng SqlDataReader hiển thị danh sách Top 5 sản phẩm bán chạy  nhất.  

BÀI 6.2: HỆ THỐNG QUẢN LÝ NHÂN SỰ & TÍNH LƯƠNG (HRM &  PAYROLL SYSTEM)  

Mục tiêu  

 Quản lý hồ sơ nhân sự, phòng ban, chấm công và công thức tính lương  nâng cao.  

 Sử dụng mô hình ngắt kết nối (Disconnected Model: DataSet, DataTable,  SqlDataAdapter) để nạp và cập nhật bảng chấm công hàng tháng.  

1\. Hướng dẫn chi tiết xây dựng CSDL (HRMDB)  

Tạo CSDL SQL Server bao gồm 4 bảng chính:  

1\. PhongBan (Phòng ban) 

o MaPB (int, Primary Key, Identity)  

o TenPB (nvarchar(100), NOT NULL)  

o Mota (nvarchar(255))  

2\. NhanVien (Hồ sơ nhân viên) 

o MaNV (int, Primary Key, Identity)  

o HoTen (nvarchar(100), NOT NULL)  

o NgaySinh (datetime)  

o CCCD (varchar(20), Unique)  

o MaPB (int, Foreign Key PhongBan)  

o LuongCoBan (decimal(18,2), Check \> 0\)  

o HeSoLuong (float, Default 1.0)  

3\. BangChamCong (Bảng chấm công tháng)  
o MaCong (int, Primary Key, Identity)  

o MaNV (int, Foreign Key NhanVien)  

o ThangNam (varchar(7)) — Ví dụ: "11/2026" 

o SoNgayCong (float, Check \<= 31\)  

o SoGioOT (float, Default 0\)  

4\. BangLuong (Bảng lương chi tiết) 

o MaLuong (int, Primary Key, Identity)  

o MaNV (int, Foreign Key NhanVien)  

o ThangNam (varchar(7))  

o ThucLinh (decimal(18,2))  

o Primary Key: (MaNV, ThangNam)  

2\. Yêu cầu chức năng hệ thống  

1\. Quản lý Hồ sơ Nhân sự (3-Tier CRUD): 

o Thêm, sửa, xóa thông tin nhân viên, chuyển phòng ban cho nhân  viên.  

o Tìm kiếm nhân viên theo tên, phòng ban hoặc mã CCCD (Sử dụng  parameterized query).  

2\. Chấm công ngắt kết nối (Disconnected Model):  

o Lựa chọn Tháng/Năm → Sử dụng SqlDataAdapter nạp toàn bộ  nhân viên vào DataTable chấm công trên DataGridView.  

o Nhập số ngày công và số giờ làm thêm (OT) trực tiếp trên lưới.  

o Bấm "Lưu chấm công": Sử dụng SqlCommandBuilder và  adapter.Update() để đồng bộ dữ liệu chấm công về SQL Server  trong 1 thao tác.  

3\. Tính Lương & Chốt Lương (SqlTransaction):  

o Áp dụng công thức: ThucLinh \= (LuongCoBan \* HeSoLuong / 22\)  \* SoNgayCong \+ (SoGioOT \* 50,000).   
o Bấm "Chốt lương tháng": Mở một SqlTransaction để ghi nhận  bảng lương cho toàn bộ nhân viên có trong tháng và khóa dữ liệu  chấm công.   
YÊU CẦU NỘP BÀI TRÊN GITHUB & CẤU TRÚC README.MD  

Sinh viên khởi tạo Repository công khai (Public) trên GitHub và tổ chức mã  nguồn theo quy chuẩn sau:  

1\. Cấu trúc thư mục Solution C\# (Chuẩn 3-Tier Architecture)  ├── Database/  

│ └── ScriptDB.sql \# Script khởi tạo CSDL SQL Server và chèn dữ  liệu mẫu  

├── ProjectName/  

│ ├── DTO/ \# Chứa các lớp Data Transfer Object  

│ ├── DAL/ \# Chứa các lớp Data Access Layer (Truy vấn  ADO.NET)  

│ ├── BUS/ \# Chứa các lớp Business Logic Layer (Xử lý nghiệp  vụ)  

│ ├── GUI/ \# Chứa Form giao diện WinForms (Presentation  Layer)  

│ └── App.config / Program.cs  

├── README.md \# Báo cáo chi tiết bài tập  

└── ProjectName.sln  

2\. Yêu cầu nội dung File README.md  

File README.md đặt ở thư mục gốc của repository phải có đầy đủ các nội  dung sau:  

MỤC 1: THÔNG TIN SINH VIÊN  

 Họ và tên sinh viên: \[Điền họ tên\]  

 Mã sinh viên: \[Điền MSV\]  

 Lớp / Khóa: \[Điền tên lớp\]  

MỤC 2: HÌNH ẢNH KẾT QUẢ CÁC MÀN HÌNH CHỨC NĂNG   
(Sinh viên chụp ảnh màn hình ứng dụng đang chạy thực tế và nhúng vào file  Markdown theo cú pháp \!\[Tên ảnh\](đường-dẫn-ảnh)) 

1\. Màn hình Chính / Tổng quan hệ thống:\!\[Màn hình  

chính\](images/01\_main\_screen.png)  

2\. Màn hình Quản lý Danh mục (CRUD \- Thêm/Sửa/Xóa):\!\[Màn hình  CRUD\](images/02\_crud\_screen.png)  

3\. Màn hình Thực thi Nghiệp vụ chính (Lập Hóa đơn / Bán hàng /  Chấm công / Đặt phòng):\!\[Màn hình Nghiệp  

vụ\](images/03\_transaction\_screen.png)  

4\. Màn hình Báo cáo \- Thống kê:\!\[Màn hình Thống  

kê\](images/04\_report\_screen.png)  

5\. Minh họa An toàn Dữ liệu (Phòng chống SQL Injection / Báo lỗi  Transaction Rollback):\!\[Minh họa Xử lý  

lỗi\](images/05\_error\_handling.png) 