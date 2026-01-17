using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1_Class_Objects
{
    internal class Sung
    {
        //Thuoc tinh (Properties)
        // Full property

        // Quyen truy cap: private, public, protected, internal
        /*
          private: chi truy cap duoc ben trong class
          internal: truy cap duoc ben trong cung 1 assembly (project)
          public: truy cap duoc o moi noi 
          protected: chi truy cap duoc ben trong class do va class ke thua no
          
         */

        string _tenSung; // Khai bao truong thong tin (Field)

        public Sung()
        {
        }

        public string TenSung // Cung cap kha nang doc/ghi cho truong thong tin
        {
            get { return $"{_tenSung}"; }
            set { _tenSung = value; }
        }

        public string MauSac { get; set; }

        public int SoLuongDan { get; set; }

        //Phuong thuc (Methods)

        internal void Ban()
        {
            Console.WriteLine($"{TenSung} bắn ra đạn");
        }

        public void NapDan(int soLuong)
        {
            SoLuongDan += soLuong;
            Console.WriteLine($"{soLuong} viên đạn đã được nạp vào {TenSung}");
        }

        public Sung(string tenSung, string mauSac, int soLuongDan)
        {
            TenSung = tenSung;
            MauSac = mauSac;
            SoLuongDan = soLuongDan;
        }

        //contructor - ham khoi tao





    }
}
