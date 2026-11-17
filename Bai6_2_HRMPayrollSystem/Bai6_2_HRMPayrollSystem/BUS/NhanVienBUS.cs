using System;
using System.Collections.Generic;
using Bai6_2_HRMPayrollSystem.DAL;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL dal = new NhanVienDAL();

        public List<NhanVienDTO> GetAll() => dal.GetAll();

        public List<NhanVienDTO> Search(string keyword, int? maPB) => dal.Search(keyword, maPB);

        public bool Insert(NhanVienDTO nv)
        {
            Validate(nv);
            return dal.Insert(nv);
        }

        public bool Update(NhanVienDTO nv)
        {
            Validate(nv);
            return dal.Update(nv);
        }

        public bool ChuyenPhongBan(int maNV, int maPBMoi) => dal.ChuyenPhongBan(maNV, maPBMoi);

        public bool Delete(int maNV) => dal.Delete(maNV);

        private void Validate(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                throw new ArgumentException("Họ tên nhân viên không được để trống!");
            if (string.IsNullOrWhiteSpace(nv.CCCD))
                throw new ArgumentException("Số CCCD không được để trống!");
            if (nv.LuongCoBan <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0!");
            if (nv.HeSoLuong <= 0)
                throw new ArgumentException("Hệ số lương phải lớn hơn 0!");
        }
    }
}
