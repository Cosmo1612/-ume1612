using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace BTLCNPM2
{
    public partial class ThongTinNguoiDung : Form
    {
        private NguoiSuDungBLL nguoiSuDungBLL = new NguoiSuDungBLL();
        private TrangChu1 trangChu1;

        public ThongTinNguoiDung(TrangChu1 trangChu1)
        {
            InitializeComponent();
            this.trangChu1 = trangChu1;
        }

        // Phương thức để nhận tên đăng nhập từ Form khác
        public void SetTenNguoiDung(string tenDangNhap)
        {
            label1.Text = "Thông tin tài khoản: " + tenDangNhap; // Cập nhật label1 với tên đăng nhập
            loaddata(tenDangNhap);// Gọi phương thức load dữ liệu với tên đăng nhập
        }

        // Phương thức load dữ liệu người dùng
        public void loaddata(string tenDangNhap)
        {
            TaiKhoan userInfo = nguoiSuDungBLL.LayThongTinNguoiDung(tenDangNhap);

            if (userInfo != null)
            {
                txtmasv.ReadOnly = true;
                txtvaitro.ReadOnly = true;
                txttendangnhap.ReadOnly = true;
                txtmasv.Text = userInfo.Id.ToString();
                txttendangnhap.Text = userInfo.TenDangNhap;
                txtmatkhau.Text = userInfo.MatKhau;
                txtemail.Text = userInfo.Email;
                txtvaitro.Text = userInfo.VaiTro;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }

        private void ThongTinNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void ThongTinNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu1.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan
            {
                Id = int.Parse(txtmasv.Text),
                TenDangNhap = txttendangnhap.Text,
                MatKhau = txtmatkhau.Text,
                VaiTro = txtvaitro.Text,
                Email = txtemail.Text

            };
            bool isSuccess = nguoiSuDungBLL.capnhatnguoidung(taiKhoan);

            if (isSuccess)
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại.");
            }
        }
    }
}
