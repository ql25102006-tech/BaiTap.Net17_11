using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Bai6_1_RetailSalesSystem.BUS;
using Bai6_1_RetailSalesSystem.DTO;

namespace Bai6_1_RetailSalesSystem.GUI
{
    public partial class frmSalesMain : Form
    {
        private readonly SanPhamBUS spBUS = new SanPhamBUS();
        private readonly KhachHangBUS khBUS = new KhachHangBUS();
        private readonly NhanVienBUS nvBUS = new NhanVienBUS();
        private readonly HoaDonBUS hdBUS = new HoaDonBUS();

        private BindingList<ChiTietHoaDonDTO> gioHang = new BindingList<ChiTietHoaDonDTO>();
        private List<SanPhamDTO> dsSanPhamCache = new List<SanPhamDTO>();
        private List<KhachHangDTO> dsKhachHangCache = new List<KhachHangDTO>();
        private List<NhanVienDTO> dsNhanVienCache = new List<NhanVienDTO>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoLoadDatabase { get; set; } = true;

        public frmSalesMain()
        {
            InitializeComponent();
        }

        private void frmSalesMain_Load(object? sender, EventArgs e)
        {
            SetupGrids();
            SetupChucVu();
            UpdateClock();
            if (AutoLoadDatabase)
            {
                LoadAllData();
            }
        }

        private void SetupChucVu()
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.AddRange(new object[] { "Thu ngân", "Quản lý", "Nhân viên kho", "Nhân viên bán hàng" });
            cboChucVu.SelectedIndex = 0;
        }

        private void SetupGrids()
        {
            // 1. Giỏ hàng
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.Columns.Clear();
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSP", HeaderText = "Mã SP", Width = 100 });
            dgvGioHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenSP", HeaderText = "Tên sản phẩm", Width = 280 });
            var colDonGia = new DataGridViewTextBoxColumn { DataPropertyName = "DonGia", HeaderText = "Đơn giá (VNĐ)", Width = 140 };
            colDonGia.DefaultCellStyle.Format = "N0";
            colDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGioHang.Columns.Add(colDonGia);
            var colSL = new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "Số lượng", Width = 90 };
            colSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGioHang.Columns.Add(colSL);
            var colTT = new DataGridViewTextBoxColumn { DataPropertyName = "ThanhTien", HeaderText = "Thành tiền (VNĐ)", Width = 160 };
            colTT.DefaultCellStyle.Format = "N0";
            colTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvGioHang.Columns.Add(colTT);
            dgvGioHang.DataSource = gioHang;

            // 2. Sản phẩm
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.Columns.Clear();
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSP", HeaderText = "Mã SP", Width = 110 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenSP", HeaderText = "Tên sản phẩm", Width = 340 });
            var colGiaBan = new DataGridViewTextBoxColumn { DataPropertyName = "GiaBan", HeaderText = "Giá bán (VNĐ)", Width = 150 };
            colGiaBan.DefaultCellStyle.Format = "N0";
            colGiaBan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSanPham.Columns.Add(colGiaBan);
            var colTon = new DataGridViewTextBoxColumn { DataPropertyName = "SoLuongTon", HeaderText = "Số lượng tồn", Width = 110 };
            colTon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSanPham.Columns.Add(colTon);

            // 3. Khách hàng
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.Columns.Clear();
            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaKH", HeaderText = "Mã KH", Width = 70 });
            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenKH", HeaderText = "Họ tên khách hàng", Width = 170 });
            dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DienThoai", HeaderText = "Điện thoại", Width = 110 });
            var colDiem = new DataGridViewTextBoxColumn { DataPropertyName = "DiemTichLuy", HeaderText = "Điểm", Width = 70 };
            colDiem.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.Columns.Add(colDiem);

            // 4. Nhân viên
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.Columns.Clear();
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaNV", HeaderText = "Mã NV", Width = 70 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenNV", HeaderText = "Họ tên nhân viên", Width = 170 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Điện thoại", Width = 110 });
            dgvNhanVien.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ChucVu", HeaderText = "Chức vụ", Width = 100 });

            // 5. Top 5 Sản phẩm bán chạy
            dgvTop5.AutoGenerateColumns = false;
            dgvTop5.Columns.Clear();
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSP", HeaderText = "Mã SP", Width = 120 });
            dgvTop5.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenSP", HeaderText = "Tên sản phẩm", Width = 360 });
            var colTopSL = new DataGridViewTextBoxColumn { DataPropertyName = "TongSoLuongBan", HeaderText = "Tổng SL đã bán", Width = 140 };
            colTopSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTop5.Columns.Add(colTopSL);
            var colTopDT = new DataGridViewTextBoxColumn { DataPropertyName = "TongDoanhThu", HeaderText = "Tổng doanh thu (VNĐ)", Width = 180 };
            colTopDT.DefaultCellStyle.Format = "N0";
            colTopDT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTop5.Columns.Add(colTopDT);
        }

        private void LoadAllData()
        {
            try
            {
                LoadSanPham();
                LoadKhachHang();
                LoadNhanVien();
                LoadThongKe();
                sslStatus.Text = "Kết nối CSDL SalesDB thành công (Kiến trúc 3-Tier)";
            }
            catch (Exception ex)
            {
                sslStatus.Text = "Chưa kết nối được SQL Server (Kiểm tra App.config / ScriptDB.sql)";
                MessageBox.Show($"Không thể kết nối CSDL SalesDB:\n{ex.Message}\n\nVui lòng chạy ScriptDB.sql trên SQL Server và kiểm tra App.config.",
                    "Thông báo kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSanPham()
        {
            dsSanPhamCache = spBUS.GetAll();
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = dsSanPhamCache;

            cboSanPham.DataSource = null;
            cboSanPham.DataSource = dsSanPhamCache.Select(s => new
            {
                s.MaSP,
                Display = $"{s.MaSP} - {s.TenSP} ({s.GiaBan:N0} VNĐ | Tồn: {s.SoLuongTon})"
            }).ToList();
            cboSanPham.DisplayMember = "Display";
            cboSanPham.ValueMember = "MaSP";
        }

        private void LoadKhachHang()
        {
            dsKhachHangCache = khBUS.GetAll();
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = dsKhachHangCache;

            var khItems = new List<KeyValuePair<int?, string>>
            {
                new KeyValuePair<int?, string>(null, "-- Khách lẻ (Không tích điểm) --")
            };
            foreach (var kh in dsKhachHangCache)
            {
                khItems.Add(new KeyValuePair<int?, string>(kh.MaKH, $"{kh.TenKH} - {kh.DienThoai} ({kh.DiemTichLuy} điểm)"));
            }

            cboKhachHang.DataSource = null;
            cboKhachHang.DataSource = khItems;
            cboKhachHang.DisplayMember = "Value";
            cboKhachHang.ValueMember = "Key";
        }

        private void LoadNhanVien()
        {
            dsNhanVienCache = nvBUS.GetAll();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = dsNhanVienCache;

            cboNhanVien.DataSource = null;
            cboNhanVien.DataSource = dsNhanVienCache.Select(nv => new
            {
                nv.MaNV,
                Display = $"{nv.TenNV} ({nv.ChucVu})"
            }).ToList();
            cboNhanVien.DisplayMember = "Display";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void LoadThongKe()
        {
            decimal dtNgay = hdBUS.GetDoanhThuNgay();
            decimal dtThang = hdBUS.GetDoanhThuThang();
            txtDoanhThuNgay.Text = $"{dtNgay:N0} VNĐ";
            txtDoanhThuThang.Text = $"{dtThang:N0} VNĐ";

            var top5 = hdBUS.GetTop5SanPhamBanChay();
            dgvTop5.DataSource = null;
            dgvTop5.DataSource = top5;
        }

        // ==========================================
        // TAB 1: BÁN HÀNG & LẬP HÓA ĐƠN (TRANSACTION)
        // ==========================================
        private void btnThemGio_Click(object? sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null) return;
            string maSP = cboSanPham.SelectedValue.ToString()!;
            SanPhamDTO? sp = dsSanPhamCache.FirstOrDefault(s => s.MaSP == maSP);
            if (sp == null) return;

            int soLuong = (int)numSoLuongBan.Value;
            var existing = gioHang.FirstOrDefault(x => x.MaSP == maSP);
            if (existing != null)
            {
                existing.SoLuong += soLuong;
                gioHang.ResetBindings();
            }
            else
            {
                gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = soLuong
                });
            }

            CapNhatTongTienGioHang();
        }

        private void btnXoaGio_Click(object? sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count > 0 && dgvGioHang.SelectedRows[0].DataBoundItem is ChiTietHoaDonDTO item)
            {
                gioHang.Remove(item);
                CapNhatTongTienGioHang();
            }
        }

        private void btnHuyDon_Click(object? sender, EventArgs e)
        {
            gioHang.Clear();
            CapNhatTongTienGioHang();
        }

        private void CapNhatTongTienGioHang()
        {
            decimal tongTien = gioHang.Sum(x => x.ThanhTien);
            int diemCong = (int)(tongTien / 100000m);
            txtTongTien.Text = $"{tongTien:N0} VNĐ";
            txtDiemCong.Text = $"{diemCong} điểm";
        }

        private void btnThanhToan_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cboNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên bán hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNV = Convert.ToInt32(cboNhanVien.SelectedValue);
                int? maKH = cboKhachHang.SelectedValue as int?;
                decimal tongTien = gioHang.Sum(x => x.ThanhTien);

                HoaDonDTO hd = new HoaDonDTO
                {
                    MaNV = maNV,
                    MaKH = maKH,
                    TongTien = tongTien,
                    ChiTiet = gioHang.ToList()
                };

                int maHDMoi = hdBUS.ThanhToanHoaDon(hd);

                MessageBox.Show($"Thanh toán thành công Hóa đơn số #{maHDMoi}!\nTổng tiền: {tongTien:N0} VNĐ\nĐã trừ tồn kho và cập nhật điểm tích lũy.",
                    "Giao dịch thành công (Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gioHang.Clear();
                CapNhatTongTienGioHang();
                LoadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Giao dịch thất bại (Đã Rollback):\n{ex.Message}",
                    "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TAB 2: QUẢN LÝ SẢN PHẨM (CRUD & TÌM KIẾM)
        // ==========================================
        private void dgvSanPham_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0 && dgvSanPham.SelectedRows[0].DataBoundItem is SanPhamDTO sp)
            {
                txtMaSP.Text = sp.MaSP;
                txtTenSP.Text = sp.TenSP;
                txtGiaBan.Text = sp.GiaBan.ToString("G0");
                numTonKho.Value = sp.SoLuongTon;
            }
        }

        private void btnAddSP_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtGiaBan.Text.Trim().Replace(",", ""), out decimal giaBan))
                {
                    errorProvider1.SetError(txtGiaBan, "Giá bán phải là số hợp lệ!");
                    return;
                }
                errorProvider1.Clear();

                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = giaBan,
                    SoLuongTon = (int)numTonKho.Value
                };

                if (spBUS.Insert(sp))
                {
                    LoadSanPham();
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSP_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtGiaBan.Text.Trim().Replace(",", ""), out decimal giaBan))
                {
                    errorProvider1.SetError(txtGiaBan, "Giá bán phải là số hợp lệ!");
                    return;
                }
                errorProvider1.Clear();

                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = giaBan,
                    SoLuongTon = (int)numTonKho.Value
                };

                if (spBUS.Update(sp))
                {
                    LoadSanPham();
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSP_Click(object? sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            if (string.IsNullOrEmpty(maSP)) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm [{maSP}] không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (spBUS.Delete(maSP))
                    {
                        LoadSanPham();
                        ClearSPInputs();
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearSP_Click(object? sender, EventArgs e) => ClearSPInputs();

        private void ClearSPInputs()
        {
            errorProvider1.Clear();
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            numTonKho.Value = 0;
            txtMaSP.Focus();
        }

        private void btnSearchSP_Click(object? sender, EventArgs e)
        {
            try
            {
                var result = spBUS.Search(txtSearchSP.Text);
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReloadSP_Click(object? sender, EventArgs e)
        {
            txtSearchSP.Clear();
            try { LoadSanPham(); } catch { }
        }

        // ==========================================
        // TAB 3: KHÁCH HÀNG & NHÂN VIÊN
        // ==========================================
        private void dgvKhachHang_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0 && dgvKhachHang.SelectedRows[0].DataBoundItem is KhachHangDTO kh)
            {
                txtTenKH.Text = kh.TenKH;
                txtDTKH.Text = kh.DienThoai;
                numDiemKH.Value = kh.DiemTichLuy;
            }
        }

        private void btnAddKH_Click(object? sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHangDTO { TenKH = txtTenKH.Text.Trim(), DienThoai = txtDTKH.Text.Trim(), DiemTichLuy = (int)numDiemKH.Value };
                if (khBUS.Insert(kh)) { LoadKhachHang(); MessageBox.Show("Thêm khách hàng thành công!"); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private void btnUpdateKH_Click(object? sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0 || dgvKhachHang.SelectedRows[0].DataBoundItem is not KhachHangDTO sel) return;
            try
            {
                sel.TenKH = txtTenKH.Text.Trim();
                sel.DienThoai = txtDTKH.Text.Trim();
                sel.DiemTichLuy = (int)numDiemKH.Value;
                if (khBUS.Update(sel)) { LoadKhachHang(); MessageBox.Show("Cập nhật khách hàng thành công!"); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private void btnDeleteKH_Click(object? sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0 || dgvKhachHang.SelectedRows[0].DataBoundItem is not KhachHangDTO sel) return;
            if (MessageBox.Show($"Xóa khách hàng [{sel.TenKH}]?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { if (khBUS.Delete(sel.MaKH)) LoadKhachHang(); }
                catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
            }
        }

        private void dgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0 && dgvNhanVien.SelectedRows[0].DataBoundItem is NhanVienDTO nv)
            {
                txtTenNV.Text = nv.TenNV;
                txtDTNV.Text = nv.SoDienThoai;
                cboChucVu.SelectedItem = nv.ChucVu;
            }
        }

        private void btnAddNV_Click(object? sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVienDTO { TenNV = txtTenNV.Text.Trim(), SoDienThoai = txtDTNV.Text.Trim(), ChucVu = cboChucVu.SelectedItem?.ToString() ?? "Thu ngân" };
                if (nvBUS.Insert(nv)) { LoadNhanVien(); MessageBox.Show("Thêm nhân viên thành công!"); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private void btnUpdateNV_Click(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0 || dgvNhanVien.SelectedRows[0].DataBoundItem is not NhanVienDTO sel) return;
            try
            {
                sel.TenNV = txtTenNV.Text.Trim();
                sel.SoDienThoai = txtDTNV.Text.Trim();
                sel.ChucVu = cboChucVu.SelectedItem?.ToString() ?? "Thu ngân";
                if (nvBUS.Update(sel)) { LoadNhanVien(); MessageBox.Show("Cập nhật nhân viên thành công!"); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
        }

        private void btnDeleteNV_Click(object? sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0 || dgvNhanVien.SelectedRows[0].DataBoundItem is not NhanVienDTO sel) return;
            if (MessageBox.Show($"Xóa nhân viên [{sel.TenNV}]?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { if (nvBUS.Delete(sel.MaNV)) LoadNhanVien(); }
                catch (Exception ex) { MessageBox.Show($"Lỗi: {ex.Message}"); }
            }
        }

        // ==========================================
        // TAB 4: BÁO CÁO THỐNG KÊ
        // ==========================================
        private void btnThongKe_Click(object? sender, EventArgs e)
        {
            try
            {
                LoadThongKe();
                MessageBox.Show("Đã cập nhật số liệu báo cáo mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
