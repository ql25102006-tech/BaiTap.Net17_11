using System;
using System.Collections.Generic;

namespace Bai6_1_RetailSalesSystem.DTO
{
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public int? MaKH { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietHoaDonDTO> ChiTiet { get; set; } = new List<ChiTietHoaDonDTO>();
    }

    public class ChiTietHoaDonDTO
    {
        public int MaHD { get; set; }
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    public class TopSanPhamDTO
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public int TongSoLuongBan { get; set; }
        public decimal TongDoanhThu { get; set; }
    }
}
