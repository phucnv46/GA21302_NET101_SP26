using System;
using System.Collections.Generic;
using System.Text;

namespace LT2
{
    internal class GiaoVienPoly : GiaoVien
    {
        private string nganhDay;

        public string NganhDay { get => nganhDay; set => nganhDay = value; }


        public GiaoVienPoly()
        {
        }

        public GiaoVienPoly(int id, string ten, double soGioDay) : base(id, ten, soGioDay)
        {
        }

        public override void InThongTin()
        {
            Console.WriteLine($"ID: {Id}, Tên: {Ten}, Số giờ dạy: {SoGioDay}, Ngành dạy: {NganhDay}");
        }
    }
}
