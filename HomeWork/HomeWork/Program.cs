using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;
            int sum = 0;

            Console.WriteLine("Nhap gia tri N:");
            // Console.ReadLine() == nhan input tu keyboard  is String (Chuoi ky tu) 

            n = Convert.ToInt32(Console.ReadLine());// Convert String to Int32

            // 1+ 2 + 3 + ...n

            for(int i = 1; i <= n; i++)
            {

                sum = sum + i;

            }
            Console.WriteLine("Sum is "+ sum);

            Console.ReadLine();
        }
    }
}
