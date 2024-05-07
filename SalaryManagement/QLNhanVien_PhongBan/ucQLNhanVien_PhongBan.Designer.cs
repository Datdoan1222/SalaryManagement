
namespace SalaryManagement.QLNhanVien_PhongBan
{
    partial class ucQLNhanVien_PhongBan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnDSNV = new System.Windows.Forms.Panel();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDSPB = new System.Windows.Forms.Panel();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.dgDanhSachPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachNhanVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnDSPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachPhongBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.17071F));
            this.tableLayoutPanel1.Controls.Add(this.pnDSNV, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnDSPB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 729);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnDSNV
            // 
            this.pnDSNV.BackColor = System.Drawing.Color.Gainsboro;
            this.pnDSNV.Controls.Add(this.btnXoaNV);
            this.pnDSNV.Controls.Add(this.btnThemNV);
            this.pnDSNV.Controls.Add(this.lblPhongBan);
            this.pnDSNV.Controls.Add(this.label3);
            this.pnDSNV.Controls.Add(this.dgDanhSachNhanVien);
            this.pnDSNV.Controls.Add(this.panel2);
            this.pnDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDSNV.Location = new System.Drawing.Point(335, 2);
            this.pnDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDSNV.Name = "pnDSNV";
            this.pnDSNV.Size = new System.Drawing.Size(775, 725);
            this.pnDSNV.TabIndex = 2;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.Silver;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaNV.Location = new System.Drawing.Point(336, 176);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(197, 44);
            this.btnXoaNV.TabIndex = 6;
            this.btnXoaNV.Text = "Xóa Nhân Viên";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Silver;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.Black;
            this.btnThemNV.Location = new System.Drawing.Point(39, 176);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(224, 44);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm Nhân Viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhongBan.Location = new System.Drawing.Point(291, 101);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(21, 20);
            this.lblPhongBan.TabIndex = 4;
            this.lblPhongBan.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng Ban";
            // 
            // dgDanhSachNhanVien
            // 
            this.dgDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDanhSachNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.PhongBan,
            this.NgaySinh,
            this.DiaChi});
            this.dgDanhSachNhanVien.Location = new System.Drawing.Point(3, 238);
            this.dgDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDanhSachNhanVien.Name = "dgDanhSachNhanVien";
            this.dgDanhSachNhanVien.RowHeadersWidth = 51;
            this.dgDanhSachNhanVien.RowTemplate.Height = 24;
            this.dgDanhSachNhanVien.Size = new System.Drawing.Size(771, 484);
            this.dgDanhSachNhanVien.TabIndex = 2;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // PhongBan
            // 
            this.PhongBan.DataPropertyName = "PhongBan";
            this.PhongBan.HeaderText = "Chức Vụ";
            this.PhongBan.MinimumWidth = 6;
            this.PhongBan.Name = "PhongBan";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 62);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDSPB
            // 
            this.pnDSPB.BackColor = System.Drawing.Color.Gainsboro;
            this.pnDSPB.Controls.Add(this.btnXoaPB);
            this.pnDSPB.Controls.Add(this.btnThemPB);
            this.pnDSPB.Controls.Add(this.dgDanhSachPhongBan);
            this.pnDSPB.Controls.Add(this.panel1);
            this.pnDSPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDSPB.Location = new System.Drawing.Point(3, 2);
            this.pnDSPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnDSPB.Name = "pnDSPB";
            this.pnDSPB.Size = new System.Drawing.Size(326, 725);
            this.pnDSPB.TabIndex = 1;
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPB.BackColor = System.Drawing.Color.Silver;
            this.btnXoaPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPB.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPB.Location = new System.Drawing.Point(184, 667);
            this.btnXoaPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(101, 44);
            this.btnXoaPB.TabIndex = 3;
            this.btnXoaPB.Text = "Xoa PB";
            this.btnXoaPB.UseVisualStyleBackColor = false;
            this.btnXoaPB.Click += new System.EventHandler(this.btnXoaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemPB.BackColor = System.Drawing.Color.Silver;
            this.btnThemPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPB.ForeColor = System.Drawing.Color.Black;
            this.btnThemPB.Location = new System.Drawing.Point(37, 667);
            this.btnThemPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(101, 44);
            this.btnThemPB.TabIndex = 2;
            this.btnThemPB.Text = "Them PB";
            this.btnThemPB.UseVisualStyleBackColor = false;
            this.btnThemPB.Click += new System.EventHandler(this.btnThemPB_Click);
            // 
            // dgDanhSachPhongBan
            // 
            this.dgDanhSachPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDanhSachPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDanhSachPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDanhSachPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSachPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPhongBan});
            this.dgDanhSachPhongBan.Location = new System.Drawing.Point(3, 87);
            this.dgDanhSachPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDanhSachPhongBan.Name = "dgDanhSachPhongBan";
            this.dgDanhSachPhongBan.RowHeadersWidth = 51;
            this.dgDanhSachPhongBan.RowTemplate.Height = 24;
            this.dgDanhSachPhongBan.Size = new System.Drawing.Size(319, 451);
            this.dgDanhSachPhongBan.TabIndex = 1;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPhongBan";
            this.MaPB.HeaderText = "Mã Phòng Ban";
            this.MaPB.MinimumWidth = 6;
            this.MaPB.Name = "MaPB";
            // 
            // TenPhongBan
            // 
            this.TenPhongBan.DataPropertyName = "TenPhongBan";
            this.TenPhongBan.HeaderText = "Tên Phòng Ban";
            this.TenPhongBan.MinimumWidth = 6;
            this.TenPhongBan.Name = "TenPhongBan";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHÒNG BAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucQLNhanVien_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucQLNhanVien_PhongBan";
            this.Size = new System.Drawing.Size(1119, 735);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnDSNV.ResumeLayout(false);
            this.pnDSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachNhanVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnDSPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSachPhongBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnDSNV;
        private System.Windows.Forms.DataGridView dgDanhSachNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDSPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.DataGridView dgDanhSachPhongBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBan;

    }
}
