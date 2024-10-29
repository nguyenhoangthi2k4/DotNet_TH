using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public int[] arr = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void rdTaoMangNN_CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            string strMang = "";
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = random.Next(100);
                strMang += " " + this.arr[i];
            }
            txtMangGoc.Text = strMang;
        }

        private void rdTimMin_CheckedChanged(object sender, EventArgs e)
        {
            int min = this.arr[0];
            for(int i=0; i< this.arr.Length; i++) 
                if (min > this.arr[i]) 
                    min = this.arr[i];
            txtKetQua.Text = "Min = " + min.ToString();
        }

        private void rdLKSoChan_CheckedChanged(object sender, EventArgs e)
        {
            string strChan = "";
            for(int i = 0;i< this.arr.Length;i++)
                if (this.arr[i] % 2 == 0)
                    strChan += " " + this.arr[i];
            txtKetQua.Text ="Các phần tử chẵn: " + strChan;
        }

        private void rdTongChan_CheckedChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i< this.arr.Length; i++) 
                if(this.arr[i] % 2 == 0)
                    sum += this.arr[i];
            txtKetQua.Text = "Tổng các số chẵn = " + sum.ToString();
        }

        private void rdTongLe_CheckedChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < this.arr.Length; i++)
                if (this.arr[i] % 2 == 1)
                    sum += this.arr[i];
            txtKetQua.Text = "Tổng các số lẻ = " + sum.ToString();
        }

        private void rdDemSoChan_CheckedChanged(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < this.arr.Length; i++)
                if (this.arr[i] % 2 == 0)
                    count ++;
            txtKetQua.Text = "Mảng có = " + count.ToString() + " số chẵn";
        }

        private void rdDemSoLe_CheckedChanged(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < this.arr.Length; i++)
                if (this.arr[i] % 2 == 1)
                    count++;
            txtKetQua.Text = "Mảng có = " + count.ToString() + " số lẻ";
        }

        private void rdTimSoChan_CheckedChanged(object sender, EventArgs e)
        {
            int soChanCC = -1;
            for(int i = 0;i < this.arr.Length;i++)
                if (this.arr[i] % 2 == 0)
                    soChanCC = this.arr[i];
            txtKetQua.Text = "Số chẵn cuối cùng là: " + soChanCC.ToString();
        }

        private void rdHuy_CheckedChanged(object sender, EventArgs e)
        {
            txtMangGoc.Text = string.Empty;
            txtKetQua.Text= string.Empty;
            arr = new int[this.arr.Length];
        }
    }
}
