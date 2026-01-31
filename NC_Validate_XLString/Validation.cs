using System;
using System.Collections.Generic;
using System.Text;

namespace NC_Validate_XLString
{
    internal class Validation
    {
        internal static int KiemTraSoNguyen(string
            message, int minValue = int.MinValue, int maxValue=int.MaxValue)
        {

            while (true)
            {
                Console.Write(message);
                int value;
                try
                {
                    value = int.Parse(Console.ReadLine() ?? "");
                    if (value < minValue || value > maxValue)
                    {
                        Console.WriteLine($"Giá trị phải nằm trong khoảng từ {minValue} đến {maxValue}. Vui lòng thử lại.");
                        continue;
                    }
                    return value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Không đúng định dạng");
                    continue;
                }
            }

            
        }
    }
}
