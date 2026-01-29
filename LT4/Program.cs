namespace LT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                int luaChon;
                Console.WriteLine("--------Menu-------");
                Console.WriteLine("1.Nhập danh sách ");
                Console.WriteLine("2.Xuất danh sách ");
                Console.WriteLine("3.Tìm sản phẩm theo giá");
                Console.WriteLine("4.Thoát");
                Console.WriteLine("5.Kế thừa");
                Console.Write("Xin mời nhập lựa chọn: ");
                int.TryParse(Console.ReadLine(), out luaChon);

                switch (luaChon)
                {
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                    case 4:
                        Console.WriteLine("Tạm biệt");
                        return;
                    case 1:
                        {
                            Service.NhapDanhSach();
                            break;
                        }
                    case 2:
                        {
                            Service.XuatDanhSach();
                            break;
                        }

                }
            }
        }
    }
}
