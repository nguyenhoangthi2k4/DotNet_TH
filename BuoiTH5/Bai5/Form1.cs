using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public int[] arr = new int[25];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatPT_Click(object sender, EventArgs e)
        {
            string strArr = "";
            Random random = new Random();
            for (int i = 0; i < this.arr.Length; i++)
            {                
                int num = random.Next(-100, 100); 
                this.arr[i] = num;
                strArr += " " + this.arr[i].ToString();
            }
            this.txtMangGoc.Text = strArr;
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < this.arr.Length; i++)
                sum += this.arr[i];
            this.txtOutPut.Text = "Tổng mảng = " + sum.ToString();
        }

        private void btnTangGT2_Click(object sender, EventArgs e)
        {
            string strArr = "";
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] += 2;
                strArr += " " + this.arr[i].ToString();
            }
            this.txtMangGoc.Text = strArr;
        }

        private void btnDemPTLe_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < this.arr.Length; i++)
                if (this.arr[i] % 2 == 1)
                    count++;
            this.txtOutPut.Text = "Số phần tử lẻ = " + count.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < this.arr.Length; i++)
                if (this.arr[i] % 2 == 1)
                    sum += this.arr[i];
            this.txtOutPut.Text = "Tổng các phần tử lẻ = " + sum.ToString();
        }

        private void btnTimMin_Click(object sender, EventArgs e)
        {
            int min = this.arr[0];
            for (int i = 0;i < this.arr.Length;i++)
                if (min > this.arr[i])
                    min = this.arr[i];
            this.txtOutPut.Text = "Min = " + min.ToString();
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            string strArr = "";
            for (int i = 0; i < this.arr.Length; i++)
                strArr +=" " + arr[i].ToString();
            this.txtMangGoc.Text = strArr;
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            string strArr = "";
            for (int i = 0; i < this.arr.Length; i++)
                strArr +=" " + arr[i].ToString();
            this.txtMangGoc.Text =" " + strArr;
        }
    }
}
