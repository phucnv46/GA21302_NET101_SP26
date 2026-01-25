using System;
using System.Collections.Generic;
using System.Text;

namespace LT3
{
    internal class HocVien
    {
        private int maHV;
        private string hoTen;
        private double diemTB;

        public HocVien()
        {
        }

        public int MaHV { get => maHV; set => maHV = value; }

        public string HoTen { get => hoTen; set => hoTen = value; }

        public double DiemTB { get => diemTB; set => diemTB = value; }

        public HocVien(int maHV, string hoTen, double diemTB)
        {
            MaHV = maHV;
            HoTen = hoTen;
            DiemTB = diemTB;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"Mã học viên: {MaHV}, Họ tên: {HoTen}, Điểm trung bình: {DiemTB}");
        }
    }
}
