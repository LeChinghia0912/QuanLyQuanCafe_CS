namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(223, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 67);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(116, 35);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(242, 27);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbPassWord);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(223, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 77);
            panel2.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(116, 32);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(242, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(162, 31);
            label3.Name = "label3";
            label3.Size = new Size(340, 38);
            label3.TabIndex = 3;
            label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(336, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(478, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 45);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(648, 292);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbPassWord;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}