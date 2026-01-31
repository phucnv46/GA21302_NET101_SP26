namespace NC_Validate_XLString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //int a = Validation.KiemTraSoNguyen("Mời nhập 1 số nguyên dương: ", 1, 10);

            Console.Write("Xin nhập chuỗi bất kì: ");
            // Xử lý string
            string input = Console.ReadLine();

            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Chuỗi rỗng hoặc null.");
            }
            else if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Chuỗi chỉ chứa khoảng trắng.");
            }
            else
            {
                Console.WriteLine($"Bạn đã nhập chuỗi: {input.Trim()}"); // Loại bỏ khoảng trắng đầu cuối
                Console.WriteLine($"Chuỗi khi được viết hoa {input.ToUpper()}");
                Console.WriteLine($"Chuỗi khi được viết thường {input.ToLower()}");
                Console.WriteLine($"Chuỗi có độ dài {input.Length}");
                Console.WriteLine($"Chữ cái a xuất hiện bao nheieu lần: {input.Count(c=>c=='a'|| c=='A')}");
                
                if(input.StartsWith("Xin")) // Bắt đầu bằng
                {
                    Console.WriteLine("Chuỗi bắt đầu bằng 'Xin'");
                }


                if(input.EndsWith("kí")) // Kết thúc bằng
                {
                    Console.WriteLine("Chuỗi kết thúc bằng 'kí'");
                }

                if (input.Contains("nhập")) // Chứa
                {
                    Console.WriteLine("Chuỗi có chứa 'nhập'");
                }

                string[] words = input.Split(' '); // Tách chuỗi thành mảng con dựa trên dấu cách

                var sv = new SinhVien();
                if(sv is SinhVien) // Kiểm tra kiểu đối tượng
                {
                    Console.WriteLine("sv là đối tượng của lớp SinhVien");
                }

                // boxing unboxing

                 List<object> list = new List<object>() {1,"",new SinhVien(), new  { Id=1,Ten="Phuc" } };

            }
        }
    }
}
