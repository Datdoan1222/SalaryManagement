using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalaryManagement.QLCaiDatLuong
{
    public partial class ucCaiDatLuong : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-N2V2U1E2\SQLEXPRESS;Initial Catalog=QLTienLuong;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * Luong ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgThongTinTienLuong.DataSource = table;
        }
        public ucCaiDatLuong()
        {
            InitializeComponent();
        }

        private void dgThongTinTienLuong_Paint(object sender, PaintEventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    }
}
