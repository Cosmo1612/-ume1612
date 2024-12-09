using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace BTLCNPM2
{
    public partial class TrangChu1 : Form
    {
        private NguoiSuDungBLL nguoiSuDungBLL = new NguoiSuDungBLL();


        public TrangChu1()
        {
            InitializeComponent();
        }

        public void SetTenDangNhap(string tenDangNhap)
        {
            label2.Text = tenDangNhap;
            loaddata(tenDangNhap);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ttnd = label2.Text;
            if (!string.IsNullOrEmpty(ttnd))
            {
                ThongTinNguoiDung tt = new ThongTinNguoiDung(this);
                tt.SetTenNguoiDung(ttnd);
                tt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không có dữ liệu.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mhv = label3.Text;
            SoYeuLiLich syll = new SoYeuLiLich(this);
            syll.SetMsv(mhv);
            syll.Show();
            this.Hide();
        }

        public void loaddata(string tenDangNhap)
        {
            TaiKhoan userInfo = nguoiSuDungBLL.LayThongTinNguoiDung(tenDangNhap);

            if (userInfo != null)
            {
                label3.Text = userInfo.Id.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String mhp = label3.Text;
            HocPhi hp = new HocPhi(this);
            hp.Setmhp(mhp);
            hp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LichSuThuPhi ls = new LichSuThuPhi(this);
            String mls = label3.Text;
            ls.Setmls(mls);
            ls.Show();
            this.Hide();
        }
    }
}
