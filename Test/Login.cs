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
    public partial class Login : Form
    {
        static public string tentk;
        public Login()
        {
            InitializeComponent();
        }
        private void quenmatkhau_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LostPass lostPass = new LostPass();
            lostPass.ShowDialog();
        }
        private void dangky_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
        Modify modify = new Modify();

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            tentk = tbtk.Text;
            DialogResult h = MessageBox.Show("Bạn Đang Đăng Nhập Vào Tài Khoản  : " + tentk + "\n Bạn Xác Nhận Tiếp Tục Chứ ?", "Thông Tin Đăng Nhập : " + tentk + ".", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if ( h == DialogResult.No)
            { 
                return;
            }
            string matkhau = tbmmk.Text;
            //Kiểm tra người dùng ấn dấu cách
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Hãy nhập tên tài khoản");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Hãy nhập mật khẩu");
            }
            else
            {
                string query = "Select *from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Game game = new Game();
                    game.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại , Vui Lòng Thử Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

