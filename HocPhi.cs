using DTO;
using DAL;
using BLL;
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
    public partial class HocPhi : Form
    {
        private HocVienBLL hocvien = new HocVienBLL();
        private TrangChu1 trangChu1;
        private MonHocBLL luanvanbll = new MonHocBLL();
        public HocPhi(TrangChu1 trangChu1)
        {
            InitializeComponent();
            this.trangChu1 = trangChu1;
        }
        public void Setmhp(string mahp)
        {
            if (int.TryParse(mahp, out int idHocVien))
            {
                txtmasinhvien.Text = mahp;
                loaddata(idHocVien);
                LoadLuanVanData(idHocVien);

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

                txttensinhvien.Text = soyeu.HoTen;

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }
        public void LoadLuanVanData(int idHocVien)
        {
            List<MonHocDTOcs> luanVans = luanvanbll.LayLuanVanTheoHocVien(idHocVien);
            dgvdanhsach.DataSource = luanVans;
            // Tính tổng tiền và hiển thị trong txttongtien
            decimal tongTien = luanvanbll.TinhTongTienLuanVan(idHocVien);
            txttongtien.Text = tongTien.ToString("N2"); // Định dạng số thập phân
        }
        private void HocPhi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String matt = txtmasinhvien.Text;
            ThanhToan tt = new ThanhToan(this);
            tt.SetMatt(matt);
            tt.Show();
            this.Hide();
        }

        private void HocPhi_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu1.Show();
        }
    }
}
