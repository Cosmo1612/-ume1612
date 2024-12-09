namespace BTLCNPM2
{
    partial class ThongTinNguoiDung
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
            txtmasv = new TextBox();
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            txtemail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnluu = new Button();
            label6 = new Label();
            txtvaitro = new TextBox();
            SuspendLayout();
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(304, 65);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(197, 27);
            txtmasv.TabIndex = 0;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(304, 122);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(197, 27);
            txttendangnhap.TabIndex = 1;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(304, 186);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(197, 27);
            txtmatkhau.TabIndex = 2;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(304, 280);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(197, 27);
            txtemail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 4;
            label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 68);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 125);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 186);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 283);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // btnluu
            // 
            btnluu.Location = new Point(353, 342);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 9;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 239);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 10;
            label6.Text = "Vai trò";
            // 
            // txtvaitro
            // 
            txtvaitro.Location = new Point(304, 236);
            txtvaitro.Name = "txtvaitro";
            txtvaitro.Size = new Size(197, 27);
            txtvaitro.TabIndex = 11;
            // 
            // ThongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtvaitro);
            Controls.Add(label6);
            Controls.Add(btnluu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            Controls.Add(txtmasv);
            Name = "ThongTinNguoiDung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin tài khoản";
            FormClosed += ThongTinNguoiDung_FormClosed;
            Load += ThongTinNguoiDung_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmasv;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private TextBox txtemail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnluu;
        private Label label6;
        private TextBox txtvaitro;
    }
}