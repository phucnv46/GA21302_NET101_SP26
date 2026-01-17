namespace OOP1_Class_Objects
{
    internal class Program
    {

        // Lap trinh huong doi tuong 
        // Class - Dinh nghia ve kieu du lieu moi

        /* OOP dua cac mo hinh o ngoai doi vao trong code
         * 4 tinh chat chinh cua OOP: Dong goi (Encapsulation), Ke thua (Inheritance), Da hinh (Polymorphism), Truu tuong (Abstraction)
         * Class la khuon mau de tao ra doi tuong (Object)
            
            class SinhVien: Ten, Tuoi, DiaChi, MaSV => Thuoc tinh (Properties)
                            Nghi, Di hoc, Di choi => Phuong thuc (Methods)

            Object: Doi tuong - The hien cua lop (Class)    


            Súng: Class
                - Thuoc tinh: Mau sac, Kich thuoc, Co so, SL dan,
                - Phuong thuoc: Ban, Nap da
            - Valdal: Object
                - Mau sac: Den
                - Kich thuoc: Nho gon
                - Co so: 8x
                - SL dan: 30 vien
                - Phuong thuc: Ban, Nap da
                  
         */

        static void PhuongThuc()
        {
            Console.WriteLine("Phuong thuc cua Program");
        }

        static void Main(string[] args)
        {
            /*
               TenClass tenDoiTuong = new TenClass(){Truyen thuoc tinh};
             */
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Sung valdal = new Sung() { TenSung="Valdal", MauSac="Bạc", SoLuongDan=30 }; //Tao doi tuong valdal tu class Sung

            valdal.Ban();
            valdal.NapDan(10);

            // Khong satatic, chi truy cap duoc thong qua doi tuong

            // Co static , truy cap truc tiep thong qua ten class

            // Tao 1 class Tuong: HP,Mana,TenTuong,...; Phuong thuc: TanCong, DiChuyen
            //Tao doi tuong tuong1, tuong2 va goi phuong thuc tren doi tuong do
        }



    }

    
}
