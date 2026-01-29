using System;
using System.Collections.Generic;
using System.Text;

namespace LT4
{
    internal class Service
    {
        static List<DienThoai> danhSachDienThoai = new List<DienThoai>();

        public static void NhapDanhSach()
        {
        save2:
            DienThoai dienThoai = new();
            Console.Write("Xin mời nhập Mã điện thoại: ");
            dienThoai.MaDienThoai = Console.ReadLine();
            Console.Write("Xin mời nhập Tên điện thoại: ");
            dienThoai.TenDT = Console.ReadLine();
            Console.Write("Xin mời nhập Hãng điện thoại: ");
            dienThoai.TenDT = Console.ReadLine();
        save1:
            Console.Write("Xin mời nhập giá: ");
            dienThoai.Gia = int.Parse(Console.ReadLine() ?? "0");

            if (!(dienThoai.Gia > 0))
            {
                Console.WriteLine("Giá điện thoại phải lớn hơn 0.");
                goto save1;
            }

        save3:
            Console.Write("Bạn có muốn tiếp tục không(Y/N)?: ");
            string? choice = Console.ReadLine();
            if (choice.ToLower().Equals("y"))
            {
                danhSachDienThoai.Add(dienThoai);
                goto save2;
            }
            else if (choice.ToLower().Equals("n"))
            {
                danhSachDienThoai.Add(dienThoai);
                Console.WriteLine("Tạm biệt!");
                return;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập Y hoặc N.");
                goto save3;
            }
        }

        internal static void XuatDanhSach()
        {
            danhSachDienThoai.ForEach(dt => dt.InThongTin());

            //foreach (var dt in danhSachDienThoai)
            //{
            //    dt.InThongTin();
            //}

        }

    }

}
