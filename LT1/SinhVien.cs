using System;
using System.Collections.Generic;
using System.Text;

namespace LT1
{
    internal class SinhVien
    {
        private string maSV;
        private string ten;
        private int namSinh;

        public SinhVien()
        {
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public SinhVien(string maSV, string ten, int namSinh)
        {
            MaSV = maSV;
            Ten = ten;
            NamSinh = namSinh;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSV}, Tên: {Ten}, Năm sinh: {NamSinh}");
        }
    }
}
