using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_KeThua
{
    internal class XeMay : PhuongTien
    {
        public void DuaChan()
        {
            Console.WriteLine($"{Ten} đưa chân chống lên");
        }

        public new void DiChuyen()
        {
            base.DiChuyen();
            Console.WriteLine($"Xe may dang om cua");
        }
    }
}
