using System.Collections.Generic;
using Bai6_2_HRMPayrollSystem.DAL;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.BUS
{
    public class PhongBanBUS
    {
        private readonly PhongBanDAL dal = new PhongBanDAL();
        public List<PhongBanDTO> GetAll() => dal.GetAll();
    }
}
