using System;
using System.Collections.Generic;
using System.Text;

namespace LT4
{
    internal class DienThoai
    {
        private string? maDienThoai;
        private string? tenDT;
        private string? hangSX;
        private int gia;

        public DienThoai()
        {
        }

        //prop + tab => auto property
        // to hop ctrl+. hoac alt+enter de convert to full property
        public string? MaDienThoai { get => maDienThoai; set => maDienThoai = value; }
        public string? TenDT { get => tenDT; set => tenDT = value; }
        public string? HangSX { get => hangSX; set => hangSX = value; }

        public int Gia { get => gia; set => gia = value; }

        public DienThoai(string? maDienThoai, string? tenDT, string? hangSX, int gia)
        {
            MaDienThoai = maDienThoai;
            TenDT = tenDT;
            HangSX = hangSX;
            Gia = gia;
        }

        internal void InThongTin()
        {
            // Dung $ de co the chen bien vao chuoi
            Console.WriteLine($"Mã điện thoại: {MaDienThoai}, Tên điện thoại: {TenDT}, Giá: {Gia} ,Hãng sản xuất: {HangSX}");

        }
    }
}
