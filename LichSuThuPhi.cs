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
    public partial class LichSuThuPhi : Form
    {
        private TrangChu1 trangChu1;
        private HocVienBLL hocvien = new HocVienBLL();
        private LichSuThuPhiBLL lichSuThuPhiBLL = new LichSuThuPhiBLL();
        public LichSuThuPhi(TrangChu1 trangChu1)
        {
            InitializeComponent();
            this.trangChu1 = trangChu1;
        }
        public void Setmls(string mls)
        {
            if (int.TryParse(mls, out int idHocVien))
            {
                txtmls.Text = mls;
                loaddata(idHocVien);

            }
            else
            {
                MessageBox.Show("Mã học viên không hợp lệ.");
            }
        }
        public void loaddata(int idHocVien)
        {
            SoYeuLL soyeu = hocvien.laythongtinhocvien(idHocVien);

            if (soyeu != null)
            {

                txttenls.Text = soyeu.HoTen;
                LoadLichSuThuPhi(idHocVien);

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }
        private void LoadLichSuThuPhi(int idHocVien)
        {
            List<LichSuThuPhiDTO> lichSuList = lichSuThuPhiBLL.LayLichSuThuPhi(idHocVien);
            dataGridView1.DataSource = lichSuList; // Gán dữ liệu vào DataGridView
        }

        private void LichSuThuPhi_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu1.Show();
        }
    }
}
