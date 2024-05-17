using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
namespace SalaryManagement.QLQuyTrinhDuyetLuong
{
    public partial class ucQTDLuongThang : UserControl
    {
        private DateTime now = DateTime.Now;
        private TinhLuongManager manager = null;
        private TinhLuongEntity Entity = null;
        private DataTable DSLuong = null;
        private string error = "";
        private string manhanvien = "";
        private string connectionString = "Data Source=.;Initial Catalog=QLTL;Integrated Security=True";

        public ucQTDLuongThang()
        {
            InitializeComponent();
            manager = new TinhLuongManager();
            Entity = new TinhLuongEntity();
            DuLieu();
            LayDuLieuDSLuong( );
        }

        private void DuLieu()
        {
            string month = now.Month.ToString();
            string year = now.Year.ToString();
            cbxThang.Text = "Tháng " + month;
            cbxNam.Text = "Năm " + year;
            
            // Tên Nhân viên:
            cbxNhanVien.Text = ClsCHHeThong.TenDayDu;
            // Phong Ban:
            lblPhongBan.Text = ClsCHHeThong.PhongBan;
            lblChucVu.Text = ClsCHHeThong.ChucVu;
            string[] parts = cbxThang.Text.Split(' ');
            string thangString = parts[1];
            int thang = Convert.ToInt32(thangString);
            int manv = Convert.ToInt32(ClsCHHeThong.ID);
            // entity
            Entity.Thang = thang;
            Entity.MaNhanVien = manv;
            Entity.TenChucVu = ClsCHHeThong.ChucVu;
            Entity.TenPhongBan = ClsCHHeThong.PhongBan;
            Console.WriteLine(Entity.MaNhanVien);


        }
        private void LayDuLieuDSLuong()
        {
            try
            {
                var data = manager.LayDuLieuDSLuong(Entity, ref error);
                if (data == null)
                {
                    MessageBox.Show(error);
                }
                else
                {
                    DSLuong = data;
                    dgDuyetLuong.DataSource = DSLuong;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            bool ketqua = manager.TinhLuong(Entity, ref error);
            bool ktraLuongNV = manager.ktraLuongNV(Entity, ref error);
            bool ktraLuongThangNV = manager.ktraLuongThangNV(Entity, ref error);

            if (ktraLuongNV && ktraLuongThangNV)
            {
                MessageBox.Show("Bạn đã " + lblTongLuong.Text);
            }
            else if (ktraLuongThangNV)
            {
                MessageBox.Show("Bạn đã " + lblTongLuong.Text + " tháng này rồi");
            }

            if (ketqua && !ktraLuongNV && !ktraLuongThangNV)
            {
                MessageBox.Show(lblTongLuong.Text + " thành công");
            }

            LayDuLieuDSLuong();
        }

    }
}
