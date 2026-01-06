namespace B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kiểu dữ liệu + tên biến + toán tử gán + giá trị

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int soNguyen = 10; // so nguyên có dấu âm
            uint soNguyenKhongAm = 20; // số nguyên không dấu âm
            long soNguyenDai = 3000000000; // số nguyên dài
            short soNguyenNgan = 32000; // số nguyên ngắn

            float soThuc = 5.75f; // số thực đơn
            double soThucDai = 19.99; // số thực dài

            char kyTu = 'A'; // ký tự
            string chuoi = "Xin chào các bạn"; // chuỗi ký tự

            bool bieuThucLogic = true; // biểu thức logic (true/false)

            // Toán tử tính toán : + - * / %
            //Toán tử so sánh : == != > < >= <=

            // Tính chu vi, diện tích của hình chữ nhật
            int chieuDai = 0, chieurong = 0;

            Console.Write("Xin mời nhập chiều dài: ");
           // chieuDai = int.Parse(Console.ReadLine());
              int.TryParse(Console.ReadLine(), out chieuDai);
            Console.Write("Xin mời nhập chiều rộng: ");
            //chieurong = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out chieuDai);
            Console.WriteLine($"Vay chu vi cua hcn la {(chieuDai+chieurong)*2}");
            Console.WriteLine($"Vay dien tich cua hcn la {(chieuDai*chieurong)}");

            

            // Kiểu dữ liệu
            // Nguyên thủy: int, uint, long, short, float, double, char, string, bool
            // Tham chiếu: class, interface, array, delegate (sẽ học)
            //Toán tử
            // Toán tử tính toán: + - * / %
            // Toán tử so sánh: == != > < >= <=

        }
    }
}
