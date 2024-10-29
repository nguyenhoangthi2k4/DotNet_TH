using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public int[] arr = new int[100];
        public int soPT = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();            
        }
        public void TachChuoi(string input)
        {            
            int i = 0;
            string[] element = input.Trim().Split(new char[] {' '});
            for(i = 0; i < element.Length; i++)
            {
                if (int.TryParse(element[i], out int value) == true)
                    this.arr[soPT++] = value;
                else
                {
                    this.soPT = 0;
                    MessageBox.Show("Nhập giá trị không hợp lệ");
                    txtNhapMang.Text = string.Empty;
                    txtNhapMang.Focus();                    
                    arr = new int[100];
                }
            }           
        }  
        public void inMang()
        {
            string strMang = "";
            for (int i = 0; i < this.soPT; i++)
                strMang += this.arr[i] + " ";
            txtKetQua.Text = strMang;
        }
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            this.TachChuoi(txtNhapMang.Text);
            this.inMang();
        }
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sum = 0, sumLe = 0, sumChan = 0;
            for (int i = 0; i < this.soPT;i++)
            {
                sum += this.arr[i];
                if (this.arr[i] % 2 == 0) 
                    sumChan += this.arr[i];
                else
                    sumLe += this.arr[i];               
            }
            txtTongMang.Text = sum.ToString();
            txtTongChan.Text = sumChan.ToString();
            txtTongLe.Text = sumLe.ToString();
        }
        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            int max = this.arr[0];
            int min = this.arr[0];
            for(int i = 0;i < this.soPT;i++)
            {
                if(max <  this.arr[i])
                    max = this.arr[i];
                if(min > this.arr[i])
                    min = this.arr[i];
            }    
            this.txtMax.Text = max.ToString();
            this.txtMin.Text = min.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if(this.rdSXTang.Checked)
            {
                for (int i = 0; i < this.soPT;i++)
                    for(int j = i; j <= this.soPT - 1;j++)
                        if (this.arr[i] > this.arr[j])
                        {
                            int tmp = this.arr[i];
                            this.arr[i] = this.arr[j];
                            this.arr[j] = tmp;
                        }
                this.inMang();
            }
            if(this.rdSXGiam.Checked)
            {
                for (int i = 0; i < this.soPT; i++)
                    for (int j = i; j <= this.soPT - 1; j++)
                        if (this.arr[i] < this.arr[j])
                        {
                            int tmp = this.arr[i];
                            this.arr[i] = this.arr[j];
                            this.arr[j] = tmp;
                        }
                this.inMang();
            }
        }
        public bool checkThayThe()
        {
            if (int.TryParse(txtGiaTri.Text, out int gt) == true && int.TryParse(txtViTri.Text, out int vt) == true)
            {
                if (vt >= 1 && vt <= this.soPT)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }
        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (checkThayThe())
            {
                int gt = int.Parse(this.txtGiaTri.Text);
                int vt = int.Parse(this.txtViTri.Text);
                this.arr[vt-1]= gt;
                this.inMang();

                this.txtTongChan.Text = string.Empty;
                this.txtTongLe.Text = string.Empty;
                this.txtTongMang.Text = string.Empty;
                this.txtMax.Text = string.Empty;
                this.txtMin.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Nhập giá trị không chính xác");
                this.txtGiaTri.Text = string.Empty;
                this.txtViTri.Text = string.Empty;
                this.txtGiaTri.Focus();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.arr = new int[100];
            this.soPT = 0;
            this.txtNhapMang.Text = string.Empty;
            this.txtKetQua.Text = string.Empty; 
            this.txtTongChan.Text = string.Empty;
            this.txtTongLe.Text = string.Empty;
            this.txtTongMang.Text = string.Empty;
            this.txtMax.Text = string.Empty;
            this.txtMin.Text = string.Empty;
            this.txtGiaTri.Text= string.Empty;
            this.txtViTri.Text= string.Empty;
        }
    }
}
