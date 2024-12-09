using BLL;
using Microsoft.VisualBasic.ApplicationServices;

namespace BTLCNPM2
{
    public partial class Form1 : Form
    {
        private NguoiSuDungBLL nguoiSuDungBLL = new NguoiSuDungBLL();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tenDangNhap = user.Text;
            string matKhau = password.Text;

            try
            {
                bool isAuthenticated = nguoiSuDungBLL.DangNhap(tenDangNhap, matKhau);

                if (isAuthenticated)
                {
                    string quyen = nguoiSuDungBLL.LayQuyen(tenDangNhap);
                    MessageBox.Show($"Đăng nhập thành công. Quyền của bạn là: {quyen}");
                    if (quyen == "Học Viên")
                    {
                        TrangChu1 tc1 = new TrangChu1();
                        tc1.SetTenDangNhap(tenDangNhap);
                        this.Hide();
                        tc1.Show();
                    }
                    else
                    {
                        TrangChu2 tc2 = new TrangChu2();
                        this.Hide();
                        tc2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
