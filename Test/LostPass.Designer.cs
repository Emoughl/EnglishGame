namespace Test
{
    partial class LostPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostPass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emaildangky = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.Label();
            this.laylaimatkhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // emaildangky
            // 
            this.emaildangky.AutoSize = true;
            this.emaildangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emaildangky.Location = new System.Drawing.Point(48, 269);
            this.emaildangky.Name = "emaildangky";
            this.emaildangky.Size = new System.Drawing.Size(182, 29);
            this.emaildangky.TabIndex = 13;
            this.emaildangky.Text = "Email Đăng Ký";
            // 
            // tbemail
            // 
            this.tbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbemail.Location = new System.Drawing.Point(259, 266);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(301, 38);
            this.tbemail.TabIndex = 15;
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ketqua.Location = new System.Drawing.Point(107, 362);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(105, 29);
            this.ketqua.TabIndex = 16;
            this.ketqua.Text = "Kết Quả";
            // 
            // laylaimatkhau
            // 
            this.laylaimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.laylaimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laylaimatkhau.Location = new System.Drawing.Point(259, 423);
            this.laylaimatkhau.Name = "laylaimatkhau";
            this.laylaimatkhau.Size = new System.Drawing.Size(185, 70);
            this.laylaimatkhau.TabIndex = 17;
            this.laylaimatkhau.Text = "Lấy Lại Mật Khẩu";
            this.laylaimatkhau.UseVisualStyleBackColor = false;
            this.laylaimatkhau.Click += new System.EventHandler(this.laylaimatkhau_Click_1);
            // 
            // LostPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 597);
            this.Controls.Add(this.laylaimatkhau);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.emaildangky);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LostPass";
            this.Text = "LostPass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label emaildangky;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Button laylaimatkhau;
    }
}