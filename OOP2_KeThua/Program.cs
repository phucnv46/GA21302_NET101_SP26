namespace OOP2_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = System.Text.Encoding.UTF8;

            XeMay xemay = new XeMay() 
            { Ten="Vision", HangSX="Honda",BienSo="29C1-321.42",MaLuc=150,NamSX=2020 };

            xemay.DiChuyen();
            xemay.TangToc();
        }
    }
}
