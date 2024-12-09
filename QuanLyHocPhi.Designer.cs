namespace BTLCNPM2
{
    partial class QuanLyHocPhi
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
            txttimkiem = new TextBox();
            dataGridView1 = new DataGridView();
            cbbchoose = new ComboBox();
            txtlvexcel = new TextBox();
            btnupload = new Button();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản lý học phí";
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(12, 96);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Nhập mã sinh viên";
            txttimkiem.Size = new Size(431, 27);
            txttimkiem.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 309);
            dataGridView1.TabIndex = 3;
            // 
            // cbbchoose
            // 
            cbbchoose.FormattingEnabled = true;
            cbbchoose.Location = new Point(159, 60);
            cbbchoose.Name = "cbbchoose";
            cbbchoose.Size = new Size(151, 28);
            cbbchoose.TabIndex = 4;
            cbbchoose.SelectedIndexChanged += cbbchoose_SelectedIndexChanged;
            // 
            // txtlvexcel
            // 
            txtlvexcel.Location = new Point(565, 92);
            txtlvexcel.Name = "txtlvexcel";
            txtlvexcel.PlaceholderText = "upload file excel";
            txtlvexcel.Size = new Size(123, 27);
            txtlvexcel.TabIndex = 5;
            // 
            // btnupload
            // 
            btnupload.Location = new Point(694, 92);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(94, 29);
            btnupload.TabIndex = 6;
            btnupload.Text = "Tải file";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 7;
            label2.Text = "lựa chọn hiển thị";
            // 
            // button1
            // 
            button1.Location = new Point(449, 94);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuanLyHocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnupload);
            Controls.Add(txtlvexcel);
            Controls.Add(cbbchoose);
            Controls.Add(dataGridView1);
            Controls.Add(txttimkiem);
            Controls.Add(label1);
            Name = "QuanLyHocPhi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyHocPhi";
            FormClosing += QuanLyHocPhi_FormClosing;
            Load += QuanLyHocPhi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txttimkiem;
        private DataGridView dataGridView1;
        private ComboBox cbbchoose;
        private TextBox txtlvexcel;
        private Button btnupload;
        private Label label2;
        private Button button1;
    }
}