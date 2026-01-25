using System;
using System.Collections.Generic;
using System.Text;

namespace LT3
{
    internal class HocVienChuyenNganh : HocVien
    {
        private string tenChuyenNganh;

        public HocVienChuyenNganh()
        {
        }

        public HocVienChuyenNganh(int maHV, string hoTen, double diemTB) : base(maHV, hoTen, diemTB)
        {
        }

        public string TenChuyenNganh { get => tenChuyenNganh; set => tenChuyenNganh = value; }

        public override void InThongTin()
        {
            Console.WriteLine($"Mã Học viên: {MaHV}, Họ tên: {HoTen},điểm trung bình: {DiemTB}, Chuyên ngành:{TenChuyenNganh}");
        }
    }
}
