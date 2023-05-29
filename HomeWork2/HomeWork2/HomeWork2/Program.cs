using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sum = 1^2 + 2^2 + ...n^2

            int n;
            long sum = 0; // bien sum dung luu tong can tinh
            // long like BIG Int
            // double like big float 

            Console.WriteLine("Nhap vao gia tri n:");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1;i<= n;i++)
            {
                sum  = sum + (i*i);

            }
            Console.WriteLine("Sum is " + sum);

            Console.ReadLine();


        }
    }
}
