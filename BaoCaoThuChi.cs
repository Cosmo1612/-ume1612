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
    public partial class BaoCaoThuChi : Form
    {
        private TrangChu2 trangChu2;
        private BaoCaoBLL baocao = new BaoCaoBLL();
        public BaoCaoThuChi(TrangChu2 trangChu2)
        {
            InitializeComponent();
            this.trangChu2 = trangChu2;
        }

        private void BaoCaoThuChi_Load(object sender, EventArgs e)
        {
            cbbchoose.Items.Clear();
            cbbchoose.Items.Add("Báo cáo thu");
            cbbchoose.Items.Add("Báo cáo chi");
            cbbchoose.SelectedIndex = 0;
        }

        private void cbbchoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbbchoose.SelectedItem.ToString();

            if (selectedValue == "Báo cáo thu")
            {
                List<BaoCaoThuDTO> tongthu = baocao.tongdanhsachthu();
                dataGridView1.DataSource = tongthu;
            }
            else if (selectedValue == "Báo cáo chi")
            {
                List<BaoCaoChiDTO> danhSachThuPhi = baocao.danhsachchi();
                dataGridView1.DataSource = danhSachThuPhi;
            }
        }

        private void BaoCaoThuChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            trangChu2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuChi pc = new PhieuChi(this);
            this.Hide();
            pc.ShowDialog();
            if(pc.Close != null)
            {
                List<BaoCaoChiDTO> danhSachThuPhi = baocao.danhsachchi();
                dataGridView1.DataSource = danhSachThuPhi;
            }
        }
    }
}
