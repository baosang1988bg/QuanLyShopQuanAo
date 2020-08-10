using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DoAnCNPM
{
    public partial class frmPhieuXuatBanHang : Form
    {
        HoaDon_BLL hd = new HoaDon_BLL();
        int dong = 0;
        public frmPhieuXuatBanHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog();
        }

        private void frmPhieuXuatBanHang_Load(object sender, EventArgs e)
        {
            tenMH.DataSource = hd.getHangHoa();
            tenMH.DisplayMember = "tenMH";
            tenMH.ValueMember = "maMH";
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            //if (dgvCTHD.Rows[dong].Cells[2].Value.ToString() != "0" && dgvCTHD.Rows[dong].Cells[1].Value.ToString() != "0")
            //{
            //    try
            //    {
            //        float tt = int.Parse(dgvCTHD.Rows[dong].Cells[1].Value.ToString()) * (float)hd.getCTHH(dgvCTHD.Rows[dong].Cells[0].Value.ToString()).DonGia;
            //        dgvCTHD.Rows[dong].Cells[3].Value = tt;
            //    }
            //    catch
            //    {
            //        return;
            //    }
            //}
            //try
            //{
            //    dgvCTHD.Rows[dong].Cells[2].Value = hd.getCTHH(dgvCTHD.Rows[dong].Cells[0].Value.ToString()).DonGia.ToString();
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void dgvCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTHD.Rows[dong].Cells[1].Value != "0" && dgvCTHD.Rows[dong].Cells[2].Value != "0")
            {
                try
                {
                    float tt = int.Parse(dgvCTHD.Rows[dong].Cells[1].Value.ToString()) * (float)hd.getCTHH(dgvCTHD.Rows[dong].Cells[0].Value.ToString()).DonGia;
                    dgvCTHD.Rows[dong].Cells[3].Value = tt;
                }
                catch
                {
                    return;
                }
            }
            try
            {
                dgvCTHD.Rows[dong].Cells[2].Value = hd.getCTHH(dgvCTHD.Rows[dong].Cells[0].Value.ToString()).DonGia.ToString();
            }
            catch
            {
                return;
            }
        }
    }
}
