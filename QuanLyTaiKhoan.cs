using BLL;
using DTO;
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
    public partial class QuanLyTaiKhoan : Form
    {
        private NguoiSuDungBLL nguoiSuDungBLL = new NguoiSuDungBLL();
        private TrangChu2 trangChu2;
        public QuanLyTaiKhoan(TrangChu2 trangChu2)
        {
            InitializeComponent();
            this.trangChu2 = trangChu2;
            loaddata();
        }
        public void loaddata()
        {
            NguoiSuDungBLL nguoiSuDungBLL = new NguoiSuDungBLL();
            List<TaiKhoan> danhSachNguoiDung = nguoiSuDungBLL.LayTatCaNguoiSuDung();
            dataGridView1.DataSource = danhSachNguoiDung;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txtidtk.Text = row.Cells["Id"].Value.ToString();
                txttentk.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtemailtk.Text = row.Cells["Email"].Value.ToString();
                txtmktk.Text = row.Cells["MatKhau"].Value.ToString();
                txtvaitrotk.Text = row.Cells["VaiTro"].Value.ToString();

                txtidtk.ReadOnly = true;

                string tenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                txtquyentk.Text = nguoiSuDungBLL.LayQuyen(tenDangNhap);
            }
        }

        private void txtboquatk_Click(object sender, EventArgs e)
        {
            txtidtk.ResetText();
            txttentk.ResetText();
            txtmktk.ResetText();
            txtvaitrotk.ResetText();
            txtemailtk.ResetText();
            txtquyentk.ResetText();
            txtidtk.ReadOnly = false;
        }

        private void btnthemtk_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan
            {
                TenDangNhap = txttentk.Text,
                MatKhau = txtmktk.Text,
                VaiTro = txtvaitrotk.Text,
                Email = txtemailtk.Text
            };

            string quyen = txtquyentk.Text;

            // Thêm tài khoản và phân quyền
            bool isSuccess = nguoiSuDungBLL.ThemTaiKhoanVaQuyen(taiKhoan, quyen);

            if (isSuccess)
            {
                MessageBox.Show("Thêm tài khoản và quyền thành công!");
                loaddata(); // Refresh dữ liệu nếu cần
            }
            else
            {
                MessageBox.Show("Thêm tài khoản hoặc quyền thất bại.");
            }
        }

        private void btnsuatk_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan
            {
                Id = int.Parse(txtidtk.Text),
                TenDangNhap = txttentk.Text,
                MatKhau = txtmktk.Text,
                VaiTro = txtvaitrotk.Text,
                Email = txtemailtk.Text
            };

            string quyen = txtquyentk.Text;

            // Cập nhật tài khoản và quyền
            bool isSuccess = nguoiSuDungBLL.CapNhatTaiKhoanVaQuyen(taiKhoan, quyen);

            if (isSuccess)
            {
                MessageBox.Show("Cập nhật tài khoản và quyền thành công!");
                loaddata(); // Refresh dữ liệu nếu cần
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản hoặc quyền thất bại.");
            }
        }

        private void btnxoatk_Click(object sender, EventArgs e)
        {
            int idNguoiSuDung;
            if (int.TryParse(txtidtk.Text, out idNguoiSuDung))
            {
                // Gọi phương thức xóa tài khoản
                bool isSuccess = nguoiSuDungBLL.XoaTaiKhoan(idNguoiSuDung);

                if (isSuccess)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    loaddata(); // Refresh dữ liệu nếu cần
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại.");
                }
            }
            else
            {
                MessageBox.Show("ID người dùng không hợp lệ.");
            }
        }

        private void QuanLyTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu2.Show();
        }
    }
}
