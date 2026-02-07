namespace Chua_GD2
{
    internal class ThucPham
    {
        private string _maMon;
        private string _tenMon;
        private double _donGia;
        private string _loaiMon;

        public ThucPham()
        {
        }

        public ThucPham(string maMon, string tenMon, double donGia, string loaiMon)
        {
            MaMon = maMon;
            TenMon = tenMon;
            DonGia = donGia;
            LoaiMon = loaiMon;
        }

        public string MaMon { get => _maMon; set => _maMon = value; }
        public string TenMon { get => _tenMon; set => _tenMon = value; }
        public double DonGia { get => _donGia; set => _donGia = value; }
        public string LoaiMon { get => _loaiMon; set => _loaiMon = value; }

        internal virtual void InThongTin() // từ khoá để xác định con sẽ đột biến
        {
            Console.WriteLine($"Mã món: {MaMon}, Tên món: {TenMon}, Đơn giá {DonGia}, Loại món: {LoaiMon}");
           
        }

    }
}
