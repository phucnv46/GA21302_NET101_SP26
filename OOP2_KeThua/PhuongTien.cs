using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_KeThua
{
    internal class PhuongTien
    {
        public string Ten { get; set; }

        public int NamSX { get; set; }

        public string HangSX { get; set; }

        public double MaLuc { get; set; }

        public string BienSo { get; set; }

        public void KhoiDong()
        {
            Console.WriteLine($"{Ten} khởi động");
        }

        public void TangToc()
        {
            Console.WriteLine($"{Ten} tăng tốc");
        }


        public void DiChuyen()
        {
            Console.WriteLine($"{Ten} di chuyển");
        }
    }
}
