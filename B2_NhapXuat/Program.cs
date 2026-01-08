

namespace B2_NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai báo biến: kiểu dữ liệu + tên biến + toán tử gán (=) + giá trị

            Console.OutputEncoding = System.Text.Encoding.UTF8; // In ra tiếng việt

            // Tính tổng, tích, hiệu,thương 2 số nguyên nhập từ bàn phím
            float soThuNhat = 0, soThuHai = 0; //khai báo biến
            Console.Write("Mời bạn nhập số thứ nhất: ");
            // lệnh đọc ký tự từ bàn phím: Console.ReadLine(); // trả về chuỗi ký tự (string)
            soThuNhat = float.Parse(Console.ReadLine() ?? "0"); // ép kiểu chuỗi sang số thực và gán vào biến
            Console.Write("Mời bạn nhập số thứ hai: ");
         //   soThuHai = (float)Convert.ToDouble(Console.ReadLine()); // ép kiểu chuỗi sang số thực và gán vào biến
              float.TryParse(Console.ReadLine(), out soThuHai); // ép kiểu chuỗi sang số thực và gán vào biến // neu loi tra ve gtmd cua kieu du lieu
            Console.WriteLine($"Tổng của 2 số là: {soThuNhat + soThuHai}"); // chèn biến vào string dùng $ và {}
            Console.WriteLine("Hiệu của 2 số là: {0}", soThuNhat -soThuHai);

            Console.WriteLine("Căn bậc 2 của số {0} la {1}",soThuNhat,Math.Sqrt(soThuNhat));
        }
    }
}
