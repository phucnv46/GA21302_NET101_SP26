namespace OOP3_DaHinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
            TinhTong(1, 2.5);

            Xemay xm = new Xemay();
            xm.ThongTin();
        }

        //Overriding, overload

        // Overloading
        // Cac phuong thuc cung ten nhung khac nhau ve tham so hoac kieu tra ve

        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static double TinhTong(double a, double b)
        {
            return a + b;
        }

        static int TinhTong(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
