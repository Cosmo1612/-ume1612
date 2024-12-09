using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BLL;

namespace BTLCNPM2
{
    public partial class SoYeuLiLich : Form
    {
        private HocVienBLL hocvien = new HocVienBLL();
        private TrangChu1 trangChu1;
        private string mhv;

        public SoYeuLiLich(TrangChu1 trangChu1)
        {
            InitializeComponent();
            this.trangChu1 = trangChu1;
        }

        // Thiết lập mã học viên
        public void SetMsv(string mhv)
        {
            if (int.TryParse(mhv, out int idHocVien))
            {
                label1.Text = "Sơ yếu lí lịch: " + mhv;
                loaddata(idHocVien); // Gọi hàm load dữ liệu với kiểu int
            }
            else
            {
                MessageBox.Show("Mã học viên không hợp lệ.");
            }
        }

        // Hàm tải dữ liệu vào các ô text
        public void loaddata(int idHocVien)
        {
            SoYeuLL soyeu = hocvien.laythongtinhocvien(idHocVien);

            if (soyeu != null)
            {
                txtmsv.Text = soyeu.Id.ToString();
                txthoten.Text = soyeu.HoTen;
                txtngaysinh.Text = soyeu.NgaySinh.ToShortDateString();
                txtgioitinh.Text = soyeu.GioiTinh;
                txtdiachi.Text = soyeu.DiaChi;
                txtdienthoai.Text = soyeu.DienThoai;
                txtemail.Text = soyeu.Email;
                txtngaynhaphoc.Text = soyeu.NgayNhapHoc.ToShortDateString();
                txtchuyennganh.Text = soyeu.MaChuyenNganh.ToString();
                txthedaotao.Text = soyeu.MaHeDaoTao.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }

        private void SoYeuLiLich_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu1.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            SoYeuLL hocVien = new SoYeuLL
            {
                Id = int.Parse(txtmsv.Text),
                HoTen = txthoten.Text,
                NgaySinh = DateTime.Parse(txtngaysinh.Text),
                GioiTinh = txtgioitinh.Text,
                DiaChi = txtdiachi.Text,
                DienThoai = txtdienthoai.Text,
                Email = txtemail.Text,
                NgayNhapHoc = DateTime.Parse(txtngaynhaphoc.Text),
                MaChuyenNganh = int.Parse(txtchuyennganh.Text),
                MaHeDaoTao = int.Parse(txthedaotao.Text)
            };

            if (hocvien.UpdateHocVien(hocVien))
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }
    }
}
