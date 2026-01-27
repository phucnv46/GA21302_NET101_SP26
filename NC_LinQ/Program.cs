using System.Text.Json;

namespace NC_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // LinQ : Ngôn ngữ truy vấn tích hợp

            List<int> numbers = new List<int>() { 3, 5, 1, -2, 8, -9 };

            Console.WriteLine("So lon nhat trong mang la {0}", numbers.Max(x => x));
            // Tim phan tu theo dieu kien
            int soCanTim = numbers.Last(x => x < 8); // trả về object
            Console.WriteLine($"Vay so can tim la {soCanTim}");

            List<SinhVien> sinhViens = new List<SinhVien>() {
                new SinhVien(){MSV=1,HoTen="Sinh Vien1",DiaChi="Ha Noi1"},
                new SinhVien(){MSV=2,HoTen="Sinh Vien2",DiaChi="Ha Noi2"},
                new SinhVien(){MSV=3,HoTen="Sinh Vien3",DiaChi="Ha Noi1"},
                new SinhVien(){MSV=4,HoTen="Sinh Vien4",DiaChi="Ha Noi1"},
                new SinhVien(){MSV=5,HoTen="Sinh Vien5",DiaChi="Ha Noi2"},
            };



            // Tim cac sinh vien co dia chi la hanoi1
            var dsSinhVienCanTim = sinhViens.Where(sv => sv.DiaChi.Equals("Ha Noi1")).ToList(); // trả về danh sách


            dsSinhVienCanTim.Sort((sv1, sv2) => sv2.HoTen.CompareTo(sv1.HoTen) );

            // LinQ foreach
            dsSinhVienCanTim.ForEach(sv =>
            Console.WriteLine($"Mã sv: {sv.MSV}, Tên:{sv.HoTen}, Địa chỉ:{sv.DiaChi}"));

            List<string> fruits = new List<string>() { "Táo","Lê", "Bưởi", "Chuối"};

            // Nối chữ
            string cumDuocNoi = string.Join(",", fruits);
            Console.WriteLine(cumDuocNoi);

            //


        }

    }

    public class SinhVien
    {
        public int MSV { get; set; }
        public string? HoTen { get; set; }

        public string? DiaChi { get; set; }
    }
}
