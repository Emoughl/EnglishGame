using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Test
{
    public partial class Play : Form
    {
        string subject_id;
        string question; 
        string answer;
        bool beenwrong = false;
        ArrayList questions;
        int question_index = 0;
        int lives = 3;
        int points = 0;
        public Play(string subject_id)
        {
            this.subject_id = subject_id;
            InitializeComponent();
            Connect();
            this.showQuestion();
            this.labelP.Text = "Points: " + points;
        }
            SqlDataAdapter adapter;
            SqlConnection conn;
            DataTable dtTable;
            string conString = @"Data Source=LAPTOP-2S0CP2JK\SQLEXPRESS01;Initial Catalog=EnglishQG;Integrated Security=True";
        
        void Connect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = conString;
            conn.Open();
            adapter = new SqlDataAdapter("select * from questions where subject_id=" + this.subject_id, conn);
            dtTable = new DataTable();
            adapter.Fill(dtTable);
            this.updateQuestionView(dtTable);
            adapter.Dispose();
            conn.Close();
        }

        void updateQuestionView(DataTable dt)
        {
            ArrayList questions = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                questions.Add((int)dr.ItemArray[0]);
            }
            this.questions = questions;
        }
        void DictionaryAdd(){
string fileName = @"C:\Users\Admin\Desktop\Đồ Án Cơ Sở\Test\Test\Data\Vocabulary.txt";
using (FileStream fs = new FileStream(fileName,FileMode.Append, FileAccess.Write))
 using (StreamWriter sw = new StreamWriter(fs))
 {
    sw.WriteLine(question+":"+answer);
 }
        }

        void showQuestion()
        {
            beenwrong = false;
            int question_id = 0;
            try
            {
                question_id = (int)this.questions[this.question_index];
                double round = Math.Ceiling(question_index / 10.0);
                int remain = question_index % 10;
                if (remain == 0 & round != 0)
                {
                    MessageBox.Show("Chúc mừng bạn đã hoàn thành vòng: " + (round));
                }
            }
            catch (Exception ex)
            {
                Modify modify = new Modify();

                int oldpoints = modify.Getint("SELECT HighScore FROM  Taikhoan WHERE TenTaikhoan = '" + Login.tentk + "'");
                this.Hide();
                MessageBox.Show("Bạn đã hoàn thành chủ đề này rồi , điểm của bạn :  " + Environment.NewLine + "\n - Điểm : " + points + "\n - Người Dùng :" + Login.tentk + "\n - Điểm Cũ : " + oldpoints);

                if (oldpoints < points)
                {
                    string query = "UPDATE TaiKhoan SET  HighScore = '" + points + "' WHERE TenTaikhoan = '" + Login.tentk + "'";
                    modify.Command(query);
                }
            }

            conn = new SqlConnection();
            conn.ConnectionString = conString;
            conn.Open();
            try
            {
                adapter = new SqlDataAdapter("select * from questions where id =" + question_id, conn);
                dtTable = new DataTable();
                adapter.Fill(dtTable);

                this.labelQ.Text = dtTable.Rows[0].ItemArray[2].ToString();
                question=dtTable.Rows[0].ItemArray[2].ToString();
                adapter.Dispose();
                conn.Close();
            }
            catch (Exception ex) { }
            this.labelP.Text = "Points: " + points;
            showAnswers();
            }


        void showAnswers()
        {
            try
            {
                int question_id = (int)this.questions[this.question_index];
                conn = new SqlConnection();
                conn.ConnectionString = conString;
                conn.Open();
                //Modify modify = new Modify();
                //int question_count = modify.Getint("SELECT COUNT(id) FROM questions WHERE subject_id = " + this.subject_id);
                //Random rnd = new Random();
                //int question_id = rnd.Next(question_count);
                adapter = new SqlDataAdapter("select * from answers where question_id=" + question_id, conn);
                dtTable = new DataTable();
                adapter.Fill(dtTable);
            
                this.labelA.Text = dtTable.Rows[0].ItemArray[2].ToString();
                this.labelB.Text = dtTable.Rows[1].ItemArray[2].ToString();
                this.labelC.Text = dtTable.Rows[2].ItemArray[2].ToString();
                this.labelD.Text = dtTable.Rows[3].ItemArray[2].ToString();
                this.labelP.Text = "Points: " + points;
                adapter.Dispose();
                conn.Close();
            }catch (Exception ex) { }
            }
        private void Game_Over(object sender, EventArgs e)
        {
            MessageBox.Show("- Bạn đã thua rồi ,hãy thử lại xem !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
public void wait(int milliseconds)
{
    var timer1 = new System.Windows.Forms.Timer();
    if (milliseconds == 0 || milliseconds < 0) return;

    // Console.WriteLine("start wait timer");
    timer1.Interval = milliseconds;
    timer1.Enabled  = true;
    timer1.Start();

    timer1.Tick += (s, e) =>
    {
        timer1.Enabled = false;
        timer1.Stop();
        // Console.WriteLine("stop wait timer");
    };

    while (timer1.Enabled)
    {
        Application.DoEvents();
    }
}
        private void lives_Check()
        {
            if (lives == 3)
            {

            }
            else if
              (lives == 2)
            {
                pictureBox2.Visible = false;
            }
            else if
              (lives == 1)
            {
                pictureBox3.Visible = false;
            }

        }

        private void checkAnswer(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            int index = 0;
            switch (lb.Name)
            {
                case "labelA":
                    index = 0;

                    break;
                case "labelB":
                    index = 1;

                    break;
                case "labelC":
                    index = 2;

                    break;
                case "labelD":
                    index = 3;

                    break;

            }

            int question_id = (int)this.questions[this.question_index];
            conn = new SqlConnection();
            conn.ConnectionString = conString;
            conn.Open();
            adapter = new SqlDataAdapter("select * from answers where question_id=" + question_id, conn);
            dtTable = new DataTable();
            adapter.Fill(dtTable);
            byte is_correct = (byte)dtTable.Rows[index].ItemArray[3];
          for (int i=0;i<4;i++){
                  byte is_correct1 = (byte)dtTable.Rows[i].ItemArray[3];
                if(is_correct1==1){
                   switch (i)
                {
                    case 0:
                       answer=labelA.Text;
                        break;
                    case 1:
                       answer=labelB.Text;
                        break;
                    case 2:
                       answer=labelC.Text;
                        break;
                    case 3:
                       answer=labelD.Text;
                        break;

                }
                }

            }
                if (is_correct == 1)
                {
                    switch (index)
                    {
                        case 0:
                            this.labelA.BackColor = Color.GreenYellow;
                            if (beenwrong == true) {
                                answer = this.labelA.Text;

                            }
                            break;
                        case 1:
                            this.labelB.BackColor = Color.GreenYellow;
                            if (beenwrong == true) {
                                answer = this.labelB.Text;

                            }
                            break;
                        case 2:
                            this.labelC.BackColor = Color.GreenYellow;
                            if (beenwrong == true) {
                                answer = this.labelC.Text;

                            }
                            break;
                        case 3:
                            this.labelD.BackColor = Color.GreenYellow;
                            if (beenwrong == true) {
                                answer = this.labelD.Text;

                            }
                            break;

                    }
                    wait(500);
                    this.labelA.BackColor = Color.White;
                    this.labelB.BackColor = Color.White;
                    this.labelC.BackColor = Color.White;
                    this.labelD.BackColor = Color.White;
                    this.question_index++;
                    if (beenwrong == true) {
                        DictionaryAdd();
                    }
                    this.showQuestion();
                    points++;
                    this.labelP.Text = "Points: " + points;
                }
                else
                {
                    switch (index)
                    {
                        case 0:
                            this.labelA.BackColor = Color.Red;

                            break;
                        case 1:
                            this.labelB.BackColor = Color.Red;

                            break;
                        case 2:
                            this.labelC.BackColor = Color.Red;

                            break;
                        case 3:
                            this.labelD.BackColor = Color.Red;

                            break;

                    }
                    beenwrong = true;
                    wait(500);
                    this.labelA.BackColor = Color.White;
                    this.labelB.BackColor = Color.White;
                    this.labelC.BackColor = Color.White;
                    this.labelD.BackColor = Color.White;

                    lives = lives - 1;
                    lives_Check();


                }
                if (lives == 0)
                {
                    DictionaryAdd();
                    Modify modify = new Modify();
                    int oldpoints = modify.Getint("SELECT HighScore FROM  Taikhoan WHERE TenTaikhoan = '" + Login.tentk + "'");
                    this.Hide();
                    MessageBox.Show("Bạn đã thua rồi" + Environment.NewLine +  "\n - Người Dùng : " + Login.tentk + "\n - Điểm : " + points + "\n -Điểm Cũ : " + oldpoints);
                    this.Hide();
                    if (oldpoints < points)
                    {
                        string query = "UPDATE TaiKhoan SET  HighScore = '" + points + "' WHERE TenTaikhoan = '" + Login.tentk + "'";
                        modify.Command(query);
                    }

                    Form Game = new Game();
                    Game.ShowDialog();
                }
            }
        }
        }
    