using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            long sum = 0;
            Console.WriteLine("Nhap n:");
            n = Convert.ToInt32(Console.ReadLine());

            // (1) + (1.2) + (1.2.3) + (1.2.3.4) + ....(1.2.3.4...n)

            // 1.2.3.4...n = n giai thua
            long x = 1;

            for(int i = 1;i<=n ;i++)
            {
                x = x * i; // 1*2*3*....(n-1) * n = n giai thua
                sum = sum + x;
            }

            Console.WriteLine("Result is "+ sum);
            Console.ReadLine();

           
        }
    }
}
