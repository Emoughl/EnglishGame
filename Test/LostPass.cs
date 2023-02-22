using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class LostPass : Form
    {
        public LostPass()
        {
            InitializeComponent();
            ketqua.Text = "";
        }
        Modify modify = new Modify();

        private void laylaimatkhau_Click_1(object sender, EventArgs e)
        {
            string email = tbemail.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Hãy nhập email đăng ký");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    ketqua.ForeColor = Color.Blue;
                    ketqua.Text = "Mật Khẩu : " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    ketqua.ForeColor = Color.Red;
                    ketqua.Text = "Email này chưa được đăng ký";
                }
            }
        }
    }
}