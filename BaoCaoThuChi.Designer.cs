namespace BTLCNPM2
{
    partial class BaoCaoThuChi
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
            cbbchoose = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbbchoose
            // 
            cbbchoose.FormattingEnabled = true;
            cbbchoose.Location = new Point(38, 70);
            cbbchoose.Name = "cbbchoose";
            cbbchoose.Size = new Size(194, 28);
            cbbchoose.TabIndex = 0;
            cbbchoose.SelectedIndexChanged += cbbchoose_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Báo cáo thu chi";
            // 
            // button1
            // 
            button1.Location = new Point(332, 69);
            button1.Name = "button1";
            button1.Size = new Size(137, 29);
            button1.TabIndex = 2;
            button1.Text = "Tạo phiếu chi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 283);
            dataGridView1.TabIndex = 3;
            // 
            // BaoCaoThuChi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbbchoose);
            Name = "BaoCaoThuChi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaoCaoThuChi";
            FormClosed += BaoCaoThuChi_FormClosed;
            Load += BaoCaoThuChi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbchoose;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}