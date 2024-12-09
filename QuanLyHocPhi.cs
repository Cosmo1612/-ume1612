using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BTLCNPM2
{
    public partial class QuanLyHocPhi : Form
    {
        private MonHocBLL luanVanBLL = new MonHocBLL();
        private LichSuThuPhiBLL lichSuThuPhiBLL = new LichSuThuPhiBLL();
        private TrangChu2 trangChu2;

        public QuanLyHocPhi(TrangChu2 trangChu2)
        {
            InitializeComponent();
            this.trangChu2 = trangChu2;
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Chọn tệp Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtlvexcel.Text = openFileDialog.FileName;
                    luanVanBLL.InsertFromExcel(openFileDialog.FileName);
                    MessageBox.Show("Dữ liệu đã được chèn thành công vào bảng luan_van_luan_an.");
                }
            }
        }

        private void QuanLyHocPhi_Load(object sender, EventArgs e)
        {
            cbbchoose.Items.Clear();
            cbbchoose.Items.Add("Môn học đã đăng ký");
            cbbchoose.Items.Add("Sinh viên đã thu");
            cbbchoose.SelectedIndex = 0;
        }

        private void cbbchoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbbchoose.SelectedItem.ToString();

            if (selectedValue == "Môn học đã đăng ký")
            {
                List<MonHocDTOcs> danhSachLuanVan = luanVanBLL.LayLuanVan();
                dataGridView1.DataSource = danhSachLuanVan;
            }
            else if (selectedValue == "Sinh viên đã thu")
            {
                List<LichSuThuPhiDTO> danhSachThuPhi = lichSuThuPhiBLL.Laydanhsachthu();
                dataGridView1.DataSource = danhSachThuPhi;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedOption = cbbchoose.SelectedItem.ToString();

            // Kiểm tra xem giá trị nhập vào có phải là số nguyên không
            if (!int.TryParse(txttimkiem.Text.Trim(), out int idHocVien))
            {
                MessageBox.Show("Vui lòng nhập một ID học viên hợp lệ.");
                return;
            }

            if (selectedOption == "Luận văn luận án")
            {
                var danhSachLuanVan = luanVanBLL.GetLuanVanByHocVienId(idHocVien);
                if (danhSachLuanVan.Rows.Count > 0)
                {
                    dataGridView1.DataSource = danhSachLuanVan;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy luận văn nào cho ID học viên đã nhập.");
                }
            }
            else if (selectedOption == "Sinh viên đã thu")
            {
                var danhSachThuPhi = lichSuThuPhiBLL.LayLichSuThuPhi(idHocVien);
                if (danhSachThuPhi != null && danhSachThuPhi.Any())
                {
                    dataGridView1.DataSource = danhSachThuPhi;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lịch sử thu phí cho ID học viên đã nhập.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm hợp lệ.");
            }
        }

        private void QuanLyHocPhi_FormClosing(object sender, FormClosingEventArgs e)
        {
            trangChu2.Show();
        }
    }
}
