using System;
using System.Collections.Generic;
using Bai6_1_RetailSalesSystem.DAL;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll() => dal.GetAll();

        public bool Insert(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (kh.DiemTichLuy < 0)
                throw new ArgumentException("Điểm tích lũy không được âm!");
            return dal.Insert(kh);
        }

        public bool Update(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (kh.DiemTichLuy < 0)
                throw new ArgumentException("Điểm tích lũy không được âm!");
            return dal.Update(kh);
        }

        public bool Delete(int maKH) => dal.Delete(maKH);
    }
}
