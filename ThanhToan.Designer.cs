namespace BTLCNPM2
{
    partial class ThanhToan
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
            dgvthanhtoan = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtluandett = new TextBox();
            txttientt = new TextBox();
            btnthanhtoan = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtid = new TextBox();
            groupBox2 = new GroupBox();
            txttongtt = new TextBox();
            label6 = new Label();
            btnthanhtoanall = new Button();
            label4 = new Label();
            label5 = new Label();
            txtmatt = new TextBox();
            txttentt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvthanhtoan).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Thanh toán ";
            // 
            // dgvthanhtoan
            // 
            dgvthanhtoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvthanhtoan.Location = new Point(12, 121);
            dgvthanhtoan.Name = "dgvthanhtoan";
            dgvthanhtoan.RowHeadersWidth = 51;
            dgvthanhtoan.Size = new Size(776, 188);
            dgvthanhtoan.TabIndex = 1;
            dgvthanhtoan.CellContentClick += dgvthanhtoan_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 23);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên luận đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 25);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Số tiền ";
            // 
            // txtluandett
            // 
            txtluandett.Location = new Point(207, 18);
            txtluandett.Name = "txtluandett";
            txtluandett.ReadOnly = true;
            txtluandett.Size = new Size(135, 27);
            txtluandett.TabIndex = 5;
            // 
            // txttientt
            // 
            txttientt.Location = new Point(413, 18);
            txttientt.Name = "txttientt";
            txttientt.ReadOnly = true;
            txttientt.Size = new Size(136, 27);
            txttientt.TabIndex = 6;
            // 
            // btnthanhtoan
            // 
            btnthanhtoan.Location = new Point(569, 18);
            btnthanhtoan.Name = "btnthanhtoan";
            btnthanhtoan.Size = new Size(94, 29);
            btnthanhtoan.TabIndex = 7;
            btnthanhtoan.Text = "Thanh toán";
            btnthanhtoan.UseVisualStyleBackColor = true;
            btnthanhtoan.Click += btnthanhtoan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnthanhtoan);
            groupBox1.Controls.Add(txtluandett);
            groupBox1.Controls.Add(txttientt);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(18, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 53);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thanh toán từng luận đề";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 22);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 9;
            label7.Text = "ID";
            // 
            // txtid
            // 
            txtid.Location = new Point(50, 22);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(50, 27);
            txtid.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txttongtt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnthanhtoanall);
            groupBox2.Location = new Point(18, 374);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(765, 64);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thanh toán toàn bộ";
            // 
            // txttongtt
            // 
            txttongtt.Location = new Point(97, 23);
            txttongtt.Name = "txttongtt";
            txttongtt.ReadOnly = true;
            txttongtt.Size = new Size(354, 27);
            txttongtt.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 1;
            label6.Text = "Tổng tiền";
            // 
            // btnthanhtoanall
            // 
            btnthanhtoanall.Location = new Point(569, 26);
            btnthanhtoanall.Name = "btnthanhtoanall";
            btnthanhtoanall.Size = new Size(94, 29);
            btnthanhtoanall.TabIndex = 0;
            btnthanhtoanall.Text = "Thanh toán";
            btnthanhtoanall.UseVisualStyleBackColor = true;
            btnthanhtoanall.Click += btnthanhtoanall_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 66);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "Mã sinh viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 66);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 11;
            label5.Text = "Tên sinh viên";
            // 
            // txtmatt
            // 
            txtmatt.Location = new Point(139, 63);
            txtmatt.Name = "txtmatt";
            txtmatt.ReadOnly = true;
            txtmatt.Size = new Size(154, 27);
            txtmatt.TabIndex = 12;
            // 
            // txttentt
            // 
            txttentt.Location = new Point(495, 63);
            txttentt.Name = "txttentt";
            txttentt.ReadOnly = true;
            txttentt.Size = new Size(201, 27);
            txttentt.TabIndex = 13;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttentt);
            Controls.Add(txtmatt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvthanhtoan);
            Controls.Add(label1);
            Name = "ThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThanhToan";
            FormClosed += ThanhToan_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvthanhtoan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvthanhtoan;
        private Label label2;
        private Label label3;
        private TextBox txtluandett;
        private TextBox txttientt;
        private Button btnthanhtoan;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnthanhtoanall;
        private Label label4;
        private Label label5;
        private TextBox txtmatt;
        private TextBox txttentt;
        private TextBox txttongtt;
        private Label label6;
        private Label label7;
        private TextBox txtid;
    }
}