namespace Bai6_1_RetailSalesSystem.GUI
{
    partial class frmSalesMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabMain = new TabControl();
            tabBanHang = new TabPage();
            grpThongTinHD = new GroupBox();
            btnThemGio = new Button();
            numSoLuongBan = new NumericUpDown();
            lblSLBan = new Label();
            cboSanPham = new ComboBox();
            lblChonSP = new Label();
            cboKhachHang = new ComboBox();
            lblChonKH = new Label();
            cboNhanVien = new ComboBox();
            lblChonNV = new Label();
            grpGioHang = new GroupBox();
            dgvGioHang = new DataGridView();
            pnlThanhToan = new Panel();
            btnHuyDon = new Button();
            btnThanhToan = new Button();
            btnXoaGio = new Button();
            txtDiemCong = new TextBox();
            lblDiemCong = new Label();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            tabSanPham = new TabPage();
            grpSPInput = new GroupBox();
            numTonKho = new NumericUpDown();
            lblTonKho = new Label();
            txtGiaBan = new TextBox();
            lblGiaBan = new Label();
            txtTenSP = new TextBox();
            lblTenSP = new Label();
            txtMaSP = new TextBox();
            lblMaSP = new Label();
            btnClearSP = new Button();
            btnDeleteSP = new Button();
            btnUpdateSP = new Button();
            btnAddSP = new Button();
            grpSPTimKiem = new GroupBox();
            btnReloadSP = new Button();
            btnSearchSP = new Button();
            txtSearchSP = new TextBox();
            lblSearchSP = new Label();
            dgvSanPham = new DataGridView();
            tabKhachHangNhanVien = new TabPage();
            splitKHNV = new SplitContainer();
            grpKhachHang = new GroupBox();
            dgvKhachHang = new DataGridView();
            btnDeleteKH = new Button();
            btnUpdateKH = new Button();
            btnAddKH = new Button();
            numDiemKH = new NumericUpDown();
            lblDiemKH = new Label();
            txtDTKH = new TextBox();
            lblDTKH = new Label();
            txtTenKH = new TextBox();
            lblTenKH = new Label();
            grpNhanVien = new GroupBox();
            dgvNhanVien = new DataGridView();
            btnDeleteNV = new Button();
            btnUpdateNV = new Button();
            btnAddNV = new Button();
            cboChucVu = new ComboBox();
            lblChucVu = new Label();
            txtDTNV = new TextBox();
            lblDTNV = new Label();
            txtTenNV = new TextBox();
            lblTenNV = new Label();
            tabBaoCao = new TabPage();
            grpDoanhThu = new GroupBox();
            btnThongKe = new Button();
            txtDoanhThuThang = new TextBox();
            lblDoanhThuThang = new Label();
            txtDoanhThuNgay = new TextBox();
            lblDoanhThuNgay = new Label();
            grpTop5 = new GroupBox();
            dgvTop5 = new DataGridView();
            statusStrip1 = new StatusStrip();
            sslStatus = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            tabMain.SuspendLayout();
            tabBanHang.SuspendLayout();
            grpThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            pnlThanhToan.SuspendLayout();
            tabSanPham.SuspendLayout();
            grpSPInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTonKho).BeginInit();
            grpSPTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tabKhachHangNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitKHNV).BeginInit();
            splitKHNV.Panel1.SuspendLayout();
            splitKHNV.Panel2.SuspendLayout();
            splitKHNV.SuspendLayout();
            grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiemKH).BeginInit();
            grpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tabBaoCao.SuspendLayout();
            grpDoanhThu.SuspendLayout();
            grpTop5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabBanHang);
            tabMain.Controls.Add(tabSanPham);
            tabMain.Controls.Add(tabKhachHangNhanVien);
            tabMain.Controls.Add(tabBaoCao);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1060, 624);
            tabMain.TabIndex = 0;
            // 
            // tabBanHang
            // 
            tabBanHang.Controls.Add(grpGioHang);
            tabBanHang.Controls.Add(pnlThanhToan);
            tabBanHang.Controls.Add(grpThongTinHD);
            tabBanHang.Location = new Point(4, 29);
            tabBanHang.Name = "tabBanHang";
            tabBanHang.Padding = new Padding(8);
            tabBanHang.Size = new Size(1052, 591);
            tabBanHang.TabIndex = 0;
            tabBanHang.Text = "Bán hàng & Lập Hóa đơn";
            tabBanHang.UseVisualStyleBackColor = true;
            // 
            // grpThongTinHD
            // 
            grpThongTinHD.Controls.Add(btnThemGio);
            grpThongTinHD.Controls.Add(numSoLuongBan);
            grpThongTinHD.Controls.Add(lblSLBan);
            grpThongTinHD.Controls.Add(cboSanPham);
            grpThongTinHD.Controls.Add(lblChonSP);
            grpThongTinHD.Controls.Add(cboKhachHang);
            grpThongTinHD.Controls.Add(lblChonKH);
            grpThongTinHD.Controls.Add(cboNhanVien);
            grpThongTinHD.Controls.Add(lblChonNV);
            grpThongTinHD.Dock = DockStyle.Top;
            grpThongTinHD.Location = new Point(8, 8);
            grpThongTinHD.Name = "grpThongTinHD";
            grpThongTinHD.Size = new Size(1036, 120);
            grpThongTinHD.TabIndex = 0;
            grpThongTinHD.TabStop = false;
            grpThongTinHD.Text = "Thông tin lập hóa đơn bán hàng";
            // 
            // lblChonNV
            // 
            lblChonNV.AutoSize = true;
            lblChonNV.Location = new Point(20, 32);
            lblChonNV.Name = "lblChonNV";
            lblChonNV.Size = new Size(109, 20);
            lblChonNV.TabIndex = 0;
            lblChonNV.Text = "Nhân viên bán:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(140, 29);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(280, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // lblChonKH
            // 
            lblChonKH.AutoSize = true;
            lblChonKH.Location = new Point(460, 32);
            lblChonKH.Name = "lblChonKH";
            lblChonKH.Size = new Size(92, 20);
            lblChonKH.TabIndex = 2;
            lblChonKH.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(565, 29);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(300, 28);
            cboKhachHang.TabIndex = 3;
            // 
            // lblChonSP
            // 
            lblChonSP.AutoSize = true;
            lblChonSP.Location = new Point(20, 74);
            lblChonSP.Name = "lblChonSP";
            lblChonSP.Size = new Size(110, 20);
            lblChonSP.TabIndex = 4;
            lblChonSP.Text = "Chọn sản phẩm:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(140, 71);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(420, 28);
            cboSanPham.TabIndex = 5;
            // 
            // lblSLBan
            // 
            lblSLBan.AutoSize = true;
            lblSLBan.Location = new Point(580, 74);
            lblSLBan.Name = "lblSLBan";
            lblSLBan.Size = new Size(72, 20);
            lblSLBan.TabIndex = 6;
            lblSLBan.Text = "Số lượng:";
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(660, 72);
            numSoLuongBan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuongBan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(90, 27);
            numSoLuongBan.TabIndex = 7;
            numSoLuongBan.TextAlign = HorizontalAlignment.Right;
            numSoLuongBan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemGio
            // 
            btnThemGio.Location = new Point(770, 69);
            btnThemGio.Name = "btnThemGio";
            btnThemGio.Size = new Size(160, 32);
            btnThemGio.TabIndex = 8;
            btnThemGio.Text = "Thêm vào giỏ hàng";
            btnThemGio.UseVisualStyleBackColor = true;
            btnThemGio.Click += btnThemGio_Click;
            // 
            // pnlThanhToan
            // 
            pnlThanhToan.Controls.Add(btnHuyDon);
            pnlThanhToan.Controls.Add(btnThanhToan);
            pnlThanhToan.Controls.Add(btnXoaGio);
            pnlThanhToan.Controls.Add(txtDiemCong);
            pnlThanhToan.Controls.Add(lblDiemCong);
            pnlThanhToan.Controls.Add(txtTongTien);
            pnlThanhToan.Controls.Add(lblTongTien);
            pnlThanhToan.Dock = DockStyle.Bottom;
            pnlThanhToan.Location = new Point(8, 493);
            pnlThanhToan.Name = "pnlThanhToan";
            pnlThanhToan.Size = new Size(1036, 90);
            pnlThanhToan.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTien.Location = new Point(20, 18);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(105, 23);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTongTien.Location = new Point(140, 15);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(210, 30);
            txtTongTien.TabIndex = 1;
            txtTongTien.Text = "0 VNĐ";
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiemCong
            // 
            lblDiemCong.AutoSize = true;
            lblDiemCong.Location = new Point(20, 56);
            lblDiemCong.Name = "lblDiemCong";
            lblDiemCong.Size = new Size(115, 20);
            lblDiemCong.TabIndex = 2;
            lblDiemCong.Text = "Điểm cộng thêm:";
            // 
            // txtDiemCong
            // 
            txtDiemCong.Location = new Point(140, 53);
            txtDiemCong.Name = "txtDiemCong";
            txtDiemCong.ReadOnly = true;
            txtDiemCong.Size = new Size(210, 27);
            txtDiemCong.TabIndex = 3;
            txtDiemCong.Text = "0 điểm";
            txtDiemCong.TextAlign = HorizontalAlignment.Right;
            // 
            // btnXoaGio
            // 
            btnXoaGio.Location = new Point(380, 22);
            btnXoaGio.Name = "btnXoaGio";
            btnXoaGio.Size = new Size(140, 42);
            btnXoaGio.TabIndex = 4;
            btnXoaGio.Text = "Xóa dòng khỏi giỏ";
            btnXoaGio.UseVisualStyleBackColor = true;
            btnXoaGio.Click += btnXoaGio_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThanhToan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThanhToan.Location = new Point(780, 20);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(240, 46);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán (SqlTransaction)";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuyDon
            // 
            btnHuyDon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHuyDon.Location = new Point(630, 22);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(135, 42);
            btnHuyDon.TabIndex = 6;
            btnHuyDon.Text = "Làm mới giỏ hàng";
            btnHuyDon.UseVisualStyleBackColor = true;
            btnHuyDon.Click += btnHuyDon_Click;
            // 
            // grpGioHang
            // 
            grpGioHang.Controls.Add(dgvGioHang);
            grpGioHang.Dock = DockStyle.Fill;
            grpGioHang.Location = new Point(8, 128);
            grpGioHang.Name = "grpGioHang";
            grpGioHang.Padding = new Padding(8);
            grpGioHang.Size = new Size(1036, 365);
            grpGioHang.TabIndex = 2;
            grpGioHang.TabStop = false;
            grpGioHang.Text = "Chi tiết giỏ hàng hóa đơn";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.Location = new Point(8, 28);
            dgvGioHang.MultiSelect = false;
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.ReadOnly = true;
            dgvGioHang.RowHeadersWidth = 35;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(1020, 329);
            dgvGioHang.TabIndex = 0;
            // 
            // tabSanPham
            // 
            tabSanPham.Controls.Add(dgvSanPham);
            tabSanPham.Controls.Add(grpSPTimKiem);
            tabSanPham.Controls.Add(grpSPInput);
            tabSanPham.Location = new Point(4, 29);
            tabSanPham.Name = "tabSanPham";
            tabSanPham.Padding = new Padding(8);
            tabSanPham.Size = new Size(1052, 591);
            tabSanPham.TabIndex = 1;
            tabSanPham.Text = "Quản lý Sản phẩm";
            tabSanPham.UseVisualStyleBackColor = true;
            // 
            // grpSPInput
            // 
            grpSPInput.Controls.Add(btnClearSP);
            grpSPInput.Controls.Add(btnDeleteSP);
            grpSPInput.Controls.Add(btnUpdateSP);
            grpSPInput.Controls.Add(btnAddSP);
            grpSPInput.Controls.Add(numTonKho);
            grpSPInput.Controls.Add(lblTonKho);
            grpSPInput.Controls.Add(txtGiaBan);
            grpSPInput.Controls.Add(lblGiaBan);
            grpSPInput.Controls.Add(txtTenSP);
            grpSPInput.Controls.Add(lblTenSP);
            grpSPInput.Controls.Add(txtMaSP);
            grpSPInput.Controls.Add(lblMaSP);
            grpSPInput.Dock = DockStyle.Top;
            grpSPInput.Location = new Point(8, 8);
            grpSPInput.Name = "grpSPInput";
            grpSPInput.Size = new Size(1036, 120);
            grpSPInput.TabIndex = 0;
            grpSPInput.TabStop = false;
            grpSPInput.Text = "Thông tin Sản phẩm";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(20, 32);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(53, 20);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(100, 29);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(160, 27);
            txtMaSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(280, 32);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(55, 20);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên SP:";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(350, 29);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(310, 27);
            txtTenSP.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(20, 74);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(62, 20);
            lblGiaBan.TabIndex = 4;
            lblGiaBan.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(100, 71);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(160, 27);
            txtGiaBan.TabIndex = 5;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Location = new Point(280, 74);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(65, 20);
            lblTonKho.TabIndex = 6;
            lblTonKho.Text = "Tồn kho:";
            // 
            // numTonKho
            // 
            numTonKho.Location = new Point(350, 71);
            numTonKho.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTonKho.Name = "numTonKho";
            numTonKho.Size = new Size(120, 27);
            numTonKho.TabIndex = 7;
            numTonKho.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAddSP
            // 
            btnAddSP.Location = new Point(700, 26);
            btnAddSP.Name = "btnAddSP";
            btnAddSP.Size = new Size(140, 34);
            btnAddSP.TabIndex = 8;
            btnAddSP.Text = "Thêm sản phẩm";
            btnAddSP.UseVisualStyleBackColor = true;
            btnAddSP.Click += btnAddSP_Click;
            // 
            // btnUpdateSP
            // 
            btnUpdateSP.Location = new Point(855, 26);
            btnUpdateSP.Name = "btnUpdateSP";
            btnUpdateSP.Size = new Size(140, 34);
            btnUpdateSP.TabIndex = 9;
            btnUpdateSP.Text = "Cập nhật SP";
            btnUpdateSP.UseVisualStyleBackColor = true;
            btnUpdateSP.Click += btnUpdateSP_Click;
            // 
            // btnDeleteSP
            // 
            btnDeleteSP.Location = new Point(700, 70);
            btnDeleteSP.Name = "btnDeleteSP";
            btnDeleteSP.Size = new Size(140, 34);
            btnDeleteSP.TabIndex = 10;
            btnDeleteSP.Text = "Xóa sản phẩm";
            btnDeleteSP.UseVisualStyleBackColor = true;
            btnDeleteSP.Click += btnDeleteSP_Click;
            // 
            // btnClearSP
            // 
            btnClearSP.Location = new Point(855, 70);
            btnClearSP.Name = "btnClearSP";
            btnClearSP.Size = new Size(140, 34);
            btnClearSP.TabIndex = 11;
            btnClearSP.Text = "Làm mới";
            btnClearSP.UseVisualStyleBackColor = true;
            btnClearSP.Click += btnClearSP_Click;
            // 
            // grpSPTimKiem
            // 
            grpSPTimKiem.Controls.Add(btnReloadSP);
            grpSPTimKiem.Controls.Add(btnSearchSP);
            grpSPTimKiem.Controls.Add(txtSearchSP);
            grpSPTimKiem.Controls.Add(lblSearchSP);
            grpSPTimKiem.Dock = DockStyle.Top;
            grpSPTimKiem.Location = new Point(8, 128);
            grpSPTimKiem.Name = "grpSPTimKiem";
            grpSPTimKiem.Size = new Size(1036, 70);
            grpSPTimKiem.TabIndex = 1;
            grpSPTimKiem.TabStop = false;
            grpSPTimKiem.Text = "Tìm kiếm Sản phẩm (Parameterized LIKE %)";
            // 
            // lblSearchSP
            // 
            lblSearchSP.AutoSize = true;
            lblSearchSP.Location = new Point(20, 30);
            lblSearchSP.Name = "lblSearchSP";
            lblSearchSP.Size = new Size(138, 20);
            lblSearchSP.TabIndex = 0;
            lblSearchSP.Text = "Từ khóa (Mã / Tên):";
            // 
            // txtSearchSP
            // 
            txtSearchSP.Location = new Point(165, 27);
            txtSearchSP.Name = "txtSearchSP";
            txtSearchSP.PlaceholderText = "Nhập mã vạch hoặc tên sản phẩm để tìm kiếm...";
            txtSearchSP.Size = new Size(450, 27);
            txtSearchSP.TabIndex = 1;
            // 
            // btnSearchSP
            // 
            btnSearchSP.Location = new Point(630, 25);
            btnSearchSP.Name = "btnSearchSP";
            btnSearchSP.Size = new Size(120, 32);
            btnSearchSP.TabIndex = 2;
            btnSearchSP.Text = "Tìm kiếm";
            btnSearchSP.UseVisualStyleBackColor = true;
            btnSearchSP.Click += btnSearchSP_Click;
            // 
            // btnReloadSP
            // 
            btnReloadSP.Location = new Point(765, 25);
            btnReloadSP.Name = "btnReloadSP";
            btnReloadSP.Size = new Size(120, 32);
            btnReloadSP.TabIndex = 3;
            btnReloadSP.Text = "Tải lại tất cả";
            btnReloadSP.UseVisualStyleBackColor = true;
            btnReloadSP.Click += btnReloadSP_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(8, 198);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 35;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1036, 385);
            dgvSanPham.TabIndex = 2;
            dgvSanPham.SelectionChanged += dgvSanPham_SelectionChanged;
            // 
            // tabKhachHangNhanVien
            // 
            tabKhachHangNhanVien.Controls.Add(splitKHNV);
            tabKhachHangNhanVien.Location = new Point(4, 29);
            tabKhachHangNhanVien.Name = "tabKhachHangNhanVien";
            tabKhachHangNhanVien.Padding = new Padding(8);
            tabKhachHangNhanVien.Size = new Size(1052, 591);
            tabKhachHangNhanVien.TabIndex = 2;
            tabKhachHangNhanVien.Text = "Khách hàng & Nhân viên";
            tabKhachHangNhanVien.UseVisualStyleBackColor = true;
            // 
            // splitKHNV
            // 
            splitKHNV.Dock = DockStyle.Fill;
            splitKHNV.Location = new Point(8, 8);
            splitKHNV.Name = "splitKHNV";
            // 
            // splitKHNV.Panel1
            // 
            splitKHNV.Panel1.Controls.Add(grpKhachHang);
            // 
            // splitKHNV.Panel2
            // 
            splitKHNV.Panel2.Controls.Add(grpNhanVien);
            splitKHNV.Size = new Size(1036, 575);
            splitKHNV.SplitterDistance = 510;
            splitKHNV.TabIndex = 0;
            // 
            // grpKhachHang
            // 
            grpKhachHang.Controls.Add(dgvKhachHang);
            grpKhachHang.Controls.Add(btnDeleteKH);
            grpKhachHang.Controls.Add(btnUpdateKH);
            grpKhachHang.Controls.Add(btnAddKH);
            grpKhachHang.Controls.Add(numDiemKH);
            grpKhachHang.Controls.Add(lblDiemKH);
            grpKhachHang.Controls.Add(txtDTKH);
            grpKhachHang.Controls.Add(lblDTKH);
            grpKhachHang.Controls.Add(txtTenKH);
            grpKhachHang.Controls.Add(lblTenKH);
            grpKhachHang.Dock = DockStyle.Fill;
            grpKhachHang.Location = new Point(0, 0);
            grpKhachHang.Name = "grpKhachHang";
            grpKhachHang.Size = new Size(510, 575);
            grpKhachHang.TabIndex = 0;
            grpKhachHang.TabStop = false;
            grpKhachHang.Text = "Quản lý Khách hàng";
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(15, 32);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(109, 20);
            lblTenKH.TabIndex = 0;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(140, 29);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(210, 27);
            txtTenKH.TabIndex = 1;
            // 
            // lblDTKH
            // 
            lblDTKH.AutoSize = true;
            lblDTKH.Location = new Point(15, 68);
            lblDTKH.Name = "lblDTKH";
            lblDTKH.Size = new Size(80, 20);
            lblDTKH.TabIndex = 2;
            lblDTKH.Text = "Điện thoại:";
            // 
            // txtDTKH
            // 
            txtDTKH.Location = new Point(140, 65);
            txtDTKH.Name = "txtDTKH";
            txtDTKH.Size = new Size(210, 27);
            txtDTKH.TabIndex = 3;
            // 
            // lblDiemKH
            // 
            lblDiemKH.AutoSize = true;
            lblDiemKH.Location = new Point(15, 104);
            lblDiemKH.Name = "lblDiemKH";
            lblDiemKH.Size = new Size(99, 20);
            lblDiemKH.TabIndex = 4;
            lblDiemKH.Text = "Điểm tích lũy:";
            // 
            // numDiemKH
            // 
            numDiemKH.Location = new Point(140, 101);
            numDiemKH.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numDiemKH.Name = "numDiemKH";
            numDiemKH.Size = new Size(120, 27);
            numDiemKH.TabIndex = 5;
            // 
            // btnAddKH
            // 
            btnAddKH.Location = new Point(370, 28);
            btnAddKH.Name = "btnAddKH";
            btnAddKH.Size = new Size(115, 30);
            btnAddKH.TabIndex = 6;
            btnAddKH.Text = "Thêm KH";
            btnAddKH.UseVisualStyleBackColor = true;
            btnAddKH.Click += btnAddKH_Click;
            // 
            // btnUpdateKH
            // 
            btnUpdateKH.Location = new Point(370, 64);
            btnUpdateKH.Name = "btnUpdateKH";
            btnUpdateKH.Size = new Size(115, 30);
            btnUpdateKH.TabIndex = 7;
            btnUpdateKH.Text = "Sửa KH";
            btnUpdateKH.UseVisualStyleBackColor = true;
            btnUpdateKH.Click += btnUpdateKH_Click;
            // 
            // btnDeleteKH
            // 
            btnDeleteKH.Location = new Point(370, 100);
            btnDeleteKH.Name = "btnDeleteKH";
            btnDeleteKH.Size = new Size(115, 30);
            btnDeleteKH.TabIndex = 8;
            btnDeleteKH.Text = "Xóa KH";
            btnDeleteKH.UseVisualStyleBackColor = true;
            btnDeleteKH.Click += btnDeleteKH_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(15, 145);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 35;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(480, 415);
            dgvKhachHang.TabIndex = 9;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // grpNhanVien
            // 
            grpNhanVien.Controls.Add(dgvNhanVien);
            grpNhanVien.Controls.Add(btnDeleteNV);
            grpNhanVien.Controls.Add(btnUpdateNV);
            grpNhanVien.Controls.Add(btnAddNV);
            grpNhanVien.Controls.Add(cboChucVu);
            grpNhanVien.Controls.Add(lblChucVu);
            grpNhanVien.Controls.Add(txtDTNV);
            grpNhanVien.Controls.Add(lblDTNV);
            grpNhanVien.Controls.Add(txtTenNV);
            grpNhanVien.Controls.Add(lblTenNV);
            grpNhanVien.Dock = DockStyle.Fill;
            grpNhanVien.Location = new Point(0, 0);
            grpNhanVien.Name = "grpNhanVien";
            grpNhanVien.Size = new Size(522, 575);
            grpNhanVien.TabIndex = 0;
            grpNhanVien.TabStop = false;
            grpNhanVien.Text = "Quản lý Nhân viên";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(15, 32);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(105, 20);
            lblTenNV.TabIndex = 0;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(135, 29);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(215, 27);
            txtTenNV.TabIndex = 1;
            // 
            // lblDTNV
            // 
            lblDTNV.AutoSize = true;
            lblDTNV.Location = new Point(15, 68);
            lblDTNV.Name = "lblDTNV";
            lblDTNV.Size = new Size(100, 20);
            lblDTNV.TabIndex = 2;
            lblDTNV.Text = "Số điện thoại:";
            // 
            // txtDTNV
            // 
            txtDTNV.Location = new Point(135, 65);
            txtDTNV.Name = "txtDTNV";
            txtDTNV.Size = new Size(215, 27);
            txtDTNV.TabIndex = 3;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(15, 104);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(65, 20);
            lblChucVu.TabIndex = 4;
            lblChucVu.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(135, 101);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(215, 28);
            cboChucVu.TabIndex = 5;
            // 
            // btnAddNV
            // 
            btnAddNV.Location = new Point(370, 28);
            btnAddNV.Name = "btnAddNV";
            btnAddNV.Size = new Size(125, 30);
            btnAddNV.TabIndex = 6;
            btnAddNV.Text = "Thêm NV";
            btnAddNV.UseVisualStyleBackColor = true;
            btnAddNV.Click += btnAddNV_Click;
            // 
            // btnUpdateNV
            // 
            btnUpdateNV.Location = new Point(370, 64);
            btnUpdateNV.Name = "btnUpdateNV";
            btnUpdateNV.Size = new Size(125, 30);
            btnUpdateNV.TabIndex = 7;
            btnUpdateNV.Text = "Sửa NV";
            btnUpdateNV.UseVisualStyleBackColor = true;
            btnUpdateNV.Click += btnUpdateNV_Click;
            // 
            // btnDeleteNV
            // 
            btnDeleteNV.Location = new Point(370, 100);
            btnDeleteNV.Name = "btnDeleteNV";
            btnDeleteNV.Size = new Size(125, 30);
            btnDeleteNV.TabIndex = 8;
            btnDeleteNV.Text = "Xóa NV";
            btnDeleteNV.UseVisualStyleBackColor = true;
            btnDeleteNV.Click += btnDeleteNV_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(15, 145);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 35;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(492, 415);
            dgvNhanVien.TabIndex = 9;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // tabBaoCao
            // 
            tabBaoCao.Controls.Add(grpTop5);
            tabBaoCao.Controls.Add(grpDoanhThu);
            tabBaoCao.Location = new Point(4, 29);
            tabBaoCao.Name = "tabBaoCao";
            tabBaoCao.Padding = new Padding(8);
            tabBaoCao.Size = new Size(1052, 591);
            tabBaoCao.TabIndex = 3;
            tabBaoCao.Text = "Báo cáo - Thống kê";
            tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // grpDoanhThu
            // 
            grpDoanhThu.Controls.Add(btnThongKe);
            grpDoanhThu.Controls.Add(txtDoanhThuThang);
            grpDoanhThu.Controls.Add(lblDoanhThuThang);
            grpDoanhThu.Controls.Add(txtDoanhThuNgay);
            grpDoanhThu.Controls.Add(lblDoanhThuNgay);
            grpDoanhThu.Dock = DockStyle.Top;
            grpDoanhThu.Location = new Point(8, 8);
            grpDoanhThu.Name = "grpDoanhThu";
            grpDoanhThu.Size = new Size(1036, 100);
            grpDoanhThu.TabIndex = 0;
            grpDoanhThu.TabStop = false;
            grpDoanhThu.Text = "Tổng hợp Doanh thu (ExecuteScalar)";
            // 
            // lblDoanhThuNgay
            // 
            lblDoanhThuNgay.AutoSize = true;
            lblDoanhThuNgay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDoanhThuNgay.Location = new Point(25, 42);
            lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            lblDoanhThuNgay.Size = new Size(155, 21);
            lblDoanhThuNgay.TabIndex = 0;
            lblDoanhThuNgay.Text = "Doanh thu hôm nay:";
            // 
            // txtDoanhThuNgay
            // 
            txtDoanhThuNgay.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtDoanhThuNgay.Location = new Point(195, 38);
            txtDoanhThuNgay.Name = "txtDoanhThuNgay";
            txtDoanhThuNgay.ReadOnly = true;
            txtDoanhThuNgay.Size = new Size(200, 29);
            txtDoanhThuNgay.TabIndex = 1;
            txtDoanhThuNgay.Text = "0 VNĐ";
            txtDoanhThuNgay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDoanhThuThang
            // 
            lblDoanhThuThang.AutoSize = true;
            lblDoanhThuThang.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDoanhThuThang.Location = new Point(435, 42);
            lblDoanhThuThang.Name = "lblDoanhThuThang";
            lblDoanhThuThang.Size = new Size(165, 21);
            lblDoanhThuThang.TabIndex = 2;
            lblDoanhThuThang.Text = "Doanh thu tháng này:";
            // 
            // txtDoanhThuThang
            // 
            txtDoanhThuThang.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtDoanhThuThang.Location = new Point(615, 38);
            txtDoanhThuThang.Name = "txtDoanhThuThang";
            txtDoanhThuThang.ReadOnly = true;
            txtDoanhThuThang.Size = new Size(200, 29);
            txtDoanhThuThang.TabIndex = 3;
            txtDoanhThuThang.Text = "0 VNĐ";
            txtDoanhThuThang.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(845, 36);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(160, 34);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Cập nhật thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // grpTop5
            // 
            grpTop5.Controls.Add(dgvTop5);
            grpTop5.Dock = DockStyle.Fill;
            grpTop5.Location = new Point(8, 108);
            grpTop5.Name = "grpTop5";
            grpTop5.Padding = new Padding(8);
            grpTop5.Size = new Size(1036, 475);
            grpTop5.TabIndex = 1;
            grpTop5.TabStop = false;
            grpTop5.Text = "Top 5 Sản phẩm bán chạy nhất (SqlDataReader)";
            // 
            // dgvTop5
            // 
            dgvTop5.AllowUserToAddRows = false;
            dgvTop5.AllowUserToDeleteRows = false;
            dgvTop5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Dock = DockStyle.Fill;
            dgvTop5.Location = new Point(8, 28);
            dgvTop5.MultiSelect = false;
            dgvTop5.Name = "dgvTop5";
            dgvTop5.ReadOnly = true;
            dgvTop5.RowHeadersWidth = 35;
            dgvTop5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop5.Size = new Size(1020, 439);
            dgvTop5.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslStatus, sslClock });
            statusStrip1.Location = new Point(0, 624);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1060, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslStatus
            // 
            sslStatus.Name = "sslStatus";
            sslStatus.Size = new Size(905, 20);
            sslStatus.Spring = true;
            sslStatus.Text = "Sẵn sàng - Kiến trúc 3-Tier (DTO - DAL - BUS - GUI)";
            sslStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sslClock
            // 
            sslClock.Name = "sslClock";
            sslClock.Size = new Size(140, 20);
            sslClock.Text = "Thời gian: 00:00:00";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmSalesMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 650);
            Controls.Add(tabMain);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(960, 580);
            Name = "frmSalesMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 6.1: Hệ thống Quản lý Bán hàng & Siêu thị Mini (3-Tier & SqlTransaction)";
            Load += frmSalesMain_Load;
            tabMain.ResumeLayout(false);
            tabBanHang.ResumeLayout(false);
            grpThongTinHD.ResumeLayout(false);
            grpThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            grpGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            pnlThanhToan.ResumeLayout(false);
            pnlThanhToan.PerformLayout();
            tabSanPham.ResumeLayout(false);
            grpSPInput.ResumeLayout(false);
            grpSPInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTonKho).EndInit();
            grpSPTimKiem.ResumeLayout(false);
            grpSPTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tabKhachHangNhanVien.ResumeLayout(false);
            splitKHNV.Panel1.ResumeLayout(false);
            splitKHNV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitKHNV).EndInit();
            splitKHNV.ResumeLayout(false);
            grpKhachHang.ResumeLayout(false);
            grpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiemKH).EndInit();
            grpNhanVien.ResumeLayout(false);
            grpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tabBaoCao.ResumeLayout(false);
            grpDoanhThu.ResumeLayout(false);
            grpDoanhThu.PerformLayout();
            grpTop5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabBanHang;
        private GroupBox grpThongTinHD;
        private Label lblChonNV;
        private ComboBox cboNhanVien;
        private Label lblChonKH;
        private ComboBox cboKhachHang;
        private Label lblChonSP;
        private ComboBox cboSanPham;
        private Label lblSLBan;
        private NumericUpDown numSoLuongBan;
        private Button btnThemGio;
        private Panel pnlThanhToan;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private Label lblDiemCong;
        private TextBox txtDiemCong;
        private Button btnXoaGio;
        private Button btnHuyDon;
        private Button btnThanhToan;
        private GroupBox grpGioHang;
        private DataGridView dgvGioHang;
        private TabPage tabSanPham;
        private GroupBox grpSPInput;
        private Label lblMaSP;
        private TextBox txtMaSP;
        private Label lblTenSP;
        private TextBox txtTenSP;
        private Label lblGiaBan;
        private TextBox txtGiaBan;
        private Label lblTonKho;
        private NumericUpDown numTonKho;
        private Button btnAddSP;
        private Button btnUpdateSP;
        private Button btnDeleteSP;
        private Button btnClearSP;
        private GroupBox grpSPTimKiem;
        private Label lblSearchSP;
        private TextBox txtSearchSP;
        private Button btnSearchSP;
        private Button btnReloadSP;
        private DataGridView dgvSanPham;
        private TabPage tabKhachHangNhanVien;
        private SplitContainer splitKHNV;
        private GroupBox grpKhachHang;
        private Label lblTenKH;
        private TextBox txtTenKH;
        private Label lblDTKH;
        private TextBox txtDTKH;
        private Label lblDiemKH;
        private NumericUpDown numDiemKH;
        private Button btnAddKH;
        private Button btnUpdateKH;
        private Button btnDeleteKH;
        private DataGridView dgvKhachHang;
        private GroupBox grpNhanVien;
        private Label lblTenNV;
        private TextBox txtTenNV;
        private Label lblDTNV;
        private TextBox txtDTNV;
        private Label lblChucVu;
        private ComboBox cboChucVu;
        private Button btnAddNV;
        private Button btnUpdateNV;
        private Button btnDeleteNV;
        private DataGridView dgvNhanVien;
        private TabPage tabBaoCao;
        private GroupBox grpDoanhThu;
        private Label lblDoanhThuNgay;
        private TextBox txtDoanhThuNgay;
        private Label lblDoanhThuThang;
        private TextBox txtDoanhThuThang;
        private Button btnThongKe;
        private GroupBox grpTop5;
        private DataGridView dgvTop5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslStatus;
        private ToolStripStatusLabel sslClock;
        private System.Windows.Forms.Timer timerClock;
        private ErrorProvider errorProvider1;
    }
}
