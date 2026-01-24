using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_TruuTuong
{
    internal abstract class Hinh
    {
        public int SoDinh { get; set; }
        public int SoCanh { get; set; }
        abstract public double TinhDienTich();
        abstract public double TinhChuVi();
    }
}
