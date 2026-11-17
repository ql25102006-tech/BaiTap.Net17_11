using System;
using System.Collections.Generic;
using Bai6_1_RetailSalesSystem.DAL;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll() => dal.GetAll();

        public bool Insert(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            return dal.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            return dal.Update(nv);
        }

        public bool Delete(int maNV) => dal.Delete(maNV);
    }
}
