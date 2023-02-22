using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ca)//check mật khẩu,tài khoản
        {
            //điều kiện đặt tk,mk a-z,A-Z,0-9,8-24 ký tự
            return Regex.IsMatch(ca, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[\w]{3,20}@gmail.com(.vn|)$");

        }
        Modify modify = new Modify();
        private void dangky_Click_1(object sender, EventArgs e)
        {
            string tentk = tbtk.Text;
            string matkhau = tbmk.Text;
            string xacnhanmatkhau = tbxnmk.Text;
            string email = tbemail.Text;
            if (!checkAccount(tentk))
            {
                MessageBox.Show("Hãy nhập tên tài khoản dài từ 6-24 ký tự, chỉ chữ hoa và chữ thường, số "); return;
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("Hãy nhập mật khẩu dài từ 6-24 ký tự, chỉ chữ hoa và chữ thường, số "); return;
            }
            if (xacnhanmatkhau != matkhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng , vui lòng nhập lại"); return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Hãy nhập đúng định dạng email"); return;
            }
            //Kiểm tra mỗi người dùng chỉ được tạo 1 email
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email đã được sử dụng, hãy dùng email khác"); return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "','" + 0 + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, hãy thử lại");
            }
        }
       
    }
}