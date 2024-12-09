using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLCNPM2
{
    public partial class TrangChu2 : Form
    {
        public TrangChu2()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan qltk = new QuanLyTaiKhoan(this);
            this.Hide();
            qltk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyHocPhi qlhp = new QuanLyHocPhi(this);
            this.Hide();
            qlhp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyHocVien qlhv = new QuanLyHocVien(this);
            this.Hide();
            qlhv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaoCaoThuChi bctt = new BaoCaoThuChi(this);
            this.Hide();
            bctt.Show();
        }
    }
}
