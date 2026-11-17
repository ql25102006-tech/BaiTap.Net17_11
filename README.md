# Báo Cáo Thực Hành Bài Tập Ngày 17/11 (Bài 6.1 - 6.2)

## MỤC 1: THÔNG TIN SINH VIÊN
- **Họ và tên sinh viên:** Lê Ngọc Quyền
- **Mã sinh viên:** 24810310259
- **Lớp / Khóa:** D19CNPM3
- **Môn học:** Lập trình C# / Windows Forms (ADO.NET & Kiến trúc 3-Tier)

---

## DANH SÁCH BÀI TẬP ĐÃ HOÀN THÀNH

1. **[Bài 6.1: Hệ thống Quản lý Bán hàng & Siêu thị Mini (Retail Sales System)](./Bai6_1_RetailSalesSystem)**
   - Chuẩn cấu trúc 3-Tier (`DTO`, `DAL`, `BUS`, `GUI`), `Database/ScriptDB.sql` (`SalesDB`), `App.config`, `Bai6_1_RetailSalesSystem.slnx`.
   - Giao dịch `SqlTransaction` thanh toán hóa đơn, trừ tồn kho (tự động Rollback nếu thiếu hàng), cộng điểm tích lũy, báo cáo doanh thu (`ExecuteScalar`) và Top 5 sản phẩm bán chạy (`SqlDataReader`).

2. **[Bài 6.2: Hệ thống Quản lý Nhân sự & Tính lương (HRM & Payroll System)](./Bai6_2_HRMPayrollSystem)**
   - Chuẩn cấu trúc 3-Tier (`DTO`, `DAL`, `BUS`, `GUI`), `Database/ScriptDB.sql` (`HRMDB`), `App.config`, `Bai6_2_HRMPayrollSystem.slnx`.
   - Quản lý hồ sơ nhân sự, mô hình ngắt kết nối (`SqlDataAdapter` + `DataTable` + `SqlCommandBuilder`) cho chấm công tháng, và `SqlTransaction` chốt lương & khóa chấm công.
