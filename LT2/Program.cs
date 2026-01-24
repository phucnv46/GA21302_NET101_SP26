namespace LT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SERVICE service = new SERVICE();

            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int luaChon;
                Console.WriteLine("----- Quản Lý Giáo Viên -----");
                Console.WriteLine("1.Nhập thông tin đối tượng." +
                    "\r\n2.Hiển thị danh sách đối tượng." +
                    "\r\n3.Xóa đối tượng theo ID." +
                    "\r\n4.Thoát.");
                Console.WriteLine("5.Kế thừa");
                Console.Write("Chọn chức năng: ");
                int.TryParse(Console.ReadLine(), out luaChon);


                switch (luaChon)
                {

                    case 4: return;
                    default:
                        {
                            Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                            break;
                        }
                    case 1:
                        {
                            service.NhapThongTinGiaoVien();
                            break;
                        }
                    case 2:
                        {
                            service.HienThiDanhSachGiaoVien();
                            break;
                        }
                    case 3:
                        {
                            service.XoaGiaoVienTheoID();
                            break;
                        }
                    case 5:
                        {
                            GiaoVienPoly giaoVienPoly = new GiaoVienPoly() { 
                                Id = 1, NganhDay = "Công nghệ thông tin",Ten= "Nguyễn Văn A",
                                SoGioDay = 30

                            };

                            giaoVienPoly.InThongTin();

                            break;
                        }
                }
            }
        }
    }
}
