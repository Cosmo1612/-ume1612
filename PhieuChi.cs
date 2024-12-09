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
    public partial class PhieuChi : Form
    {
        private BaoCaoBLL baocao = new BaoCaoBLL();
        private BaoCaoThuChi bctt;
        public PhieuChi(BaoCaoThuChi bctt)
        {
            InitializeComponent();
            this.bctt = bctt;
        }

        private void PhieuChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            bctt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoChiDTO phieuchi = new BaoCaoChiDTO
            {
                 NoiDung = txtnoidung.Text,
                 SoTienChi = decimal.Parse(txttienchi.Text)
            };
            if (baocao.insertphieuthu(phieuchi))
            {
                MessageBox.Show("Thêm phiếu chi thành công.");
                this.Hide();
                bctt.Show();
            }
            else
            {
                MessageBox.Show("Thêm phiêu chi thất bại.");
            }
        }
    }
}
