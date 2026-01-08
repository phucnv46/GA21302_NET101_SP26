namespace TT_HuongDanMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hướng dẫn xây dựng menu trong C#
            // Lap den khi chon thoat
            /* while (true)
             {
                 int luachon = 0;
                 Console.OutputEncoding = System.Text.Encoding.UTF8;
                 Console.WriteLine("---Menu----");
                 Console.WriteLine("1. Nhập xuất");
                 Console.WriteLine("2.Tính toán");
                 Console.WriteLine("3.Gi day");
                 Console.WriteLine("0. Thoat");

                 Console.Write("Mời bạn chọn chức năng: ");
                 int.TryParse(Console.ReadLine(), out luachon);
                 switch (luachon)
                 {
                     case 0:
                         {
                             return;
                         }
                     default: Console.WriteLine("Không có lựa chọn này"); break;
                     case 1:
                         {
                             Console.WriteLine("Case 1");
                             break;
                         }
                     case 2:
                         {
                             Console.WriteLine("Case 2");
                             break;
                         }
                     case 3:
                         {
                             Console.WriteLine("Case 3");
                             break;
                         }
                 }
             }*/
            // lap den khi chua chon thoat
            /* Console.OutputEncoding = System.Text.Encoding.UTF8;
             int luachon;
             do
             {
                 int.TryParse(Console.ReadLine(), out luachon);
                 //...
             }
             while (luachon!=0);*/
            menu:
            int luachon;
            int.TryParse(Console.ReadLine(), out luachon);

            switch (luachon)
            {
               case 0:
                    {
                        return;
                    }
                case 1:
                    {
                        //logic
                        goto menu;
                    }
            }
        }
    }
}
