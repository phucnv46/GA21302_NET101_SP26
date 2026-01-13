using System.Reflection.Metadata;

namespace B3_VongLap_CacLoaiTapHop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vòng lặp for 
            Console.OutputEncoding = System.Text.Encoding.UTF8; // In ra tiếng việt

            // for(khởi tạo biến; điều kiện dừng; bước nhảy)
            /*for(; ; ) // while(true)
            {
                Console.WriteLine("Hello");
            }*/

            for (int i = 1; i <= 10; i++) // in từ 1 đến 10
            {
                Console.Write(i + " ");
            }

            // Vòng lặp while, do while
            //while(điều kiện lap){ // Kiem tra dieu kien roi thuc thi
            //}

            // do{}while(điều kiện lặp); // Thực thi trước rồi kiểm tra điều kiện sau

            Console.WriteLine();
            int j = 1;
            while (j <= 10)
            {
                Console.Write(j + " ");
                j++;
            }

            //1 vai loai tap hop trong C#
            // Mảng (Array):
            // string = char[];
            // kieudu lieu[] ten mang = new kieu du lieu[so luong phan tu];
            // 

            int[] mangSoNGuyen = new int[2]; // mảng 5 phần tử kiểu số nguyên
            double[] mangSoThuc = { 3, 5.6, 2.4, 0, 5 };
            // mảng 10 phần tử kiểu số thực

            // truy cập phần tử trong mảng
            // Duyet mang
            Console.WriteLine("Duyet bang for: ");
            for (int i = 0; i < mangSoThuc.Length; i++)
            {
                Console.WriteLine($"Phan tu thu {i} cua mang la: {mangSoThuc[i]}");

            }

            //interation foreach
            Console.WriteLine("Duyet bang foreach");

            foreach (double soThuc in mangSoThuc)
            {
                Console.WriteLine($"Gia tri cua phan tu trong mang la: {soThuc}");
            }


            //Array : Bi gioi han so luong phan tu

            //Khong bi gioi han so luong phan tu
            //List<KieuDuLieu> tenList = new List<KieuDuLieu>(){GTKT};
            List<int> danhSachSoNguyen = new List<int>() { 2,4,1,2,3,-1 };
            danhSachSoNguyen.Add(10); // them phan tu vao cuoi danh sach
            danhSachSoNguyen.RemoveAt(2); // xoa phan tu o vi tri index =2

            danhSachSoNguyen.AddRange(new int[] { 7, 8, 9 }); // them nhieu phan tu vao cuoi danh sach

            danhSachSoNguyen[2] = 20; // gan gia tri moi cho phan tu o vi tri index =2

            foreach (var item in danhSachSoNguyen)
            {
                Console.WriteLine(item);
            }

            // Dictionary<KieuDuLieuKhoa, KieuDuLieuGiaTri>
            Dictionary<string, int> danhBa = new Dictionary<string, int>()
            {
                {"Nguyen Van A", 0123456789 },
                {"Tran Thi B", 0987654321 }
            };

            foreach (var item in danhBa)
            {
                Console.WriteLine($"Ten: {item.Key} - So dien thoai: {item.Value}");
            }


        }
    }
}
