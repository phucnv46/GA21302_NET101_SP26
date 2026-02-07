using System;
using System.Collections.Generic;
using System.Text;

namespace Chua_GD2
{
    internal class Service
    {
        static List<ThucPham> danhSachThucPham = new List<ThucPham>();

        internal static void ThemThucPham()
        {
        cp1:
            ThucPham thucPhamMoi = new ThucPham();
            Console.Write("Xin mời nhập mã: ");
            thucPhamMoi.MaMon = Console.ReadLine() ?? "Mã trống";
            Console.Write("Xin mời nhập tên: ");
            thucPhamMoi.TenMon = Console.ReadLine() ?? "Tên trống";


            while (true)
            {
                Console.Write("Xin mời nhập đơn giá: ");
                if (double.TryParse(Console.ReadLine(), out double gia) && gia > 0)
                {
                    thucPhamMoi.DonGia = gia;
                    break;

                }
                Console.Write("Đơn giá không hợp lệ!\n");
            }

            Console.Write("Xin mời nhập loại món: ");
            thucPhamMoi.LoaiMon = Console.ReadLine() ?? "Loại món trống";

            danhSachThucPham.Add(thucPhamMoi);

            string? tiepTuc;
            do
            {
                Console.Write("Tiếp tục hơm (Y/N): ");
                tiepTuc = Console.ReadLine().Trim().ToUpper() ?? "A";
                if (tiepTuc.Equals("Y"))
                {
                    goto cp1;
                }
                else if (tiepTuc.Equals("N"))
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn Y hoặc N!");
                }
            } while (tiepTuc.Equals("Y") || tiepTuc.Equals("N"));

        }

        internal static void HienThiDanhSach()
        {
            Console.WriteLine("Danh sách thực phẩm:");
            foreach (var thucPham in danhSachThucPham)
            {
                thucPham.InThongTin();
            }
        }


        internal static void TimMonAnTheoDonGia()
        {
            double min, max;
            Console.Write("Xin mời nhập min: ");
            double.TryParse(Console.ReadLine(), out min);
            Console.Write("Xin mời nhập max: ");
            double.TryParse(Console.ReadLine(), out max);

            Console.WriteLine($"Danh sách thực phẩm có đơn giá từ {min} đến {max}:");
            //foreach (var thucPham in danhSachThucPham)
            //{
            //    if (thucPham.DonGia >= min && thucPham.DonGia <= max)
            //    {
            //        thucPham.InThongTin();
            //    }
            //}

            danhSachThucPham
                .FindAll(tp => tp.DonGia >= min && tp.DonGia <= max)
                .ForEach(tp => tp.InThongTin());
        }


        internal static void KhoiTao()
        {
            ThucPhamDongHop thucPhamDongHop = new ThucPhamDongHop(maMon: "DHHL", donGia: 30_000f,
                tenMon: "Pate cột đèn", hanSuDung: "30ngay", loaiMon: "pate");

            thucPhamDongHop.InThongTin();
        }

    }
}
