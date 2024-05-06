
namespace SalaryManagement.MainForm
{
    partial class frmMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuNhanVien = new System.Windows.Forms.Button();
            this.btnMenuBCTK = new System.Windows.Forms.Button();
            this.btnCaiDatLuong = new System.Windows.Forms.Button();
            this.btnMenuKTvaPC = new System.Windows.Forms.Button();
            this.btnMenuLuongThang = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.LightGray;
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnMenuNhanVien);
            this.pnMenu.Controls.Add(this.btnMenuBCTK);
            this.pnMenu.Controls.Add(this.btnCaiDatLuong);
            this.pnMenu.Controls.Add(this.btnMenuKTvaPC);
            this.pnMenu.Controls.Add(this.btnMenuLuongThang);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenu.Location = new System.Drawing.Point(3, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(174, 588);
            this.pnMenu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Báo Cáo - Thống Kê";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cài Đặt Lương";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhân Viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khấu Trừ - Phụ Cấp";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lương Tháng";
            // 
            // btnMenuNhanVien
            // 
            this.btnMenuNhanVien.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuNhanVien.Image = global::SalaryManagement.Properties.Resources.NhanSu;
            this.btnMenuNhanVien.Location = new System.Drawing.Point(52, 235);
            this.btnMenuNhanVien.Name = "btnMenuNhanVien";
            this.btnMenuNhanVien.Size = new System.Drawing.Size(60, 61);
            this.btnMenuNhanVien.TabIndex = 3;
            this.btnMenuNhanVien.UseVisualStyleBackColor = false;
            this.btnMenuNhanVien.Click += new System.EventHandler(this.btnMenuNhanVien_Click);
            // 
            // btnMenuBCTK
            // 
            this.btnMenuBCTK.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuBCTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuBCTK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuBCTK.Image = global::SalaryManagement.Properties.Resources.ThongKe;
            this.btnMenuBCTK.Location = new System.Drawing.Point(52, 460);
            this.btnMenuBCTK.Name = "btnMenuBCTK";
            this.btnMenuBCTK.Size = new System.Drawing.Size(60, 61);
            this.btnMenuBCTK.TabIndex = 5;
            this.btnMenuBCTK.UseVisualStyleBackColor = false;
            // 
            // btnCaiDatLuong
            // 
            this.btnCaiDatLuong.BackColor = System.Drawing.Color.LightGray;
            this.btnCaiDatLuong.BackgroundImage = global::SalaryManagement.Properties.Resources.CDLuong;
            this.btnCaiDatLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaiDatLuong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaiDatLuong.Location = new System.Drawing.Point(52, 337);
            this.btnCaiDatLuong.Name = "btnCaiDatLuong";
            this.btnCaiDatLuong.Size = new System.Drawing.Size(60, 61);
            this.btnCaiDatLuong.TabIndex = 4;
            this.btnCaiDatLuong.UseVisualStyleBackColor = false;
            // 
            // btnMenuKTvaPC
            // 
            this.btnMenuKTvaPC.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuKTvaPC.BackgroundImage = global::SalaryManagement.Properties.Resources.KhauTruPhuCap;
            this.btnMenuKTvaPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuKTvaPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuKTvaPC.Location = new System.Drawing.Point(52, 117);
            this.btnMenuKTvaPC.Name = "btnMenuKTvaPC";
            this.btnMenuKTvaPC.Size = new System.Drawing.Size(60, 61);
            this.btnMenuKTvaPC.TabIndex = 2;
            this.btnMenuKTvaPC.UseVisualStyleBackColor = false;
            // 
            // btnMenuLuongThang
            // 
            this.btnMenuLuongThang.AutoSize = true;
            this.btnMenuLuongThang.BackColor = System.Drawing.Color.LightGray;
            this.btnMenuLuongThang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuLuongThang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuLuongThang.Image = global::SalaryManagement.Properties.Resources.LuongThang;
            this.btnMenuLuongThang.Location = new System.Drawing.Point(52, 18);
            this.btnMenuLuongThang.Name = "btnMenuLuongThang";
            this.btnMenuLuongThang.Size = new System.Drawing.Size(60, 62);
            this.btnMenuLuongThang.TabIndex = 1;
            this.btnMenuLuongThang.UseVisualStyleBackColor = false;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(183, 3);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(597, 588);
            this.pnMain.TabIndex = 1;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMainForm";
            this.Text = "Quan ly ban hang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTiềnLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngSuấtToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnMenuKTvaPC;
        private System.Windows.Forms.Button btnMenuLuongThang;
        private System.Windows.Forms.Button btnMenuBCTK;
        private System.Windows.Forms.Button btnCaiDatLuong;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnMenuNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}