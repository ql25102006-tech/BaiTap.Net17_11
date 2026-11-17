using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Bai6_2_HRMPayrollSystem.DAL;

namespace Bai6_2_HRMPayrollSystem.BUS
{
    public class ChamCongBUS
    {
        private readonly ChamCongDAL dal = new ChamCongDAL();

        public DataTable LoadBangChamCong(string thangNam, out SqlDataAdapter adapter)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Vui lòng chọn Tháng/Năm chấm công!");
            return dal.LoadBangChamCong(thangNam, out adapter);
        }

        public int SaveBangChamCong(SqlDataAdapter adapter, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState == DataRowState.Deleted) continue;

                double ngayCong = Convert.ToDouble(row["SoNgayCong"]);
                double gioOT = Convert.ToDouble(row["SoGioOT"]);
                bool daKhoa = row["DaKhoa"] != DBNull.Value && Convert.ToBoolean(row["DaKhoa"]);

                if (daKhoa && row.RowState == DataRowState.Modified)
                {
                    throw new InvalidOperationException("Dữ liệu chấm công tháng này đã bị khóa sau khi chốt lương, không thể chỉnh sửa!");
                }
                if (ngayCong < 0 || ngayCong > 31)
                {
                    throw new ArgumentException("Số ngày công phải nằm trong khoảng từ 0 đến 31!");
                }
                if (gioOT < 0)
                {
                    throw new ArgumentException("Số giờ làm thêm (OT) không được âm!");
                }
            }
            return dal.SaveBangChamCong(adapter, dt);
        }
    }
}
