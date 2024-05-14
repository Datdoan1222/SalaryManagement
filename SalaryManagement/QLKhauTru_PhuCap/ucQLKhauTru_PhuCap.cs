using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using BusinessLogicLayer.Manager;
using SalaryManagement.QLNhanVien_PhongBan;
using DataAccessLayer.Entity;

namespace SalaryManagement.QLKhauTru_PhuCap
{
    public partial class ucQLKhauTru_PhuCap : UserControl
    {
        private NhanVien_PhongBanManager nvpbManager = null;
        private KhauTru_TroCapManager kttcManager = null;
        private DataTable DSNhanVien = null;       
        private DataTable DSKT_TC = null;
        private string error = "";
        private string maNVSelect;
        private string trangthai = "";

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-N2V2U1E2\SQLEXPRESS;Initial Catalog=QLTienLuong;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * KhauTru";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgDanhSachKT_TC.DataSource = table;
        }
        public ucQLKhauTru_PhuCap()
        {
            InitializeComponent();
            nvpbManager = new NhanVien_PhongBanManager();
            kttcManager = new KhauTru_TroCapManager();
            DSNhanVien = null;
            HienThiDSNhanVien();
             trangthai = cbxTrangThai.SelectedItem.ToString();
        }
        private void HienThiDSNhanVien()
        {
            try
            {
                var data = nvpbManager.LayDuLieuDSNV(ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSNhanVien = data;
                    dgDanhSachNhanVien.DataSource = DSNhanVien;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HienThiDSKTTC( string maNVSelect)
        {
            try
            {
                var data = kttcManager.HienThiDSKTTC(maNVSelect,ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSKT_TC = data;
                    dgDanhSachKT_TC.DataSource = DSKT_TC;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pnDanhSachTroCap_Paint(object sender, PaintEventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    

        private void dgDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectRow = dgDanhSachNhanVien.Rows[e.RowIndex];
                maNVSelect= selectRow.Cells["MaNhanVien"].Value.ToString();
                string TenNV= selectRow.Cells["TenNhanVien"].Value.ToString();
                string TenPB = selectRow.Cells["TenPhongBan"].Value.ToString();

                lblTenNV.Text = TenNV;
                lblTenPB.Text = TenPB;

            }
            HienThiDSKTTC(maNVSelect);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            KhauTru_TroCapEntity KT_TCENtity = new KhauTru_TroCapEntity();
           
            if( trangthai == "Trợ Cấp")
            {
                //KT_TCENtity.TenNhanVien = lblTenNV.Text;
                //KT_TCENtity.TenTroCap = txbTen.Text;
                //KT_TCENtity.SoTien = txbSoTien.Text;
            }
            else if (trangthai == "Khấu Trừ")
            {
                KT_TCENtity.TenNhanVien = lblTenNV.Text;
                KT_TCENtity.TenKhauTru = txbTen.Text;
                KT_TCENtity.SoTien = txbSoTien.Text;
                bool ketqua = kttcManager.ThemKhauTru(KT_TCENtity, ref error);
                if (ketqua == true)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Loi: " + error);
                }
            }
            HienThiDSKTTC(maNVSelect);


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = cbxTrangThai.SelectedItem.ToString();
            btnThem.Text = selectValue;
        }
    }

}
    

