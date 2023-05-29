using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do While khac voi While 
            // Do while la lam xong roi kiem tra
            // While kiem tra xong moi lam 
            /* string keyword;

             do
             {
                 Console.WriteLine("Nhap vao 1 ky tu");
                 keyword = Console.ReadLine();

                 Console.WriteLine("Ky tu ban nhap vao: " +keyword);

             } while (keyword!= "Q");*/

            // Tinh tong 2 so nguyen duong a va b nhap vao tu ban phim

            // Neu nhap sai, yeu cau nhap lai 

            int a, b;
            do
            {
                Console.WriteLine("Nhap vao so a:");
                a = Convert.ToInt32(Console.ReadLine());
            }while(a <= 0);

            do
            {
                Console.WriteLine("Nhap vao so b:");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= 0);

            Console.WriteLine("Tong a va b:" + (a + b));
            Console.ReadLine();

        }
    }
}
