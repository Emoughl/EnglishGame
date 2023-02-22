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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            // Subject
        }
        SqlDataAdapter adapter;
        SqlConnection conn;
        DataTable dtTable;
        string conString = @"Data Source=LAPTOP-2S0CP2JK\SQLEXPRESS01;Initial Catalog=EnglishQG;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
        }
        void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = conString;
            conn.Open();
            adapter = new SqlDataAdapter("select * from subjects", conn);
            dtTable = new DataTable();
            adapter.Fill(dtTable);
            this.updateSubjectView(dtTable);
            adapter.Dispose();
            conn.Close();
        }

        void updateSubjectView(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                this.createSubjectButton((int) dr.ItemArray[0], (string) dr.ItemArray[1]);
            }
        }

        void createSubjectButton(int id, string name)
        {
            Button btn = new Button();
            btn.Location = new Point(180 * ((id - 1) % 5), 150 * ((id - 1) / 5));
            btn.Name = "subject_" + id;
            btn.Size = new Size(170, 100);
            btn.TabIndex = id;
            btn.Text = name;
            btn.UseVisualStyleBackColor = true;
            btn.Click += btnClick;
            btn.BackColor = Color.Turquoise;
            this.subject_view.Controls.Add(btn);
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            if (name.StartsWith("subject_"))
            {
                string subject_id = name.Substring(8);
                Play play = new Play(subject_id);
                play.ShowDialog();
                this.Hide();
            }
        }

        private void subject_view_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
