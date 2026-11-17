using System;
using System.Collections.Generic;
using Bai6_1_RetailSalesSystem.DAL;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();

        public int ThanhToanHoaDon(HoaDonDTO hoaDon)
        {
            if (hoaDon.MaNV <= 0)
                throw new ArgumentException("Vui lòng chọn nhân viên lập hóa đơn!");
            if (hoaDon.ChiTiet == null || hoaDon.ChiTiet.Count == 0)
                throw new ArgumentException("Giỏ hàng đang trống! Vui lòng thêm sản phẩm trước khi thanh toán.");
            if (hoaDon.TongTien <= 0)
                throw new ArgumentException("Tổng tiền hóa đơn phải lớn hơn 0!");

            return dal.ThanhToanHoaDon(hoaDon);
        }

        public decimal GetDoanhThuNgay() => dal.GetDoanhThuNgay();

        public decimal GetDoanhThuThang() => dal.GetDoanhThuThang();

        public List<TopSanPhamDTO> GetTop5SanPhamBanChay() => dal.GetTop5SanPhamBanChay();
    }
}
