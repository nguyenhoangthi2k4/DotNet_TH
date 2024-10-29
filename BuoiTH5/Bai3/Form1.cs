using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai3;

namespace Bai3
{
    public partial class frmMain : Form
    {
        private PhanSo ps1, ps2, psKQ;

        public frmMain()
        {
            InitializeComponent();  
            ps1 = new PhanSo();
            ps2 = new PhanSo();
            psKQ = new PhanSo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            this.txtTuSo1.Text = string.Empty;  
            this.txtMauSo1.Text = string.Empty;

            this.txtTuSo2.Text = string.Empty;
            this.txtMauSo2.Text = string.Empty;

            this.txtTuSoKQ.Text = string.Empty;
            this.txtMauSoKQ.Text = string.Empty;

            this.ps1 = new PhanSo();
            this.ps2 = new PhanSo();
            this.psKQ = new PhanSo();
        }
        public void checkInput()
        {
            if (int.Parse(txtMauSo1.Text) == 0)
            {
                this.Display();
                this.errorProvider_MS1.SetError(this.txtMauSo1, "Mẫu số phải khác 0");
            }  
            else
            {
                this.ps1.TuSo = int.Parse(txtTuSo1.Text);
                this.ps1.MauSo = int.Parse(txtMauSo1.Text);
                this.errorProvider_MS1.SetError(this.txtMauSo1, "");
            }

            if (int.Parse(txtMauSo2.Text) == 0)
            {
                this.Display();
                this.errorProvider_MS2.SetError(this.txtMauSo2, "Mẫu số phải khác 0");
            }    
            else
            {
                this.ps2.TuSo = int.Parse(txtTuSo2.Text);
                this.ps2.MauSo = int.Parse(txtMauSo2.Text);
                this.errorProvider_MS2.SetError(this.txtMauSo2, "");
            }    
        }
        public void Display()
        {
            this.txtTuSoKQ.Text = psKQ.TuSo.ToString();
            this.txtMauSoKQ.Text= psKQ.MauSo.ToString();
        }        
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            this.checkInput();
            psKQ = ps1.TinhTong(ps2);
            this.Display();
        }
        private void btnTinhHieu_Click(object sender, EventArgs e)
        {
            this.checkInput();
            psKQ = ps1.TinhHieu(ps2);
            this.Display();
        }
        private void btnTinhTich_Click(object sender, EventArgs e)
        {
            this.checkInput();
            psKQ = ps1.TinhTich(ps2);
            this.Display();
        }
        private void btnTinhThuong_Click(object sender, EventArgs e)
        {
            this.checkInput();
            psKQ = ps1.TinhThuong(ps2);
            this.Display();
        }
    }
}
