namespace BTLCNPM2
{
    partial class TrangChu2
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
            panel1 = new Panel();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 73);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(161, 15);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 2;
            button3.Text = "Quản lý học viên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(638, 15);
            button5.Name = "button5";
            button5.Size = new Size(135, 43);
            button5.TabIndex = 1;
            button5.Text = "Đăng xuất";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(479, 15);
            button4.Name = "button4";
            button4.Size = new Size(135, 43);
            button4.TabIndex = 1;
            button4.Text = "Báo cáo thu chi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(319, 15);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 1;
            button2.Text = "Quản lý học phí";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 15);
            button1.Name = "button1";
            button1.Size = new Size(135, 43);
            button1.TabIndex = 0;
            button1.Text = "Quản lý tài khoản";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Trang chủ quản lý";
            // 
            // TrangChu2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TrangChu2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chu admin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Label label1;
        private Button button3;
    }
}