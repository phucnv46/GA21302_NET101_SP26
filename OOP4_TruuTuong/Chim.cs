using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_TruuTuong
{
    internal class Chim : Iflyable,IBornable
    {
        public void De()
        {
            Console.WriteLine("De ra trung");
        }
    
    
        public void Fly()
        {
            Console.WriteLine("Bay bang cach");
        }
    }
}
