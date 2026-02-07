using System;
using System.Collections.Generic;
using System.Text;

namespace Chua_GD2
{
    internal class ThucPhamDongHop : ThucPham
    {
        private string _hanSuDung;

        public string HanSuDung { get => _hanSuDung; set => _hanSuDung = value; }

        public ThucPhamDongHop()
        {
        }

        public ThucPhamDongHop(string maMon, string tenMon, double donGia, string loaiMon, string hanSuDung)
            : base(maMon, tenMon, donGia, loaiMon)
        {
            HanSuDung = hanSuDung;
        }

        internal override void InThongTin()
        {
            Console.WriteLine($"Mã món: {MaMon}, Tên món: {TenMon}, Đơn giá {DonGia}, Loại món: {LoaiMon}, Hạn sử dụng: {HanSuDung}");

        }
    }
}
