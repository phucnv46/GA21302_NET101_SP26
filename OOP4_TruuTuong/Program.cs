namespace OOP4_TruuTuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iflyable maybay = new MayBay();
            Iflyable chim = new Chim();

            maybay.Fly();
            chim.Fly();


        }


        // abtract class: lop truu tuong : is a
        // khong the khoi tao doi tuong tu

        //interface: giao dien : like a
        // chi chua cac phuong thuc, thuoc tinh


        // Hình: tròn, vuông, tam giac
        // Đã là hình thì phải có phương thức TínhDiệnTích và TínhChuVi

        //Abstract: Phương thước không định nghĩa trong lớp cha mà được định nghĩa trong lớp con
    }
}
