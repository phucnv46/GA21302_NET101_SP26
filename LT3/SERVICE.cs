using System;
using System.Collections.Generic;
using System.Text;

namespace LT3
{
    internal class SERVICE
    {
        static List<HocVien> danhSachHocVien = new List<HocVien>();

        internal static void NhapThongTin()
        {
            int maHV;
            string hoTen;
            double diemTB;

            Console.Write("Nhập mã học viên: ");
            int.TryParse(Console.ReadLine(), out maHV);

            Console.Write("Nhập họ tên học viên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhập điểm trung bình: ");
            double.TryParse(Console.ReadLine(), out diemTB);

            HocVien hocVien = new HocVien(maHV, hoTen, diemTB);
            danhSachHocVien.Add(hocVien);
        }


        internal static void HienThiDanhSach()
        {
            foreach (var hocVien in danhSachHocVien)
            {
                hocVien.InThongTin();
            }
        }


        internal static void TimKiemTheoMa()
        {
            int maHV;
            Console.Write("Nhập mã học viên cần tìm: ");
            int.TryParse(Console.ReadLine(), out maHV);

            HocVien hocVienCanTim = null; 

            foreach (var hocVien in danhSachHocVien)
            {
                if (hocVien.MaHV == maHV)
                {
                    hocVienCanTim = hocVien;
                    hocVienCanTim.InThongTin();
                    return;
                }
            }

           if(hocVienCanTim is  null)
           {
                Console.WriteLine("Không tìm thấy học viên với mã đã cho.");
           }
           

        }


        internal static void KeThua()
        {
            HocVienChuyenNganh hvcn = new HocVienChuyenNganh() { MaHV=21, HoTen="Phúc", DiemTB=8.5, TenChuyenNganh="Thiết kế đồ hoạ" };
            hvcn.InThongTin() ;
        }
    }
}
