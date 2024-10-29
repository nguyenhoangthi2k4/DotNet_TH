using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                int n = int.Parse(this.txtInput.Text);
                if (isPerfectNumber(n))
                    MessageBox.Show(string.Format(n + " là số hoàn hảo"));
                else
                    MessageBox.Show(string.Format(n + " không là số hoàn hảo"));
                errorProvider_Input.SetError(txtInput, "");
            }
            else
                errorProvider_Input.SetError(txtInput, "Nhập giá trị chưa chính xác");

        }
        public bool isPerfectNumber(int n)
        {
            int sum = 0;
            for( int i = 1; i <= (n/2); i++ ) 
                if(n%i == 0)
                    sum += i;
            return sum == n ? true : false;
        }
        public bool checkInput()
        {
            if(this.txtInput.Text == "")
                return false;
            else if (int.TryParse(this.txtInput.Text, out int value) == false)
                return false;
            else 
                return true;
        }
    }
}
