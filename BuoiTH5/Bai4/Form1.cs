using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.rdHinhTron.Checked = true;
            this.grbHinhTron.Visible = true;
            this.grbHinhVuong.Visible = false;
            this.grbHTG.Visible = false;
            this.grbHCN.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdHinhTG_Click(object sender, EventArgs e)
        {
            this.grbHinhTron.Visible = false;
            this.grbHinhVuong.Visible = false;
            this.grbHTG.Visible = true;
            this.grbHCN.Visible = false;            
        }

        private void rdHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            this.grbHinhTron.Visible = true;
            this.grbHinhVuong.Visible = false;
            this.grbHTG.Visible = false;
            this.grbHCN.Visible = false;
        }

        private void rdHinhVuong_CheckedChanged(object sender, EventArgs e)
        {           
            this.grbHinhTron.Visible = false;
            this.grbHinhVuong.Visible = true;
            this.grbHTG.Visible = false;
            this.grbHCN.Visible = false;            
        }

        private void rdHinhCN_CheckedChanged(object sender, EventArgs e)
        {
            this.grbHinhTron.Visible = false;
            this.grbHinhVuong.Visible = false;
            this.grbHTG.Visible = false;
            this.grbHCN.Visible = true;
        }

        public bool checkInput(params string[] input)
        {
            // Kiểm tra các input 
            for(int i = 0; i< input.Length; i++)
            {
                if (input[i] == " ")
                    return false; // input chưa nhập
                else if (float.TryParse(input[i], out float value) == false)
                    return false; // input không là số
                else if (value <= 0)
                    return false;
            }    
            return true;
        }

        public void TinhHinhTron()
        {
            if(checkInput(this.txtBanKinh.Text))
            {
                double r = double.Parse(this.txtBanKinh.Text);
                double cv = 2 * 3.14 * r;
                double dt = 3.14 * r * r;
                txtCVHT.Text = cv.ToString();
                txtDTHT.Text = dt.ToString();
            }
            else
            {
                MessageBox.Show("Nhập giá trị không hợp lệ!");               
                this.txtBanKinh.Text = "";
                this.txtBanKinh.Focus();
            }
        }

        public void TinhHinhCN()
        {
            if (checkInput(this.txtChieuDai.Text, this.txtChieuRong.Text))
            {
                double cd = double.Parse(this.txtChieuDai.Text);
                double cr = double.Parse(this.txtChieuRong.Text);
                double cv = (cd + cr) * 2;
                double dt = cd * cr;
                txtCVHCN.Text = cv.ToString();
                txtDTHCN.Text = dt.ToString();
            }
            else
            {
                MessageBox.Show("Nhập giá trị không hợp lệ!");               
                this.txtChieuDai.Text = "";
                this.txtChieuRong.Text = "";
                this.txtChieuDai.Focus();
            }
        }

        public void TinhHinhVuong()
        {
            if (checkInput(this.txtCanh.Text))
            {
                double canh = double.Parse(this.txtCanh.Text);
                double cv = canh * 4;
                double dt = canh * canh;
                txtCVHV.Text = cv.ToString();
                txtDTHV.Text = dt.ToString();
            }
            else
            {
                MessageBox.Show("Nhập giá trị không hợp lệ!");
                this.txtCanh.Text = "";
                this.txtCanh.Focus();
            }
        }

        public void TinhHinhTG()
        {
            if (checkInput(this.txtCanhA.Text, this.txtCanhB.Text, this.txtCanhC.Text))
            {
                double a = double.Parse(this.txtCanhA.Text);
                double b = double.Parse(this.txtCanhB.Text);
                double c = double.Parse(this.txtCanhC.Text);
                if (a+b > c && a+c > b && b+c > a)
                {
                    double cv = a + b + c;
                    double p = cv / 2;
                    double dt = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                    txtCVHTG.Text = cv.ToString();
                    txtDTHTG.Text = dt.ToString();
                }
                else
                {
                    MessageBox.Show("3 cạnh không tạo thành tam giác!");
                    this.txtCanhA.Text = "";
                    this.txtCanhB.Text = "";
                    this.txtCanhC.Text = "";
                    this.txtCanhA.Focus();
                }    
            }
            else
            {
                MessageBox.Show("Nhập giá trị không hợp lệ!");
                this.txtCanhA.Text = "";
                this.txtCanhB.Text = "";
                this.txtCanhC.Text = "";
                this.txtCanhA.Focus();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (this.rdHinhTron.Checked == true)
                this.TinhHinhTron();
            else if (this.rdHinhCN.Checked == true)
                this.TinhHinhCN();
            else if (this.rdHinhVuong.Checked == true)
                this.TinhHinhVuong();
            else
                this.TinhHinhTG();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtBanKinh.Text = string.Empty;
            this.txtCanh.Text = string.Empty;
            this.txtCanhA.Text= string.Empty;
            this.txtCanhB.Text = string.Empty;
            this.txtCanhC.Text= string.Empty;
            this.txtChieuDai.Text = string.Empty;
            this.txtChieuRong.Text = string.Empty;
            this.txtCVHCN.Text = string.Empty;
            this.txtDTHCN.Text = string.Empty;
            this.txtCVHT.Text = string.Empty;
            this.txtDTHT.Text = string.Empty;
            this.txtCVHTG.Text = string.Empty;
            this.txtDTHTG.Text = string.Empty;
            this.txtCVHV.Text = string.Empty;
            this.txtDTHV.Text = string.Empty;
        }
    }
}
