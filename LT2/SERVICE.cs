using System;
using System.Collections.Generic;
using System.Text;

namespace LT2
{
    internal class SERVICE
    {
        List<GiaoVien> danhSachGiaoVien;

        public SERVICE()
        {
            danhSachGiaoVien = new List<GiaoVien>() {
           new GiaoVien(1, "Nguyen Van A", 120),
          };
        }

        internal void HienThiDanhSachGiaoVien()
        {
            foreach (GiaoVien gv in danhSachGiaoVien)
            {
                gv.InThongTin();
            }
        }

        internal void NhapThongTinGiaoVien()
        {
            //id, ten, soGioDay
            //GiaoVien giaoVien = new GiaoVien();
            //Console.Write("Nhap ID giao vien: ");   
            //giaoVien.Id = int.Parse(Console.ReadLine());
            //Console.Write("Nhap ten giao vien: ");
            //giaoVien.Ten = Console.ReadLine();
            //Console.Write("Nhap so gio day: ");
            //giaoVien.SoGioDay = double.Parse(Console.ReadLine());

            int id;
            string ten;
            double soGioDay;
            Console.Write("Nhap ID giao vien: ");
            int.TryParse(Console.ReadLine(), out id);
            Console.Write("Nhap ten giao vien: ");
            ten = Console.ReadLine() ?? "Chưa rõ";
            Console.Write("Nhap so gio day: ");
            double.TryParse(Console.ReadLine(), out soGioDay);

            GiaoVien giaoVien = new GiaoVien(id, ten, soGioDay);
            danhSachGiaoVien.Add(giaoVien);
        }

        internal void XoaGiaoVienTheoID()
        {
            int id;
            GiaoVien? giaoVienCanXoa = null;
            Console.Write("Nhap ID giao vien can xoa: ");
            int.TryParse(Console.ReadLine(), out id);

            foreach (var gv in danhSachGiaoVien)
            {
                if (gv.Id == id)
                {
                    giaoVienCanXoa = gv;
                    danhSachGiaoVien.Remove(gv);
                    Console.WriteLine("Xoa giao vien thanh cong.");
                    HienThiDanhSachGiaoVien();
                    return;
                }
            }



            if (giaoVienCanXoa == null)
            {
                Console.WriteLine("Khong tim thay ID can xoa.");
            }
         


            //C2: LinQ
            //int id;
            //Console.Write("Nhap ID giao vien can xoa: ");
            //int.TryParse(Console.ReadLine(), out id);

            //GiaoVien? giaoVienCanXoa = danhSachGiaoVien.Find(gv => gv.Id == id);

            //if(giaoVienCanXoa != null)
            //{
            //    danhSachGiaoVien.Remove(giaoVienCanXoa);
            //    Console.WriteLine("Xoa giao vien thanh cong.");
            //}
            //else
            //{
            //    Console.WriteLine("Khong tim thay ID can xoa.");
            //}
        }
    }
}
