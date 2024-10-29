using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class PhanSo
    {
        private int _tuSo, _mauSo;

        public PhanSo()
        {
            _tuSo = 0;
            _mauSo = 1;
        }

        public int TuSo { get => _tuSo; set => _tuSo = value; }
        public int MauSo
        {
            get
            {
                return _mauSo;
            }
            set
            {
                if (value != 0)
                    _mauSo = value;                
            }
        }
        public void RutGon()
        {
            int a = this.TuSo;
            int b = this.MauSo;
            while(b!=0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            this.TuSo /= a;
            this.MauSo /= a;
        }
        public PhanSo TinhTong(PhanSo ps)
        {
            PhanSo tmp = new PhanSo();
            tmp.TuSo = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
            tmp.MauSo = this.MauSo * ps.MauSo;
            tmp.RutGon();
            return tmp;
        }

        public PhanSo TinhHieu(PhanSo ps)
        {
            PhanSo tmp = new PhanSo();
            tmp.TuSo = this.TuSo * ps.MauSo - ps.TuSo * this.MauSo;
            tmp.MauSo = this.MauSo * ps.MauSo;
            tmp.RutGon();
            return tmp;
        }

        public PhanSo TinhTich(PhanSo ps)
        {
            PhanSo tmp = new PhanSo();
            tmp.TuSo = this.TuSo * ps.TuSo ;
            tmp.MauSo = this.MauSo * ps.MauSo;
            tmp.RutGon();
            return tmp;
        }

        public PhanSo TinhThuong(PhanSo ps)
        {
            PhanSo tmp = new PhanSo();
            tmp.TuSo = this.TuSo * ps.MauSo;
            tmp.MauSo = this.MauSo * ps.TuSo;
            tmp.RutGon();
            return tmp;
        }
    }
}
