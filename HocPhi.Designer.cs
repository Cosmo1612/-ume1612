namespace BTLCNPM2
{
    partial class HocPhi
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
            label1 = new Label();
            dgvdanhsach = new DataGridView();
            label2 = new Label();
            txttensinhvien = new TextBox();
            label3 = new Label();
            txtmasinhvien = new TextBox();
            label4 = new Label();
            txttongtien = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Học phí ";
            // 
            // dgvdanhsach
            // 
            dgvdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsach.Location = new Point(69, 134);
            dgvdanhsach.Name = "dgvdanhsach";
            dgvdanhsach.RowHeadersWidth = 51;
            dgvdanhsach.Size = new Size(674, 188);
            dgvdanhsach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 77);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sinh viên";
            // 
            // txttensinhvien
            // 
            txttensinhvien.Location = new Point(477, 74);
            txttensinhvien.Name = "txttensinhvien";
            txttensinhvien.ReadOnly = true;
            txttensinhvien.Size = new Size(199, 27);
            txttensinhvien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 77);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã sinh viên";
            // 
            // txtmasinhvien
            // 
            txtmasinhvien.Location = new Point(175, 74);
            txtmasinhvien.Name = "txtmasinhvien";
            txtmasinhvien.ReadOnly = true;
            txtmasinhvien.Size = new Size(125, 27);
            txtmasinhvien.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 332);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Tổng tiền ";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(154, 330);
            txttongtien.Name = "txttongtien";
            txttongtien.ReadOnly = true;
            txttongtien.Size = new Size(142, 27);
            txttongtien.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(331, 328);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txttongtien);
            Controls.Add(label4);
            Controls.Add(txtmasinhvien);
            Controls.Add(label3);
            Controls.Add(txttensinhvien);
            Controls.Add(label2);
            Controls.Add(dgvdanhsach);
            Controls.Add(label1);
            Name = "HocPhi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HocPhi";
            FormClosed += HocPhi_FormClosed;
            Load += HocPhi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdanhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvdanhsach;
        private Label label2;
        private TextBox txttensinhvien;
        private Label label3;
        private TextBox txtmasinhvien;
        private Label label4;
        private TextBox txttongtien;
        private Button button1;
    }
}