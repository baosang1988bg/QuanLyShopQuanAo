using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;

namespace DoAnCNPM
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DangNhap_BLL dn = new DangNhap_BLL();
        public frmMain()
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
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            
            //lblTenNV.Caption = "Xin chào " + dn.GetTenNV(frmDangNhap.LuuThongTin.MANV);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLKhachHang f = new frmQLKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLTaiKhoan f = new frmQLTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLNhanVien f = new frmQLNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLKhachHang f = new frmQLKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLNCC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLNCC f = new frmQLNCC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLHangHoa));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQLHangHoa f = new frmQLHangHoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FrmQLLoaiHH));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmQLLoaiHH f = new FrmQLLoaiHH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmPhieuXuatBanHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuXuatBanHang f = new frmPhieuXuatBanHang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}