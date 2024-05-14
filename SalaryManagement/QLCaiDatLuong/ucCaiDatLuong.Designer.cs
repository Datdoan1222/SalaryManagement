
namespace SalaryManagement.QLCaiDatLuong
{
    partial class ucCaiDatLuong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cbxLuongThang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbThongTinTienLuong = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLuongTheoGio = new System.Windows.Forms.ComboBox();
            this.txtTienLuong = new System.Windows.Forms.TextBox();
            this.dgThongTinTienLuong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.grbThongTinTienLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongTinTienLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxLuongThang
            // 
            this.cbxLuongThang.FormattingEnabled = true;
            this.cbxLuongThang.Items.AddRange(new object[] {
            "5.000.000",
            "10.000.000"});
            this.cbxLuongThang.Location = new System.Drawing.Point(710, 108);
            this.cbxLuongThang.Name = "cbxLuongThang";
            this.cbxLuongThang.Size = new System.Drawing.Size(337, 24);
            this.cbxLuongThang.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Lương";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(213, 41);
            this.txtTenNhanVien.Multiline = true;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(218, 33);
            this.txtTenNhanVien.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(359, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(213, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(55, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(327, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 88);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // grbThongTinTienLuong
            // 
            this.grbThongTinTienLuong.Controls.Add(this.groupBox3);
            this.grbThongTinTienLuong.Controls.Add(this.cbxLuongThang);
            this.grbThongTinTienLuong.Controls.Add(this.label5);
            this.grbThongTinTienLuong.Controls.Add(this.txtTenNhanVien);
            this.grbThongTinTienLuong.Controls.Add(this.label2);
            this.grbThongTinTienLuong.Controls.Add(this.label3);
            this.grbThongTinTienLuong.Controls.Add(this.label1);
            this.grbThongTinTienLuong.Controls.Add(this.cbxLuongTheoGio);
            this.grbThongTinTienLuong.Controls.Add(this.txtTienLuong);
            this.grbThongTinTienLuong.Location = new System.Drawing.Point(102, 300);
            this.grbThongTinTienLuong.Name = "grbThongTinTienLuong";
            this.grbThongTinTienLuong.Size = new System.Drawing.Size(1176, 414);
            this.grbThongTinTienLuong.TabIndex = 10;
            this.grbThongTinTienLuong.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng Lương";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lương Cơ Bản";
            // 
            // cbxLuongTheoGio
            // 
            this.cbxLuongTheoGio.FormattingEnabled = true;
            this.cbxLuongTheoGio.Items.AddRange(new object[] {
            "100.000",
            "150.000"});
            this.cbxLuongTheoGio.Location = new System.Drawing.Point(710, 53);
            this.cbxLuongTheoGio.Name = "cbxLuongTheoGio";
            this.cbxLuongTheoGio.Size = new System.Drawing.Size(337, 24);
            this.cbxLuongTheoGio.TabIndex = 3;
            // 
            // txtTienLuong
            // 
            this.txtTienLuong.Location = new System.Drawing.Point(213, 85);
            this.txtTienLuong.Multiline = true;
            this.txtTienLuong.Name = "txtTienLuong";
            this.txtTienLuong.Size = new System.Drawing.Size(218, 33);
            this.txtTienLuong.TabIndex = 4;
            // 
            // dgThongTinTienLuong
            // 
            this.dgThongTinTienLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThongTinTienLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuong,
            this.MaNhanVien,
            this.LuongCoBan,
            this.TongLuong});
            this.dgThongTinTienLuong.Location = new System.Drawing.Point(102, 75);
            this.dgThongTinTienLuong.Name = "dgThongTinTienLuong";
            this.dgThongTinTienLuong.RowHeadersWidth = 51;
            this.dgThongTinTienLuong.RowTemplate.Height = 24;
            this.dgThongTinTienLuong.Size = new System.Drawing.Size(1176, 219);
            this.dgThongTinTienLuong.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "THÔNG TIN TIỀN LƯƠNG";
            // 
            // MaLuong
            // 
            this.MaLuong.HeaderText = "Mã Lương";
            this.MaLuong.MinimumWidth = 6;
            this.MaLuong.Name = "MaLuong";
            this.MaLuong.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // LuongCoBan
            // 
            this.LuongCoBan.HeaderText = "Lương Cơ Bản";
            this.LuongCoBan.MinimumWidth = 6;
            this.LuongCoBan.Name = "LuongCoBan";
            this.LuongCoBan.Width = 125;
            // 
            // TongLuong
            // 
            this.TongLuong.HeaderText = "Tổng Lương";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            this.TongLuong.Width = 125;
            // 
            // ucCaiDatLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbThongTinTienLuong);
            this.Controls.Add(this.dgThongTinTienLuong);
            this.Controls.Add(this.label4);
            this.Name = "ucCaiDatLuong";
            this.Size = new System.Drawing.Size(1326, 717);
            this.groupBox3.ResumeLayout(false);
            this.grbThongTinTienLuong.ResumeLayout(false);
            this.grbThongTinTienLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgThongTinTienLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cbxLuongThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbThongTinTienLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLuongTheoGio;
        private System.Windows.Forms.TextBox txtTienLuong;
        private System.Windows.Forms.DataGridView dgThongTinTienLuong;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}
