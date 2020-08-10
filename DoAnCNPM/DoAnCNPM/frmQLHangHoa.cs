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
    public partial class frmQLHangHoa : Form
    {
        HangHoa_BLL hh = new HangHoa_BLL();
        string[] sizeao = new string[] { "S", "M", "L", "XL", "XXL" };
        int[] sizequan = { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
        int[] sizegiay = { 35, 36, 37, 38, 39, 40, 41, 42, 43, 44 };
        string[] sizemu = new string[] { "XXS", "XS", "S", "M", "L", "XL", "2XL", "3XL" };
        public frmQLHangHoa()
        {
            InitializeComponent();
        }

        private void frmQLHangHoa_Load(object sender, EventArgs e)
        {
            cboMaLoai.DataSource = hh.getLoaiHangHoa();
            cboMaLoai.DisplayMember = "tenLoaiHH";
            cboMaLoai.ValueMember = "maLoaiHH";
        }


        private void cboMaLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cboMaLoai.SelectedValue.ToString().Trim() == "MH001")
                {
                    cboSize.DataSource = sizequan;
                }
                else if (cboMaLoai.SelectedValue.ToString().Trim() == "MH002")
                {
                    cboSize.DataSource = sizeao;
                }
                else if (cboMaLoai.SelectedValue.ToString().Trim() == "MH003")
                {
                    cboSize.DataSource = sizegiay;
                }
                else if (cboMaLoai.SelectedValue.ToString().Trim() == "MH004")
                {
                    cboSize.DataSource = sizemu;
                }
            }
            catch
            {
            }
        }
    }
}
