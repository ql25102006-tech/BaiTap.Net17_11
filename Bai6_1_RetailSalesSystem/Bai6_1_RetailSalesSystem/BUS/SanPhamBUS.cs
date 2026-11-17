using System;
using System.Collections.Generic;
using Bai6_1_RetailSalesSystem.DAL;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL dal = new SanPhamDAL();

        public List<SanPhamDTO> GetAll() => dal.GetAll();

        public List<SanPhamDTO> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return dal.GetAll();
            return dal.Search(keyword);
        }

        public bool Insert(SanPhamDTO sp)
        {
            Validate(sp);
            return dal.Insert(sp);
        }

        public bool Update(SanPhamDTO sp)
        {
            Validate(sp);
            return dal.Update(sp);
        }

        public bool Delete(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Mã sản phẩm không hợp lệ!");
            return dal.Delete(maSP);
        }

        private void Validate(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn kho không được âm!");
        }
    }
}
