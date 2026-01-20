using System;
using System.Collections.Generic;
using System.Text;

namespace LT1
{
    internal class SERVICE
    {
        static List<SinhVien> danhSachSV = new List<SinhVien>();


        public static void ThemSinhVien()
        {
            string maSV,tenSv;
            int namSinh;

            Console.Write("Nhập mã sinh viên: ");
            maSV = Console.ReadLine();
            Console.Write("Nhập tên sinh viên: ");
            tenSv = Console.ReadLine();
            checkpoint:
            Console.Write("Nhập năm sinh: ");
            int.TryParse(Console.ReadLine(), out namSinh);

            if (DateTime.Now.Year - namSinh <=18)
            {
                Console.WriteLine("Tuoi cua sinh vien phai lon hon 18!");
                goto checkpoint;
            }

            SinhVien sv = new SinhVien(maSV, tenSv, namSinh);
            danhSachSV.Add(sv);
        }

        public static void HienThiDanhSachSV()
        {
            Console.WriteLine("=====Danh sách sinh viên");
            foreach (var sv in danhSachSV)
            {
                sv.InThongTin();
            }
        }

        public static void TimKiemSVTheoMa()
        {
            Console.Write("Nhập mã sinh viên cần tìm: ");
            string maSV = Console.ReadLine();

            //foreach (var sv in danhSachSV)
            //{
            //    if (sv.MaSV == maSV)
            //    {
            //        sv.InThongTin();
            //        return;
            //    }
            //}
            //Console.WriteLine("Không tìm thấy sinh viên với mã đã cho.");

            //c2
            SinhVien? svTimThay = danhSachSV.Find(sv => sv.MaSV == maSV);
            if (svTimThay != null)
            {
                svTimThay.InThongTin();
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã đã cho.");
            }
        }
    }
}
