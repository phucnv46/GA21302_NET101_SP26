using System.Numerics;

namespace NC_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Viết 1 hàm tính tổng của nhiều số sử dụng được cho cả số nguyên lẫn số thực

            Console.WriteLine($"Tổng: {Tong(1, 2, 3, 4, 5.2)}");

        }

        static int TongSoNguyen(params int[] soNguyen)
        {
            int tong = 0;
            foreach (var so in soNguyen)
            {
                tong += so;
            }
            return tong;
        }
        static double TongSoThuc(params double[] soThuc)
        {
            double tong = 0;
            foreach (var so in soThuc)
            {
                tong += so;
            }
            return tong;
        }


        static T Tong<T>(params T[] so) where
            T : struct, INumber<T>
        {
            T tong = T.Zero;

            foreach (var item in so)
            {
               tong += item;
            }
            return tong;
        }
    }
}
