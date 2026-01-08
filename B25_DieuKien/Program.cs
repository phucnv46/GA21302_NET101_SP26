namespace B25_DieuKien
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            // Điều kiện if...else
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*
               if(dk)
               {
                   // code thực thi nếu điều kiện đúng
               }
               else if()
               {
                   // code thực thi nếu điều kiện đúng
               }
               else
               {
                   // code thực thi nếu điều kiện sai
               }
             */

            // Nhập vào 1 số nguyên, kiểm tra số đó là chẵn hay lẻ
            // Kiểm tra có chia hết cho 3 hay không
            batdau:
            int soNguyen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mời bạn nhập số nguyên: ");
            if(!int.TryParse(Console.ReadLine(), out soNguyen)) // nếu nhập sai thông báo
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bạn nhập sai định dạng số!");
                goto batdau;
            }

            if (soNguyen % 2 == 0)
            {
               
                Console.WriteLine($"Số {soNguyen} là số chẵn");
            }
            else
            {
               
                Console.WriteLine($"Số {soNguyen} là số lẻ");
            }

            //Toán tử 3 ngôi
            var ketQua = (soNguyen % 3 == 0) ? "chia hết" : "không chia hết";
            Console.WriteLine($"Số {soNguyen} {ketQua} cho 3");

        }
    }
}
