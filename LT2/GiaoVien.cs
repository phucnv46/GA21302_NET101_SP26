using System;
using System.Collections.Generic;
using System.Text;

namespace LT2
{
    internal class GiaoVien
    {
        private int id;
        private string ten;
        private double soGioDay;

        public GiaoVien()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }

        public GiaoVien(int id, string ten, double soGioDay)
        {
            this.id = id;
            this.ten = ten;
            this.soGioDay = soGioDay;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {Id}, Tên: {Ten}, Số giờ dạy: {SoGioDay}");
        }
    }
}
