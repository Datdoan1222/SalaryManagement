﻿
namespace SalaryManagement.QLChamCong
{
    partial class ucChamCong
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgDSChamCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày 1 Tháng 5 Năm 2024";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(887, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đăng Xuất",
            "Đăng Nhập",
            "Tăng Ca"});
            this.comboBox1.Location = new System.Drawing.Point(221, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(907, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "CHẤM CÔNG";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgDSChamCong
            // 
            this.dgDSChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDSChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNhanVien,
            this.TrangThai,
            this.ThoiGian});
            this.dgDSChamCong.Location = new System.Drawing.Point(0, 289);
            this.dgDSChamCong.Name = "dgDSChamCong";
            this.dgDSChamCong.RowHeadersWidth = 51;
            this.dgDSChamCong.RowTemplate.Height = 24;
            this.dgDSChamCong.Size = new System.Drawing.Size(1188, 341);
            this.dgDSChamCong.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1406, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHẤM CÔNG LÀM VIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "HoTen";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời Gian";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            // 
            // ucChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSChamCong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "ucChamCong";
            this.Size = new System.Drawing.Size(1191, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgDSChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.Label label1;
    }
}
