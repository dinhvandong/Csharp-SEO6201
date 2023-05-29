using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum =   1/1 + 1/2 + 1/3 + 1/4 + 1/5 + 1/6 + 1/7 + ..... 1/n
            int n;

            float sum = 0;

            Console.WriteLine("Nhap vao gia tri n");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                sum = sum + (1.0f / i); // 1.0 is float => 1.0/i is Float 

            }

            Console.WriteLine("Sum is "+ sum);

        }
    }
}
