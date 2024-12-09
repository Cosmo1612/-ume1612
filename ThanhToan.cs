using BLL;
using DTO;
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
    public partial class ThanhToan : Form
    {
        private HocVienBLL hocvien = new HocVienBLL();
        private MonHocBLL luanvanbll = new MonHocBLL();
        private LichSuThuPhiBLL lichSuThuPhiBLL = new LichSuThuPhiBLL();
        private HocPhi hocPhi;
        private ThuHocPhiBLL thuHocPhi = new ThuHocPhiBLL();
        public ThanhToan(HocPhi hocPhi)
        {
            InitializeComponent();
            this.hocPhi = hocPhi;
        }
        public void SetMatt(string matt)
        {
            if (int.TryParse(matt, out int idHocVien))
            {
                txtmatt.Text = matt;
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

                txttentt.Text = soyeu.HoTen;

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }
        public void LoadLuanVanData(int idHocVien)
        {
            List<MonHocDTOcs> luanVans = luanvanbll.LayLuanVanTheoHocVien(idHocVien);
            dgvthanhtoan.DataSource = luanVans;

            decimal tongTien = luanvanbll.TinhTongTienLuanVan(idHocVien);
            txttongtt.Text = tongTien.ToString("N2"); // Định dạng số thập phân
        }

        private void LoadDataToDgvThanhToan()
        {
            int idHocVien = int.Parse(txtmatt.Text);
            DataTable dt = luanvanbll.GetLuanVanByHocVienId(idHocVien); // Lấy danh sách luận văn theo id học viên
            dgvthanhtoan.DataSource = dt;
        }

        private void dgvthanhtoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvthanhtoan.Rows[e.RowIndex];

                // Lấy dữ liệu từ cột và đổ vào các TextBox
                txtid.Text = selectedRow.Cells[0].Value.ToString();
                txtluandett.Text = selectedRow.Cells[2].Value.ToString();  // Cột thứ 2
                txttientt.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox
                int idHocVien = int.Parse(txtmatt.Text);
                decimal soTien = decimal.Parse(txttientt.Text);
                DateTime ngayNop = DateTime.Now; // Ngày hiện tại
                string noiDung = txttentt.Text;
                int idLuanVan = int.Parse(txtid.Text); // ID luận văn cần xóa

                // Thêm vào lịch sử thu phí
                bool isSuccess = lichSuThuPhiBLL.ThemLichSuThuPhi(idHocVien, soTien, ngayNop, noiDung);

                if (isSuccess)
                {
                    // Thêm thông tin vào bảng thu_hoc_phi
                    bool isThuHocPhiSuccess = thuHocPhi.ThemThuHocPhi(idHocVien, soTien, ngayNop, noiDung);

                    if (isThuHocPhiSuccess)
                    {
                        // Xóa luận văn khỏi bảng luan_van_luan_an
                        bool isDeleted = luanvanbll.XoaLuanVan(idLuanVan);

                        if (isDeleted)
                        {
                            // Thêm biên lai
                            BienLaiBLL bienLaiBLL = new BienLaiBLL();
                            var result = MessageBox.Show("Bạn muốn in biên lai hay không?", "Xác nhận", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                BienLaiDTO bienLai = new BienLaiDTO
                                {
                                    IdHocVien = idHocVien,
                                    SoBienLai = Guid.NewGuid().ToString(), // Tạo số biên lai ngẫu nhiên
                                    NgayPhatHanh = ngayNop,
                                    SoTien = soTien
                                };

                                // Thêm biên lai vào cơ sở dữ liệu
                                if (bienLaiBLL.ThemBienLai(bienLai))
                                {
                                    // Tạo file Notepad để in biên lai
                                    string filePath = "BienLai.txt";
                                    string content = $"Số biên lai: {bienLai.SoBienLai}\nHọ tên: {txttentt.Text}\nSố tiền: {soTien}\nNgày phát hành: {ngayNop.ToShortDateString()}";
                                    System.IO.File.WriteAllText(filePath, content);

                                    // Mở Notepad để in biên lai
                                    System.Diagnostics.Process.Start("notepad.exe", filePath);
                                    MessageBox.Show("Thanh toán và xóa luận văn thành công.");
                                }
                                else
                                {
                                    MessageBox.Show("Thanh toán thành công, nhưng không thể tạo biên lai.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán thành công, nhưng không in biên lai.");
                            }

                            LoadDataToDgvThanhToan();
                            LoadLuanVanData(idHocVien);
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán thành công, nhưng không thể xóa luận văn.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể ghi thông tin vào bảng thu học phí.");
                    }
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void ThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            hocPhi.Show();
        }

        private void btnthanhtoanall_Click(object sender, EventArgs e)
        {
            try
            {
                int idHocVien = int.Parse(txtmatt.Text);
                decimal tongTien = luanvanbll.TinhTongTienLuanVan(idHocVien); // Tính tổng tiền từ tất cả luận văn

                // Kiểm tra xem có luận văn nào không
                if (tongTien <= 0)
                {
                    MessageBox.Show("Không có luận đề nào để xóa.");
                    return;
                }

                // Xóa toàn bộ luận văn của học viên
                bool isDeleted = luanvanbll.XoaToanBoLuanVan(idHocVien);

                if (isDeleted)
                {
                    // Thêm vào bảng thu học phí
                    ThuHocPhiBLL thuHocPhiBLL = new ThuHocPhiBLL();
                    DateTime ngayNop = DateTime.Now; // Ngày hiện tại
                    string noiDung = txttentt.Text; // Nội dung thanh toán

                    bool isThuHocPhiSuccess = thuHocPhiBLL.ThemThuHocPhi(idHocVien, tongTien, ngayNop, noiDung);

                    if (isThuHocPhiSuccess)
                    {
                        // Thêm biên lai
                        BienLaiBLL bienLaiBLL = new BienLaiBLL();
                        var result = MessageBox.Show("Bạn muốn in biên lai hay không?", "Xác nhận", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            BienLaiDTO bienLai = new BienLaiDTO
                            {
                                IdHocVien = idHocVien,
                                SoBienLai = Guid.NewGuid().ToString(), // Tạo số biên lai ngẫu nhiên
                                NgayPhatHanh = DateTime.Now, // Ngày phát hành là hiện tại
                                SoTien = tongTien
                            };

                            // Thêm biên lai vào cơ sở dữ liệu
                            if (bienLaiBLL.ThemBienLai(bienLai))
                            {
                                // Tạo file Notepad để in biên lai
                                string filePath = "BienLai_TatCa.txt";
                                string content = $"Số biên lai: {bienLai.SoBienLai}\nHọ tên: {txttentt.Text}\nTổng số tiền: {tongTien}\nNgày phát hành: {bienLai.NgayPhatHanh.ToShortDateString()}";
                                System.IO.File.WriteAllText(filePath, content);

                                // Mở Notepad để in biên lai
                                System.Diagnostics.Process.Start("notepad.exe", filePath);
                                MessageBox.Show("Xóa toàn bộ luận đề và thanh toán thành công.");
                                LoadDataToDgvThanhToan();
                                LoadLuanVanData(idHocVien);// Load lại dữ liệu trong DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Xóa thành công, nhưng không thể tạo biên lai.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xóa thành công, nhưng không in biên lai.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành công, nhưng không thể ghi thông tin vào bảng thu học phí.");
                    }
                }
                else
                {
                    MessageBox.Show("Không có luận đề nào để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
