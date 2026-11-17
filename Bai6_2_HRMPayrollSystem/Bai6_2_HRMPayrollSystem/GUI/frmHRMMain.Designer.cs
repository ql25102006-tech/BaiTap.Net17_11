namespace Bai6_2_HRMPayrollSystem.GUI
{
    partial class frmHRMMain
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
            tabNhanSu = new TabPage();
            dgvNhanVien = new DataGridView();
            grpTimKiemNV = new GroupBox();
            btnReloadNV = new Button();
            btnSearchNV = new Button();
            cboLocPhongBan = new ComboBox();
            lblLocPB = new Label();
            txtSearchNV = new TextBox();
            lblSearchNV = new Label();
            grpNVInput = new GroupBox();
            btnClearNV = new Button();
            btnChuyenPB = new Button();
            btnDeleteNV = new Button();
            btnUpdateNV = new Button();
            btnAddNV = new Button();
            txtHeSoLuong = new TextBox();
            lblHeSo = new Label();
            txtLuongCoBan = new TextBox();
            lblLuongCB = new Label();
            cboPhongBan = new ComboBox();
            lblPhongBan = new Label();
            txtCCCD = new TextBox();
            lblCCCD = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            tabChamCong = new TabPage();
            dgvChamCong = new DataGridView();
            grpChamCongTop = new GroupBox();
            lblGhiChuCC = new Label();
            btnSaveChamCong = new Button();
            btnLoadChamCong = new Button();
            dtpThangChamCong = new DateTimePicker();
            lblThangCC = new Label();
            tabBangLuong = new TabPage();
            dgvBangLuong = new DataGridView();
            grpLuongTop = new GroupBox();
            lblTongQuyLuong = new Label();
            lblCongThuc = new Label();
            btnXemBangLuong = new Button();
            btnChotLuong = new Button();
            dtpThangLuong = new DateTimePicker();
            lblThangLuong = new Label();
            statusStrip1 = new StatusStrip();
            sslStatus = new ToolStripStatusLabel();
            sslClock = new ToolStripStatusLabel();
            timerClock = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            tabMain.SuspendLayout();
            tabNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            grpTimKiemNV.SuspendLayout();
            grpNVInput.SuspendLayout();
            tabChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            grpChamCongTop.SuspendLayout();
            tabBangLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).BeginInit();
            grpLuongTop.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabNhanSu);
            tabMain.Controls.Add(tabChamCong);
            tabMain.Controls.Add(tabBangLuong);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1060, 624);
            tabMain.TabIndex = 0;
            // 
            // tabNhanSu
            // 
            tabNhanSu.Controls.Add(dgvNhanVien);
            tabNhanSu.Controls.Add(grpTimKiemNV);
            tabNhanSu.Controls.Add(grpNVInput);
            tabNhanSu.Location = new Point(4, 29);
            tabNhanSu.Name = "tabNhanSu";
            tabNhanSu.Padding = new Padding(8);
            tabNhanSu.Size = new Size(1052, 591);
            tabNhanSu.TabIndex = 0;
            tabNhanSu.Text = "Quản lý Hồ sơ Nhân sự";
            tabNhanSu.UseVisualStyleBackColor = true;
            // 
            // grpNVInput
            // 
            grpNVInput.Controls.Add(btnClearNV);
            grpNVInput.Controls.Add(btnChuyenPB);
            grpNVInput.Controls.Add(btnDeleteNV);
            grpNVInput.Controls.Add(btnUpdateNV);
            grpNVInput.Controls.Add(btnAddNV);
            grpNVInput.Controls.Add(txtHeSoLuong);
            grpNVInput.Controls.Add(lblHeSo);
            grpNVInput.Controls.Add(txtLuongCoBan);
            grpNVInput.Controls.Add(lblLuongCB);
            grpNVInput.Controls.Add(cboPhongBan);
            grpNVInput.Controls.Add(lblPhongBan);
            grpNVInput.Controls.Add(txtCCCD);
            grpNVInput.Controls.Add(lblCCCD);
            grpNVInput.Controls.Add(dtpNgaySinh);
            grpNVInput.Controls.Add(lblNgaySinh);
            grpNVInput.Controls.Add(txtHoTen);
            grpNVInput.Controls.Add(lblHoTen);
            grpNVInput.Dock = DockStyle.Top;
            grpNVInput.Location = new Point(8, 8);
            grpNVInput.Name = "grpNVInput";
            grpNVInput.Size = new Size(1036, 155);
            grpNVInput.TabIndex = 0;
            grpNVInput.TabStop = false;
            grpNVInput.Text = "Thông tin Hồ sơ Nhân viên";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 32);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(57, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 29);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(210, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(350, 32);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(445, 29);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(160, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new Point(625, 32);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(69, 20);
            lblCCCD.TabIndex = 4;
            lblCCCD.Text = "Số CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(710, 29);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(180, 27);
            txtCCCD.TabIndex = 5;
            // 
            // lblPhongBan
            // 
            lblPhongBan.AutoSize = true;
            lblPhongBan.Location = new Point(20, 72);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(84, 20);
            lblPhongBan.TabIndex = 6;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(120, 69);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(210, 28);
            cboPhongBan.TabIndex = 7;
            // 
            // lblLuongCB
            // 
            lblLuongCB.AutoSize = true;
            lblLuongCB.Location = new Point(350, 72);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(92, 20);
            lblLuongCB.TabIndex = 8;
            lblLuongCB.Text = "Lương cơ bản:";
            // 
            // txtLuongCoBan
            // 
            txtLuongCoBan.Location = new Point(445, 69);
            txtLuongCoBan.Name = "txtLuongCoBan";
            txtLuongCoBan.Size = new Size(160, 27);
            txtLuongCoBan.TabIndex = 9;
            // 
            // lblHeSo
            // 
            lblHeSo.AutoSize = true;
            lblHeSo.Location = new Point(625, 72);
            lblHeSo.Name = "lblHeSo";
            lblHeSo.Size = new Size(85, 20);
            lblHeSo.TabIndex = 10;
            lblHeSo.Text = "Hệ số lương:";
            // 
            // txtHeSoLuong
            // 
            txtHeSoLuong.Location = new Point(710, 69);
            txtHeSoLuong.Name = "txtHeSoLuong";
            txtHeSoLuong.Size = new Size(180, 27);
            txtHeSoLuong.TabIndex = 11;
            txtHeSoLuong.Text = "1.0";
            // 
            // btnAddNV
            // 
            btnAddNV.Location = new Point(120, 110);
            btnAddNV.Name = "btnAddNV";
            btnAddNV.Size = new Size(135, 34);
            btnAddNV.TabIndex = 12;
            btnAddNV.Text = "Thêm nhân viên";
            btnAddNV.UseVisualStyleBackColor = true;
            btnAddNV.Click += btnAddNV_Click;
            // 
            // btnUpdateNV
            // 
            btnUpdateNV.Location = new Point(265, 110);
            btnUpdateNV.Name = "btnUpdateNV";
            btnUpdateNV.Size = new Size(135, 34);
            btnUpdateNV.TabIndex = 13;
            btnUpdateNV.Text = "Cập nhật hồ sơ";
            btnUpdateNV.UseVisualStyleBackColor = true;
            btnUpdateNV.Click += btnUpdateNV_Click;
            // 
            // btnDeleteNV
            // 
            btnDeleteNV.Location = new Point(410, 110);
            btnDeleteNV.Name = "btnDeleteNV";
            btnDeleteNV.Size = new Size(135, 34);
            btnDeleteNV.TabIndex = 14;
            btnDeleteNV.Text = "Xóa nhân viên";
            btnDeleteNV.UseVisualStyleBackColor = true;
            btnDeleteNV.Click += btnDeleteNV_Click;
            // 
            // btnChuyenPB
            // 
            btnChuyenPB.Location = new Point(555, 110);
            btnChuyenPB.Name = "btnChuyenPB";
            btnChuyenPB.Size = new Size(165, 34);
            btnChuyenPB.TabIndex = 15;
            btnChuyenPB.Text = "Chuyển phòng ban";
            btnChuyenPB.UseVisualStyleBackColor = true;
            btnChuyenPB.Click += btnChuyenPB_Click;
            // 
            // btnClearNV
            // 
            btnClearNV.Location = new Point(730, 110);
            btnClearNV.Name = "btnClearNV";
            btnClearNV.Size = new Size(120, 34);
            btnClearNV.TabIndex = 16;
            btnClearNV.Text = "Làm mới";
            btnClearNV.UseVisualStyleBackColor = true;
            btnClearNV.Click += btnClearNV_Click;
            // 
            // grpTimKiemNV
            // 
            grpTimKiemNV.Controls.Add(btnReloadNV);
            grpTimKiemNV.Controls.Add(btnSearchNV);
            grpTimKiemNV.Controls.Add(cboLocPhongBan);
            grpTimKiemNV.Controls.Add(lblLocPB);
            grpTimKiemNV.Controls.Add(txtSearchNV);
            grpTimKiemNV.Controls.Add(lblSearchNV);
            grpTimKiemNV.Dock = DockStyle.Top;
            grpTimKiemNV.Location = new Point(8, 163);
            grpTimKiemNV.Name = "grpTimKiemNV";
            grpTimKiemNV.Size = new Size(1036, 70);
            grpTimKiemNV.TabIndex = 1;
            grpTimKiemNV.TabStop = false;
            grpTimKiemNV.Text = "Tìm kiếm Nhân sự (Parameterized Query)";
            // 
            // lblSearchNV
            // 
            lblSearchNV.AutoSize = true;
            lblSearchNV.Location = new Point(20, 30);
            lblSearchNV.Name = "lblSearchNV";
            lblSearchNV.Size = new Size(138, 20);
            lblSearchNV.TabIndex = 0;
            lblSearchNV.Text = "Từ khóa (Tên / CCCD):";
            // 
            // txtSearchNV
            // 
            txtSearchNV.Location = new Point(165, 27);
            txtSearchNV.Name = "txtSearchNV";
            txtSearchNV.PlaceholderText = "Nhập họ tên hoặc số CCCD...";
            txtSearchNV.Size = new Size(260, 27);
            txtSearchNV.TabIndex = 1;
            // 
            // lblLocPB
            // 
            lblLocPB.AutoSize = true;
            lblLocPB.Location = new Point(445, 30);
            lblLocPB.Name = "lblLocPB";
            lblLocPB.Size = new Size(84, 20);
            lblLocPB.TabIndex = 2;
            lblLocPB.Text = "Phòng ban:";
            // 
            // cboLocPhongBan
            // 
            cboLocPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocPhongBan.FormattingEnabled = true;
            cboLocPhongBan.Location = new Point(535, 27);
            cboLocPhongBan.Name = "cboLocPhongBan";
            cboLocPhongBan.Size = new Size(210, 28);
            cboLocPhongBan.TabIndex = 3;
            // 
            // btnSearchNV
            // 
            btnSearchNV.Location = new Point(760, 25);
            btnSearchNV.Name = "btnSearchNV";
            btnSearchNV.Size = new Size(115, 32);
            btnSearchNV.TabIndex = 4;
            btnSearchNV.Text = "Tìm kiếm";
            btnSearchNV.UseVisualStyleBackColor = true;
            btnSearchNV.Click += btnSearchNV_Click;
            // 
            // btnReloadNV
            // 
            btnReloadNV.Location = new Point(885, 25);
            btnReloadNV.Name = "btnReloadNV";
            btnReloadNV.Size = new Size(115, 32);
            btnReloadNV.TabIndex = 5;
            btnReloadNV.Text = "Tải lại";
            btnReloadNV.UseVisualStyleBackColor = true;
            btnReloadNV.Click += btnReloadNV_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(8, 233);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 35;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1036, 350);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            // 
            // tabChamCong
            // 
            tabChamCong.Controls.Add(dgvChamCong);
            tabChamCong.Controls.Add(grpChamCongTop);
            tabChamCong.Location = new Point(4, 29);
            tabChamCong.Name = "tabChamCong";
            tabChamCong.Padding = new Padding(8);
            tabChamCong.Size = new Size(1052, 591);
            tabChamCong.TabIndex = 1;
            tabChamCong.Text = "Chấm công (Disconnected Model)";
            tabChamCong.UseVisualStyleBackColor = true;
            // 
            // grpChamCongTop
            // 
            grpChamCongTop.Controls.Add(lblGhiChuCC);
            grpChamCongTop.Controls.Add(btnSaveChamCong);
            grpChamCongTop.Controls.Add(btnLoadChamCong);
            grpChamCongTop.Controls.Add(dtpThangChamCong);
            grpChamCongTop.Controls.Add(lblThangCC);
            grpChamCongTop.Dock = DockStyle.Top;
            grpChamCongTop.Location = new Point(8, 8);
            grpChamCongTop.Name = "grpChamCongTop";
            grpChamCongTop.Size = new Size(1036, 95);
            grpChamCongTop.TabIndex = 0;
            grpChamCongTop.TabStop = false;
            grpChamCongTop.Text = "Chấm công ngắt kết nối (SqlDataAdapter & SqlCommandBuilder)";
            // 
            // lblThangCC
            // 
            lblThangCC.AutoSize = true;
            lblThangCC.Location = new Point(20, 32);
            lblThangCC.Name = "lblThangCC";
            lblThangCC.Size = new Size(115, 20);
            lblThangCC.TabIndex = 0;
            lblThangCC.Text = "Chọn Tháng/Năm:";
            // 
            // dtpThangChamCong
            // 
            dtpThangChamCong.CustomFormat = "MM/yyyy";
            dtpThangChamCong.Format = DateTimePickerFormat.Custom;
            dtpThangChamCong.Location = new Point(145, 29);
            dtpThangChamCong.Name = "dtpThangChamCong";
            dtpThangChamCong.ShowUpDown = true;
            dtpThangChamCong.Size = new Size(120, 27);
            dtpThangChamCong.TabIndex = 1;
            // 
            // btnLoadChamCong
            // 
            btnLoadChamCong.Location = new Point(285, 26);
            btnLoadChamCong.Name = "btnLoadChamCong";
            btnLoadChamCong.Size = new Size(230, 34);
            btnLoadChamCong.TabIndex = 2;
            btnLoadChamCong.Text = "Nạp bảng chấm công (Adapter)";
            btnLoadChamCong.UseVisualStyleBackColor = true;
            btnLoadChamCong.Click += btnLoadChamCong_Click;
            // 
            // btnSaveChamCong
            // 
            btnSaveChamCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveChamCong.Location = new Point(535, 26);
            btnSaveChamCong.Name = "btnSaveChamCong";
            btnSaveChamCong.Size = new Size(250, 34);
            btnSaveChamCong.TabIndex = 3;
            btnSaveChamCong.Text = "Lưu chấm công (adapter.Update)";
            btnSaveChamCong.UseVisualStyleBackColor = true;
            btnSaveChamCong.Click += btnSaveChamCong_Click;
            // 
            // lblGhiChuCC
            // 
            lblGhiChuCC.AutoSize = true;
            lblGhiChuCC.Location = new Point(20, 67);
            lblGhiChuCC.Name = "lblGhiChuCC";
            lblGhiChuCC.Size = new Size(560, 20);
            lblGhiChuCC.TabIndex = 4;
            lblGhiChuCC.Text = "Hướng dẫn: Nhập trực tiếp Số ngày công (0-31) và Số giờ OT trên lưới rồi nhấn 'Lưu chấm công'.";
            // 
            // dgvChamCong
            // 
            dgvChamCong.AllowUserToAddRows = false;
            dgvChamCong.AllowUserToDeleteRows = false;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Dock = DockStyle.Fill;
            dgvChamCong.Location = new Point(8, 103);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 35;
            dgvChamCong.Size = new Size(1036, 480);
            dgvChamCong.TabIndex = 1;
            // 
            // tabBangLuong
            // 
            tabBangLuong.Controls.Add(dgvBangLuong);
            tabBangLuong.Controls.Add(grpLuongTop);
            tabBangLuong.Location = new Point(4, 29);
            tabBangLuong.Name = "tabBangLuong";
            tabBangLuong.Padding = new Padding(8);
            tabBangLuong.Size = new Size(1052, 591);
            tabBangLuong.TabIndex = 2;
            tabBangLuong.Text = "Tính Lương & Chốt Lương (SqlTransaction)";
            tabBangLuong.UseVisualStyleBackColor = true;
            // 
            // grpLuongTop
            // 
            grpLuongTop.Controls.Add(lblTongQuyLuong);
            grpLuongTop.Controls.Add(lblCongThuc);
            grpLuongTop.Controls.Add(btnXemBangLuong);
            grpLuongTop.Controls.Add(btnChotLuong);
            grpLuongTop.Controls.Add(dtpThangLuong);
            grpLuongTop.Controls.Add(lblThangLuong);
            grpLuongTop.Dock = DockStyle.Top;
            grpLuongTop.Location = new Point(8, 8);
            grpLuongTop.Name = "grpLuongTop";
            grpLuongTop.Size = new Size(1036, 100);
            grpLuongTop.TabIndex = 0;
            grpLuongTop.TabStop = false;
            grpLuongTop.Text = "Tính lương & Chốt bảng lương hàng tháng";
            // 
            // lblThangLuong
            // 
            lblThangLuong.AutoSize = true;
            lblThangLuong.Location = new Point(20, 32);
            lblThangLuong.Name = "lblThangLuong";
            lblThangLuong.Size = new Size(115, 20);
            lblThangLuong.TabIndex = 0;
            lblThangLuong.Text = "Chọn Tháng/Năm:";
            // 
            // dtpThangLuong
            // 
            dtpThangLuong.CustomFormat = "MM/yyyy";
            dtpThangLuong.Format = DateTimePickerFormat.Custom;
            dtpThangLuong.Location = new Point(145, 29);
            dtpThangLuong.Name = "dtpThangLuong";
            dtpThangLuong.ShowUpDown = true;
            dtpThangLuong.Size = new Size(120, 27);
            dtpThangLuong.TabIndex = 1;
            // 
            // btnChotLuong
            // 
            btnChotLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChotLuong.Location = new Point(285, 26);
            btnChotLuong.Name = "btnChotLuong";
            btnChotLuong.Size = new Size(245, 34);
            btnChotLuong.TabIndex = 2;
            btnChotLuong.Text = "Chốt lương tháng (SqlTransaction)";
            btnChotLuong.UseVisualStyleBackColor = true;
            btnChotLuong.Click += btnChotLuong_Click;
            // 
            // btnXemBangLuong
            // 
            btnXemBangLuong.Location = new Point(545, 26);
            btnXemBangLuong.Name = "btnXemBangLuong";
            btnXemBangLuong.Size = new Size(185, 34);
            btnXemBangLuong.TabIndex = 3;
            btnXemBangLuong.Text = "Xem bảng lương tháng";
            btnXemBangLuong.UseVisualStyleBackColor = true;
            btnXemBangLuong.Click += btnXemBangLuong_Click;
            // 
            // lblCongThuc
            // 
            lblCongThuc.AutoSize = true;
            lblCongThuc.Location = new Point(20, 70);
            lblCongThuc.Name = "lblCongThuc";
            lblCongThuc.Size = new Size(515, 20);
            lblCongThuc.TabIndex = 4;
            lblCongThuc.Text = "Công thức: Thực lĩnh = (Lương cơ bản × Hệ số / 22) × Số ngày công + (Số giờ OT × 50,000 VNĐ)";
            // 
            // lblTongQuyLuong
            // 
            lblTongQuyLuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongQuyLuong.AutoSize = true;
            lblTongQuyLuong.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTongQuyLuong.Location = new Point(745, 32);
            lblTongQuyLuong.Name = "lblTongQuyLuong";
            lblTongQuyLuong.Size = new Size(210, 21);
            lblTongQuyLuong.TabIndex = 5;
            lblTongQuyLuong.Text = "Tổng quỹ lương: 0 VNĐ";
            // 
            // dgvBangLuong
            // 
            dgvBangLuong.AllowUserToAddRows = false;
            dgvBangLuong.AllowUserToDeleteRows = false;
            dgvBangLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangLuong.Dock = DockStyle.Fill;
            dgvBangLuong.Location = new Point(8, 108);
            dgvBangLuong.MultiSelect = false;
            dgvBangLuong.Name = "dgvBangLuong";
            dgvBangLuong.ReadOnly = true;
            dgvBangLuong.RowHeadersWidth = 35;
            dgvBangLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBangLuong.Size = new Size(1036, 475);
            dgvBangLuong.TabIndex = 1;
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
            sslStatus.Text = "Sẵn sàng - Kiến trúc 3-Tier & Disconnected Model";
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
            // frmHRMMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 650);
            Controls.Add(tabMain);
            Controls.Add(statusStrip1);
            MinimumSize = new Size(980, 580);
            Name = "frmHRMMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 6.2: Hệ thống Quản lý Nhân sự & Tính lương (HRM & Payroll System)";
            Load += frmHRMMain_Load;
            tabMain.ResumeLayout(false);
            tabNhanSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            grpTimKiemNV.ResumeLayout(false);
            grpTimKiemNV.PerformLayout();
            grpNVInput.ResumeLayout(false);
            grpNVInput.PerformLayout();
            tabChamCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            grpChamCongTop.ResumeLayout(false);
            grpChamCongTop.PerformLayout();
            tabBangLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBangLuong).EndInit();
            grpLuongTop.ResumeLayout(false);
            grpLuongTop.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabNhanSu;
        private GroupBox grpNVInput;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblPhongBan;
        private ComboBox cboPhongBan;
        private Label lblLuongCB;
        private TextBox txtLuongCoBan;
        private Label lblHeSo;
        private TextBox txtHeSoLuong;
        private Button btnAddNV;
        private Button btnUpdateNV;
        private Button btnDeleteNV;
        private Button btnChuyenPB;
        private Button btnClearNV;
        private GroupBox grpTimKiemNV;
        private Label lblSearchNV;
        private TextBox txtSearchNV;
        private Label lblLocPB;
        private ComboBox cboLocPhongBan;
        private Button btnSearchNV;
        private Button btnReloadNV;
        private DataGridView dgvNhanVien;
        private TabPage tabChamCong;
        private GroupBox grpChamCongTop;
        private Label lblThangCC;
        private DateTimePicker dtpThangChamCong;
        private Button btnLoadChamCong;
        private Button btnSaveChamCong;
        private Label lblGhiChuCC;
        private DataGridView dgvChamCong;
        private TabPage tabBangLuong;
        private GroupBox grpLuongTop;
        private Label lblThangLuong;
        private DateTimePicker dtpThangLuong;
        private Button btnChotLuong;
        private Button btnXemBangLuong;
        private Label lblCongThuc;
        private Label lblTongQuyLuong;
        private DataGridView dgvBangLuong;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslStatus;
        private ToolStripStatusLabel sslClock;
        private System.Windows.Forms.Timer timerClock;
        private ErrorProvider errorProvider1;
    }
}
