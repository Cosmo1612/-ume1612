using DTO;
using BLL;
using DAL;
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
    public partial class QuanLyHocVien : Form
    {
        private TrangChu2 trangChu2;
        private HocVienBLL hocvien = new HocVienBLL();
        public QuanLyHocVien(TrangChu2 trangChu2)
        {
            InitializeComponent();
            this.trangChu2 = trangChu2;
            loaddata();
        }

        private void loaddata()
        {
            List<SoYeuLL> danhSachhv = hocvien.laydanhsachhocvien();
            dgvhocvien.DataSource = danhSachhv;
        }

        private void dgvhocvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvhocvien.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txtqlmasv.Text = row.Cells["Id"].Value.ToString();
                txtqltensv.Text = row.Cells["HoTen"].Value.ToString();
                txtqlgioitinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtqlngaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtqldiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtqldienthoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtqlemail.Text = row.Cells["Email"].Value.ToString();
                txtqlngayhoc.Text = row.Cells["NgayNHapHoc"].Value.ToString();
                txtqlchuyennganh.Text = row.Cells["MaChuyenNganh"].Value.ToString();
                txtqlhedaotao.Text = row.Cells["MaHeDaoTao"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtqlmasv.ResetText();
            txtqltensv.ResetText();
            txtqlgioitinh.ResetText();
            txtqlngaysinh.ResetText();
            txtqldiachi.ResetText();
            txtqldienthoai.ResetText();
            txtqlemail.ResetText();
            txtqlngayhoc.ResetText();
            txtqlchuyennganh.ResetText();
            txtqlhedaotao.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoYeuLL hocVien = new SoYeuLL
            {
                Id = int.Parse(txtqlmasv.Text),
                HoTen = txtqltensv.Text,
                NgaySinh = DateTime.Parse(txtqlngaysinh.Text),
                GioiTinh = txtqlgioitinh.Text,
                DiaChi = txtqldiachi.Text,
                DienThoai = txtqldienthoai.Text,
                Email = txtqlemail.Text,
                NgayNhapHoc = DateTime.Parse(txtqlngayhoc.Text),
                MaChuyenNganh = int.Parse(txtqlchuyennganh.Text),
                MaHeDaoTao = int.Parse(txtqlhedaotao.Text)
            };

            if (hocvien.InsertHocVien(hocVien))
            {
                MessageBox.Show("Thêm học viên thành công.");
                loaddata();
            }
            else
            {
                MessageBox.Show("Thêm học viên thất bại.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoYeuLL hocVien = new SoYeuLL
            {
                Id = int.Parse(txtqlmasv.Text),
                HoTen = txtqltensv.Text,
                NgaySinh = DateTime.Parse(txtqlngaysinh.Text),
                GioiTinh = txtqlgioitinh.Text,
                DiaChi = txtqldiachi.Text,
                DienThoai = txtqldienthoai.Text,
                Email = txtqlemail.Text,
                NgayNhapHoc = DateTime.Parse(txtqlngayhoc.Text),
                MaChuyenNganh = int.Parse(txtqlchuyennganh.Text),
                MaHeDaoTao = int.Parse(txtqlhedaotao.Text)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtqlmasv.Text, out int idHocVien))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (hocvien.DeleteHocVien(idHocVien))
                    {
                        MessageBox.Show("Xóa học viên thành công.");
                        ClearFields(); // Hàm xóa dữ liệu trong các trường
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Xóa học viên thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã học viên không hợp lệ.");
            }
        }

        private void ClearFields()
        {
            txtqlmasv.Text = string.Empty;
            txtqltensv.Text = string.Empty;
            txtqlngaysinh.Text = string.Empty;
            txtqlgioitinh.Text = string.Empty;
            txtqldiachi.Text = string.Empty;
            txtqldienthoai.Text = string.Empty;
            txtqlemail.Text = string.Empty;
            txtqlngayhoc.Text = string.Empty;
            txtqlchuyennganh.Text = string.Empty;
            txtqlhedaotao.Text = string.Empty;

        }

        private void QuanLyHocVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu2.Show();
        }
    }
}
