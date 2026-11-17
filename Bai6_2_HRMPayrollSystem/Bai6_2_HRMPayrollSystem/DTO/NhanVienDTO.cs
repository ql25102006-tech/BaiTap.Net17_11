using System;

namespace Bai6_2_HRMPayrollSystem.DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string CCCD { get; set; } = string.Empty;
        public int MaPB { get; set; }
        public string TenPB { get; set; } = string.Empty;
        public decimal LuongCoBan { get; set; }
        public double HeSoLuong { get; set; } = 1.0;
    }
}
