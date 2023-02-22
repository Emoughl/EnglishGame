namespace Test
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dangnhap = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.tbtk = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.tbmmk = new System.Windows.Forms.TextBox();
            this.quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.dangky = new System.Windows.Forms.LinkLabel();
            this.btndangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.AutoSize = true;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dangnhap.ForeColor = System.Drawing.Color.Red;
            this.dangnhap.Location = new System.Drawing.Point(368, 137);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(229, 48);
            this.dangnhap.TabIndex = 11;
            this.dangnhap.Text = "Đăng Nhập";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.ForeColor = System.Drawing.Color.Blue;
            this.user.Location = new System.Drawing.Point(122, 291);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(128, 29);
            this.user.TabIndex = 12;
            this.user.Text = "Tài Khoản";
            // 
            // tbtk
            // 
            this.tbtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbtk.Location = new System.Drawing.Point(313, 281);
            this.tbtk.Multiline = true;
            this.tbtk.Name = "tbtk";
            this.tbtk.Size = new System.Drawing.Size(333, 39);
            this.tbtk.TabIndex = 13;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.Color.Blue;
            this.password.Location = new System.Drawing.Point(129, 389);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 29);
            this.password.TabIndex = 14;
            this.password.Text = "Mật Khẩu";
            // 
            // tbmmk
            // 
            this.tbmmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbmmk.Location = new System.Drawing.Point(313, 379);
            this.tbmmk.Multiline = true;
            this.tbmmk.Name = "tbmmk";
            this.tbmmk.PasswordChar = '*';
            this.tbmmk.Size = new System.Drawing.Size(333, 39);
            this.tbmmk.TabIndex = 15;
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.AutoSize = true;
            this.quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quenmatkhau.Location = new System.Drawing.Point(148, 481);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(196, 29);
            this.quenmatkhau.TabIndex = 16;
            this.quenmatkhau.TabStop = true;
            this.quenmatkhau.Text = "Quên Mật Khẩu ?";
            this.quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quenmatkhau_LinkClicked_1);
            // 
            // dangky
            // 
            this.dangky.AutoSize = true;
            this.dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dangky.Location = new System.Drawing.Point(574, 481);
            this.dangky.Name = "dangky";
            this.dangky.Size = new System.Drawing.Size(103, 29);
            this.dangky.TabIndex = 17;
            this.dangky.TabStop = true;
            this.dangky.Text = "Đăng Ký";
            this.dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangky_LinkClicked_1);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndangnhap.Location = new System.Drawing.Point(340, 562);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(198, 65);
            this.btndangnhap.TabIndex = 18;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 662);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.dangky);
            this.Controls.Add(this.quenmatkhau);
            this.Controls.Add(this.tbmmk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.tbtk);
            this.Controls.Add(this.user);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dangnhap;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox tbtk;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tbmmk;
        private System.Windows.Forms.LinkLabel quenmatkhau;
        private System.Windows.Forms.LinkLabel dangky;
        private System.Windows.Forms.Button btndangnhap;
    }
}