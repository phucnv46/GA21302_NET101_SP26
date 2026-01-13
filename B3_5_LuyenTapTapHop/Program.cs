namespace B3_5_LuyenTapTapHop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sap sep xep danh sach so thuc
            //In ra danh sach so nguyen theo dieu kien
            // Thuc hien tao menu
            // Thuc hien them sua xoa tim kiem phan tu trong danh sach so thuc
            Console.OutputEncoding = System.Text.Encoding.UTF8; // In ra tiếng việt

            //Tao menu chuc nang
            List<double> danhSachSoThuc = new List<double>() { 2.5, 3.6, 1.8, -9.123 }; // Khai bao danh sach so thuc
            while (true)
            {
                int luaChon = 0;
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Thêm số thực vào danh sách");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Sua so o vi tri chi dinh");
                Console.WriteLine("4. Xoa so o vi tri chi dinh");
                Console.WriteLine("5. Tim so co gia tri nhap vao o vi tri nao");
                Console.WriteLine("6. Dem so phan tu bang gia tri nhap vao");
                Console.WriteLine("7. Sap xep danh sach");
                Console.WriteLine("0. Thoat");
                Console.Write("Xin moi nhap lua chon: ");
                int.TryParse(Console.ReadLine(), out luaChon); // lay lua chon tu ban phim



                switch (luaChon)
                {
                    case 1:
                        {
                            // Them so thuc
                            Console.WriteLine("Moi ban nhap so thuc can them: ");
                            double soThucThem;
                            double.TryParse(Console.ReadLine(), out soThucThem);
                            danhSachSoThuc.Add(soThucThem); // Them so thuc vao cuoi danh sach
                            Console.WriteLine("Da them so thuc vao danh sach.");
                            break;
                        }
                    case 2:
                        {
                            // Hien thi danh sach
                            Console.WriteLine("Danh sach so thuc hien tai: ");
                            foreach (double soThuc in danhSachSoThuc)
                            {
                                Console.Write(soThuc + ", ");
                            }
                            break;
                        }
                    case 3:
                        {
                            // Hien thi danh sach
                            int viTriSua;
                            Console.WriteLine("Xin mơi nhập vị trí cần sửa");
                            int.TryParse(Console.ReadLine(), out viTriSua);

                            if (viTriSua >= 0 && viTriSua < danhSachSoThuc.Count)
                            {
                                Console.WriteLine("Moi ban nhap so thuc moi: ");
                                double soThucMoi;
                                double.TryParse(Console.ReadLine(), out soThucMoi);
                                danhSachSoThuc[viTriSua] = soThucMoi;
                                Console.WriteLine("Da sua so thuc o vi tri {0}.", viTriSua);
                            }
                            else
                            {
                                Console.WriteLine("Vi tri khong hop le.");
                            }
                            break;
                        }
                    case 4:
                        {
                            // Hien thi danh sach
                            int viTriSua;
                            Console.WriteLine("Xin mơi nhập vị trí cần sửa");
                            int.TryParse(Console.ReadLine(), out viTriSua);

                            if (viTriSua >= 0 && viTriSua < danhSachSoThuc.Count)
                            {
                               
                                danhSachSoThuc.RemoveAt(viTriSua);
                                Console.WriteLine("Da sua so thuc o vi tri {0}.", viTriSua);
                            }
                            else
                            {
                                Console.WriteLine("Vi tri khong hop le.");
                            }
                            break;
                        }

                    case 5:
                        {
                            // Tim so thuc
                            Console.WriteLine("Moi ban nhap so thuc can tim: ");
                            double soThucTim;
                            double.TryParse(Console.ReadLine(), out soThucTim);
                            int viTri = danhSachSoThuc.IndexOf(soThucTim);
                            if (viTri != -1)
                            {
                                Console.WriteLine("So thuc {0} duoc tim thay o vi tri {1}.", soThucTim, viTri);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay so thuc {0} trong danh sach.", soThucTim);
                            }
                            break;
                        }
                    case 6:
                        {
                            double soThucDem;
                            // Dem so phan tu
                            Console.WriteLine("Moi ban nhap so thuc can dem: ");
                            
                            double.TryParse(Console.ReadLine(), out soThucDem);

                            int dem = 0;
                            dem = danhSachSoThuc.Count(a=>a == soThucDem);

                            Console.WriteLine("Voi gia tri {0} co {1} phan tu", soThucDem, dem);

                            break;
                        }
                        case 7:
                        {
                            // Sap xep danh sach
                            danhSachSoThuc.Sort((a,b)=>b.CompareTo(a));
                            Console.WriteLine("Da sap xep danh sach so thuc giam dan.");
                            break;
                        }

                    case 0:
                        {
                            Console.WriteLine("Thoat chuong trinh.");
                            return; // Thoat khoi ham Main
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                            break;
                        }


                }
            }
        }
    }
}
