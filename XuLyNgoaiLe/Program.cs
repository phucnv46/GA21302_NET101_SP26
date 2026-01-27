namespace XuLyNgoaiLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMax(3, 2, 6, 7.21, 421.2,2);

        }


        // Yeu viet 1 ham tim so lon nhat cua cac tham so truyen vao
        // Viet 1 ham khong gioi han so lunog tham so cung loai

        static void FindMax(params double[] mangSo)
        {
            double max = mangSo[0];

            foreach (var so in mangSo)
            {
                if (so > max) max = so;
            }

            Console.WriteLine($"Vay so lon nhat la {max}");

        }


    }
}
