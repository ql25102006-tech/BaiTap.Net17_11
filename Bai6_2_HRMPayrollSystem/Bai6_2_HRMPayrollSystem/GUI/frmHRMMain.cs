using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Bai6_2_HRMPayrollSystem.BUS;
using Bai6_2_HRMPayrollSystem.DTO;

namespace Bai6_2_HRMPayrollSystem.GUI
{
    public partial class frmHRMMain : Form
    {
        private readonly PhongBanBUS pbBUS = new PhongBanBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();
        private readonly ChamCongBUS ccBUS = new ChamCongBUS();
        private readonly BangLuongBUS blBUS = new BangLuongBUS();

        private SqlDataAdapter? chamCongAdapter;
        private DataTable? chamCongTable;

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public bool AutoLoadDatabase { get; set; } = true;

        public frmHRMMain()
        {
            InitializeComponent();
        }

        private void frmHRMMain_Load(object? sender, EventArgs e)
        {
            SetupGrids();
            UpdateClock();
            if (AutoLoadDatabase)
            {
                LoadInitialData();
            }
        }

        private void SetupGrids()
        {
            // 1. Nhân viên
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.Columns.Clear();
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 70 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên nhân viên", Width = 180 });
            var colNS = new DataGridViewTextBoxColumn { DataPropertyName = "NgaySinh", HeaderText = "Ngày sinh", Width = 100 };
            colNS.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns.Add(colNS);
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CCCD", HeaderText = "Số CCCD", Width = 120 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPB", HeaderText = "Phòng ban", Width = 180 });
            var colLuong = new DataGridViewTextBoxColumn { DataPropertyName = "LuongCoBan", HeaderText = "Lương cơ bản", Width = 130 };
            colLuong.DefaultCellStyle.Format = "N0";
            colLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNhanVien.Columns.Add(colLuong);
            var colHeSo = new DataGridViewTextBoxColumn { DataPropertyName = "HeSoLuong", HeaderText = "Hệ số", Width = 70 };
            colHeSo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.Columns.Add(colHeSo);

            // 2. Bảng lương
            dgvBangLuong.AutoGenerateColumns = false;
            dgvBangLuong.Columns.Clear();
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 70 });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ tên", Width = 170 });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenPB", HeaderText = "Phòng ban", Width = 160 });
            dgvBangLuong.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThangNam", HeaderText = "Tháng/Năm", Width = 90 });
            var colLCB = new DataGridViewTextBoxColumn { DataPropertyName = "LuongCoBan", HeaderText = "Lương CB", Width = 115 };
            colLCB.DefaultCellStyle.Format = "N0";
            colLCB.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBangLuong.Columns.Add(colLCB);
            var colHS = new DataGridViewTextBoxColumn { DataPropertyName = "HeSoLuong", HeaderText = "Hệ số", Width = 65 };
            colHS.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBangLuong.Columns.Add(colHS);
            var colCong = new DataGridViewTextBoxColumn { DataPropertyName = "SoNgayCong", HeaderText = "Ngày công", Width = 85 };
            colCong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBangLuong.Columns.Add(colCong);
            var colOT = new DataGridViewTextBoxColumn { DataPropertyName = "SoGioOT", HeaderText = "Giờ OT", Width = 75 };
            colOT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBangLuong.Columns.Add(colOT);
            var colTL = new DataGridViewTextBoxColumn { DataPropertyName = "ThucLinh", HeaderText = "Thực lĩnh (VNĐ)", Width = 140 };
            colTL.DefaultCellStyle.Format = "N0";
            colTL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBangLuong.Columns.Add(colTL);
        }

        private void LoadInitialData()
        {
            try
            {
                LoadPhongBan();
                LoadNhanVien();
                sslStatus.Text = "Kết nối CSDL HRMDB thành công (3-Tier & Disconnected Model)";
            }
            catch (Exception ex)
            {
                sslStatus.Text = "Chưa kết nối được SQL Server (Kiểm tra App.config / ScriptDB.sql)";
                MessageBox.Show($"Không thể kết nối CSDL HRMDB:\n{ex.Message}\n\nVui lòng chạy ScriptDB.sql trên SQL Server và kiểm tra App.config.",
                    "Thông báo kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPhongBan()
        {
            var listPB = pbBUS.GetAll();
            cboPhongBan.DataSource = null;
            cboPhongBan.DataSource = listPB;
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";

            var filterList = new List<PhongBanDTO> { new PhongBanDTO { MaPB = 0, TenPB = "-- Tất cả phòng ban --" } };
            filterList.AddRange(listPB);
            cboLocPhongBan.DataSource = null;
            cboLocPhongBan.DataSource = filterList;
            cboLocPhongBan.DisplayMember = "TenPB";
            cboLocPhongBan.ValueMember = "MaPB";
        }

        private void LoadNhanVien()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = nvBUS.GetAll();
        }

        // ==========================================
        // TAB 1: QUẢN LÝ HỒ SƠ NHÂN SỰ (3-TIER CRUD)
        // ==========================================
        private void dgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && dgvNhanVien.SelectedRows[0].DataBoundItem is NhanVienDTO nv)
            {
                txtHoTen.Text = nv.HoTen;
                dtpNgaySinh.Value = nv.NgaySinh;
                txtCCCD.Text = nv.CCCD;
                cboPhongBan.SelectedValue = nv.MaPB;
                txtLuongCoBan.Text = nv.LuongCoBan.ToString("G0");
                txtHeSoLuong.Text = nv.HeSoLuong.ToString();
            }
        }

        private bool ReadNhanVienInputs(out NhanVienDTO nv)
        {
            errorProvider1.Clear();
            nv = new NhanVienDTO();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                errorProvider1.SetError(txtCCCD, "Số CCCD không được để trống!");
                valid = false;
            }
            if (!decimal.TryParse(txtLuongCoBan.Text.Trim().Replace(",", ""), out decimal luongCB) || luongCB <= 0)
            {
                errorProvider1.SetError(txtLuongCoBan, "Lương cơ bản phải là số dương!");
                valid = false;
            }
            if (!double.TryParse(txtHeSoLuong.Text.Trim(), out double heSo) || heSo <= 0)
            {
                errorProvider1.SetError(txtHeSoLuong, "Hệ số lương phải là số dương!");
                valid = false;
            }
            if (cboPhongBan.SelectedValue == null)
            {
                errorProvider1.SetError(cboPhongBan, "Vui lòng chọn phòng ban!");
                valid = false;
            }

            if (valid)
            {
                nv.HoTen = txtHoTen.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value.Date;
                nv.CCCD = txtCCCD.Text.Trim();
                nv.MaPB = Convert.ToInt32(cboPhongBan.SelectedValue);
                nv.LuongCoBan = luongCB;
                nv.HeSoLuong = heSo;
            }

            return valid;
        }

        private void btnAddNV_Click(object? sender, EventArgs e)
        {
            if (!ReadNhanVienInputs(out NhanVienDTO nv)) return;
            try
            {
                if (nvBUS.Insert(nv))
                {
                    LoadNhanVien();
                    MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateNV_Click(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0 || dgvNhanVien.SelectedRows[0].DataBoundItem is not NhanVienDTO sel)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ReadNhanVienInputs(out NhanVienDTO nv)) return;
            nv.MaNV = sel.MaNV;

            try
            {
                if (nvBUS.Update(nv))
                {
                    LoadNhanVien();
                    MessageBox.Show("Cập nhật hồ sơ nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteNV_Click(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0 || dgvNhanVien.SelectedRows[0].DataBoundItem is not NhanVienDTO sel) return;
            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên [{sel.HoTen}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (nvBUS.Delete(sel.MaNV))
                    {
                        LoadNhanVien();
                        ClearNVInputs();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChuyenPB_Click(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0 || dgvNhanVien.SelectedRows[0].DataBoundItem is not NhanVienDTO sel)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chuyển phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboPhongBan.SelectedValue == null) return;
            int maPBMoi = Convert.ToInt32(cboPhongBan.SelectedValue);
            string tenPBMoi = cboPhongBan.Text;

            try
            {
                if (nvBUS.ChuyenPhongBan(sel.MaNV, maPBMoi))
                {
                    LoadNhanVien();
                    MessageBox.Show($"Đã chuyển nhân viên [{sel.HoTen}] sang [{tenPBMoi}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chuyển phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearNV_Click(object? sender, EventArgs e) => ClearNVInputs();

        private void ClearNVInputs()
        {
            errorProvider1.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtLuongCoBan.Clear();
            txtHeSoLuong.Text = "1.0";
            dtpNgaySinh.Value = DateTime.Today.AddYears(-22);
            if (cboPhongBan.Items.Count > 0) cboPhongBan.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void btnSearchNV_Click(object? sender, EventArgs e)
        {
            try
            {
                int? maPB = null;
                if (cboLocPhongBan.SelectedValue != null && int.TryParse(cboLocPhongBan.SelectedValue.ToString(), out int pbVal) && pbVal > 0)
                {
                    maPB = pbVal;
                }
                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = nvBUS.Search(txtSearchNV.Text, maPB);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm nhân sự: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReloadNV_Click(object? sender, EventArgs e)
        {
            txtSearchNV.Clear();
            if (cboLocPhongBan.Items.Count > 0) cboLocPhongBan.SelectedIndex = 0;
            try { LoadNhanVien(); } catch { }
        }

        // ==========================================
        // TAB 2: CHẤM CÔNG NGẮT KẾT NỐI (DISCONNECTED MODEL)
        // ==========================================
        private void btnLoadChamCong_Click(object? sender, EventArgs e)
        {
            string thangNam = dtpThangChamCong.Value.ToString("MM/yyyy");
            try
            {
                chamCongTable = ccBUS.LoadBangChamCong(thangNam, out chamCongAdapter);
                dgvChamCong.AutoGenerateColumns = true;
                dgvChamCong.DataSource = chamCongTable;

                // Cấu hình cột sau khi nạp DataTable
                if (dgvChamCong.Columns["MaCong"] is DataGridViewColumn colMaCong)
                {
                    colMaCong.HeaderText = "Mã công";
                    colMaCong.ReadOnly = true;
                }
                if (dgvChamCong.Columns["MaNV"] is DataGridViewColumn colMaNV)
                {
                    colMaNV.HeaderText = "Mã NV";
                    colMaNV.ReadOnly = true;
                }
                if (dgvChamCong.Columns["ThangNam"] is DataGridViewColumn colThang)
                {
                    colThang.HeaderText = "Tháng/Năm";
                    colThang.ReadOnly = true;
                }
                if (dgvChamCong.Columns["SoNgayCong"] is DataGridViewColumn colNgayCong)
                {
                    colNgayCong.HeaderText = "Số ngày công (0-31)";
                    colNgayCong.ReadOnly = false;
                }
                if (dgvChamCong.Columns["SoGioOT"] is DataGridViewColumn colOT)
                {
                    colOT.HeaderText = "Số giờ OT";
                    colOT.ReadOnly = false;
                }
                if (dgvChamCong.Columns["DaKhoa"] is DataGridViewColumn colKhoa)
                {
                    colKhoa.HeaderText = "Đã khóa lương";
                    colKhoa.ReadOnly = true;
                }

                sslStatus.Text = $"Đã nạp bảng chấm công tháng {thangNam} theo mô hình ngắt kết nối (SqlDataAdapter)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp bảng chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveChamCong_Click(object? sender, EventArgs e)
        {
            if (chamCongAdapter == null || chamCongTable == null)
            {
                MessageBox.Show("Vui lòng bấm 'Nạp bảng chấm công' trước khi lưu!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dgvChamCong.EndEdit();
                int updatedRows = ccBUS.SaveBangChamCong(chamCongAdapter, chamCongTable);
                MessageBox.Show($"Đồng bộ chấm công về SQL Server thành công! ({updatedRows} dòng được cập nhật)",
                    "Disconnected Model (SqlCommandBuilder)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu chấm công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TAB 3: TÍNH LƯƠNG & CHỐT LƯƠNG (TRANSACTION)
        // ==========================================
        private void btnChotLuong_Click(object? sender, EventArgs e)
        {
            string thangNam = dtpThangLuong.Value.ToString("MM/yyyy");
            if (MessageBox.Show($"Bạn có chắc chắn muốn chốt bảng lương tháng {thangNam} và khóa dữ liệu chấm công không?",
                "Xác nhận Chốt lương (SqlTransaction)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int count = blBUS.ChotLuongThang(thangNam);
                    LoadBangLuongThang(thangNam);
                    MessageBox.Show($"Đã chốt lương thành công cho {count} nhân viên trong tháng {thangNam}!\nDữ liệu chấm công tháng này đã được khóa an toàn.",
                        "Giao dịch thành công (Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể chốt lương (Giao dịch đã Rollback):\n{ex.Message}",
                        "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemBangLuong_Click(object? sender, EventArgs e)
        {
            string thangNam = dtpThangLuong.Value.ToString("MM/yyyy");
            try
            {
                LoadBangLuongThang(thangNam);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải bảng lương: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBangLuongThang(string thangNam)
        {
            var list = blBUS.GetBangLuongByThang(thangNam);
            dgvBangLuong.DataSource = null;
            dgvBangLuong.DataSource = list;

            decimal tongQuy = list.Sum(x => x.ThucLinh);
            lblTongQuyLuong.Text = $"Tổng quỹ lương: {tongQuy:N0} VNĐ";
        }

        private void UpdateClock()
        {
            sslClock.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timerClock_Tick(object? sender, EventArgs e)
        {
            UpdateClock();
        }
    }
}
