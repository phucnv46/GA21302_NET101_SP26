namespace Chua_GD2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // in được tiếng việt
            Console.InputEncoding = System.Text.Encoding.UTF8;  // đọc được tiếng việt


            for (; ; )
            {
                int luaChon;
                Console.WriteLine("1.Nhập thông tin thực phẩm");
                Console.WriteLine("2.Hiển thị danh sách");
                Console.WriteLine("3.Tìm món ăn theo đơn giá");
                Console.WriteLine("4.Thoát");
                Console.Write("Lựa chọn của bạn: ");
                int.TryParse(Console.ReadLine(), out luaChon); // abc = 0 => default

                switch (luaChon)
                {
                    case 4:
                        return;
                    default:
                        int a;
                        Console.WriteLine("Lựa chọn sai");
                        break;
                    case 1:
                        Service.ThemThucPham();
                        break;
                    case 2:
                        Service.HienThiDanhSach();
                        break;
                    case 3:
                        Service.TimMonAnTheoDonGia();
                        break;
                    case 5:
                        Service.KhoiTao();
                        break;
                }
            }
        }
    }
}
