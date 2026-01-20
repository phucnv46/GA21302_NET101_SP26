using System;

namespace LT1
{
    internal class SinhVienUDPM : SinhVien
    {
        private double diemJava;
        private double diemCsharp;

        public double DiemJava { get => diemJava; set => diemJava = value; }
        public double DiemCsharp { get => diemCsharp; set => diemCsharp = value; }

        public SinhVienUDPM()
        {
        }

        public SinhVienUDPM(string maSV, string ten, int namSinh, double diemJava, double diemCsharp)
            : base(maSV, ten, namSinh)
        {
            DiemJava = diemJava;
            DiemCsharp = diemCsharp;
        }

        // K? th?a (che khu?t) ph??ng th?c InThongTin c?a l?p cha và b? sung ?i?m
        public new void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"?i?m Java: {DiemJava}, ?i?m C#: {DiemCsharp}");
        }
    }
}