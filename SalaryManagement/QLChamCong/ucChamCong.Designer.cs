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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDatetime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.dgDSChamCong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(54, 103);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(179, 17);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Ngày 1 Tháng 5 Năm 2024";
            // 
            // lblDatetime
            // 
            this.lblDatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatetime.AutoSize = true;
            this.lblDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.Location = new System.Drawing.Point(665, 103);
            this.lblDatetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(44, 17);
            this.lblDatetime.TabIndex = 3;
            this.lblDatetime.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái: ";
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Check In",
            "Check Out",
            "Overtime"});
            this.cbxTrangThai.Location = new System.Drawing.Point(166, 174);
            this.cbxTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(174, 21);
            this.cbxTrangThai.TabIndex = 5;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChamCong.BackColor = System.Drawing.Color.Silver;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(680, 174);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(181, 41);
            this.btnChamCong.TabIndex = 6;
            this.btnChamCong.Text = "CHẤM CÔNG";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
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
            this.TenNhanVien});
            this.dgDSChamCong.Location = new System.Drawing.Point(0, 235);
            this.dgDSChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgDSChamCong.Name = "dgDSChamCong";
            this.dgDSChamCong.RowHeadersWidth = 51;
            this.dgDSChamCong.RowTemplate.Height = 24;
            this.dgDSChamCong.Size = new System.Drawing.Size(891, 277);
            this.dgDSChamCong.TabIndex = 7;
            this.dgDSChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSChamCong_CellClick);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHẤM CÔNG LÀM VIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNhanVien";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên Nhân Viên";
            this.TenNhanVien.MinimumWidth = 6;
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // ucChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSChamCong);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.cbxTrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatetime);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucChamCong";
            this.Size = new System.Drawing.Size(893, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.DataGridView dgDSChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
    }
}
