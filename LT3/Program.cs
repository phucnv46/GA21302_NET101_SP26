namespace LT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                int luaChon;
                Console.WriteLine("________________Menu________________");
                Console.WriteLine("1.Nhập thông tin");
                Console.WriteLine("2.Hien thị danh sách");
                Console.WriteLine("3.Tìm kiếm theo mã");
                Console.WriteLine("4.Thoát");
                Console.WriteLine("5.Kế thừa");
                Console.Write("Mời bạn chọn: ");
                int.TryParse(Console.ReadLine(), out luaChon);

                // Switch case to handle user choices

                switch (luaChon)
                {
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                    case 4:
                        {
                            Console.WriteLine("Thoát chương trình");
                            return;
                        }
                    case 1:
                        {
                            SERVICE.NhapThongTin();
                            break;
                        }
                    case 2:
                        {
                            SERVICE.HienThiDanhSach();
                            break;
                        }
                    case 3:
                        {
                            SERVICE.TimKiemTheoMa();
                            break;
                        }
                    case 5:
                        {
                            SERVICE.KeThua();
                            break;
                        }
                }
            }
        }
    }
}
