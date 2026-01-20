using System;

namespace LT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                int luaChon;
                Console.WriteLine("1.Nhập thông tin đối tượng." +
                    "\r\n2.Hiển thị danh sách đối tượng." +
                    "\r\n3.Tìm kiếm sinh viên theo mã." +
                    "\r\n5.Kế thừa." +
                    "\r\n0.Thoát.");
                Console.Write("Lựa chọn của bạn: ");
                int.TryParse(Console.ReadLine(), out luaChon);

                switch (luaChon)
                {
                    case 0:
                        Console.WriteLine("Thoát");
                        return;
                    case 1:
                        {
                            SERVICE.ThemSinhVien();
                            break;
                        }
                    case 2:
                        {
                            SERVICE.HienThiDanhSachSV();
                            break;
                        }
                    case 3:
                        {
                            SERVICE.TimKiemSVTheoMa();
                            break;
                        }
                    case 5:
                        {
                            // Khởi tạo SinhVienUDPM bằng constructor có tham số và in thông tin
                            var svUdpm = new SinhVienUDPM("UD001", "Nguyễn Văn A", 2000, 8.5, 9.0);
                            svUdpm.InThongTin();
                            break;
                        }
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                        break;
                }
            }
        }
    }
}
