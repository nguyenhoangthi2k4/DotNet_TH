using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (this.check_input())
            {
                int n = int.Parse(this.txtInput.Text);
                string lstSNT = "";
                if (isPrime(n))
                    this.txtKiemTra.Text = this.txtInput.Text + " là số nguyên tố";
                else
                    this.txtKiemTra.Text = this.txtInput.Text + " không là số nguyên tố";
                for (int i = 2; i < n; i++)
                    if (isPrime(i))
                        lstSNT += i + " ";
                this.txtLstSNT.Text = lstSNT;
                errorProvider_checkInput.SetError(txtInput, "");
            }
            else
                errorProvider_checkInput.SetError(txtInput, "Giá trị nhập chưa chính xác");
        }

        private bool isPrime(int n)
        {
            if (n <2)
                return false;
            for( int i = 2; i<=Math.Sqrt(n); i++ ) 
                if (n % i == 0)
                    return false;
            return true;
        }

        private bool check_input()
        {
            if (this.txtInput.Text == "")
                return false;
            if (int.TryParse(this.txtInput.Text, out int value)==false)
                return false;
            return true;
        }  
    }
}
