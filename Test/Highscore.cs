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
using System.Data.OleDb;

namespace Test
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter;
        SqlConnection conn;
        DataTable dtTable;
        string conString = @"Data Source=LAPTOP-2S0CP2JK\SQLEXPRESS01;Initial Catalog=EnglishQG;Integrated Security=True";

        private void Highscore_Load (object sender, EventArgs e)
        {
            Connect();
        }
        void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = conString;
            conn.Open();
            adapter = new SqlDataAdapter("SELECT TaiKhoan.TenTaiKhoan,HighScore from TaiKhoan Order By HighScore DESC", conn);
            dtTable = new DataTable();
            adapter.Fill(dtTable);
            dataGridView1.DataSource = dtTable;
            adapter.Dispose();
            conn.Close();
        }
    }
}
