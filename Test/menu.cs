using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test
{
    public partial class menu : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Admin\Desktop\Đồ Án Cơ Sở\Test\Test\audio\Shadow.wav");

        bool music1 = false;
        public menu()
        {
            InitializeComponent();
        }

        private void information_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("- Tên : Hoàng Đăng Huy \n- Lớp : 19DTHA2 \n- Môn Học : Đồ Án Cơ Sở \n- Đề Tài : English Quiz Game \n- Phiên bản: ver 1.0 ", "Thông Tin Về Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thongtin_Click(object sender, EventArgs e)
        {
            Form New_Information = new Information();
            New_Information.Show();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Form New_Game = new Game();
            New_Game.Show();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            Form New_Login = new Login();
            New_Login.Show();
        }

        private void Guide_Click(object sender, EventArgs e)
        {
            Form New_Guide = new Guide();
            New_Guide.Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn Thật Sự Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void music_Click(object sender, EventArgs e)
        {
            if (this.music1 == false)
            {
                player.Play();
                this.music1 = true;

            }
            else
            {
                player.Stop();
                this.music1 = false;
            }
        }

        private void Like_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn Hài Lòng Về Game Chứ ?", "Chuyên Mục Đánh Giá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                MessageBox.Show("Cám ơn bạn rất nhiều !!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                return;
            }
        }

        private void facebook_Click(object sender, EventArgs e)
        {
           Form New_Facebook = new Facebook();
            New_Facebook.Show();
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            Form New_Instagram = new Instagram();
            New_Instagram.Show();
        }

        private void twister_Click(object sender, EventArgs e)
        {
            Form New_Twister = new Twistter();
            New_Twister.Show();
        }

        private void bangxephang_Click(object sender, EventArgs e)
        {
            Form New_HighScore = new Highscore();
            New_HighScore.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form New_Dictionary = new Dictionary();
            New_Dictionary.Show();
        }
    }
}

