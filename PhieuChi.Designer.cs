namespace BTLCNPM2
{
    partial class PhieuChi
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
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtnoidung = new TextBox();
            txttienchi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Phiếu chi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 123);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Nội dung chi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 173);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Số tiền cần chi";
            // 
            // button1
            // 
            button1.Location = new Point(339, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Tạo phiếu chi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(262, 120);
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(313, 27);
            txtnoidung.TabIndex = 5;
            // 
            // txttienchi
            // 
            txttienchi.Location = new Point(262, 173);
            txttienchi.Name = "txttienchi";
            txttienchi.Size = new Size(313, 27);
            txttienchi.TabIndex = 6;
            // 
            // PhieuChi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttienchi);
            Controls.Add(txtnoidung);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PhieuChi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhieuChi";
            FormClosed += PhieuChi_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtnoidung;
        private TextBox txttienchi;
    }
}