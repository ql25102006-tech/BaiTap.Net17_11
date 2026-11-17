using System;
using System.Collections.Generic;
using Bai6_2_HRMPayrollSystem.DAL;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.BUS
{
    public class BangLuongBUS
    {
        private readonly BangLuongDAL dal = new BangLuongDAL();

        public int ChotLuongThang(string thangNam)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Vui lòng chọn Tháng/Năm cần chốt lương!");
            return dal.ChotLuongThang(thangNam);
        }

        public List<BangLuongDTO> GetBangLuongByThang(string thangNam)
        {
            return dal.GetBangLuongByThang(thangNam);
        }
    }
}
