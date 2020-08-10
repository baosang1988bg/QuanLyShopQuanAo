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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        private Form KiemTraTonTai(Type ptype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ptype)
                {
                    return f;
                }
            }
            return null;
        }

        private void txtKhachHang_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtKhachHang_Leave(object sender, EventArgs e)
        {
            
        }

        public void loadKH()
        {
            
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadKH();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
