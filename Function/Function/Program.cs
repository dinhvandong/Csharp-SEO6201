using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* int a = 10;
            int b = 20;
            int sum1 = add(a, b);
            int sub1 = sub(a, b);
            int mul1 = mul(a,b);
            float div1 = div(a,b);


            Console.WriteLine( "Tong a va b:"+ sum1);
            Console.WriteLine("Hieu a va b:" + sub1);
            Console.WriteLine("Tich a va b:" + mul1);
            Console.WriteLine("Thuong a va b:" +div1);*/
           int countPrime = 0;
            for(int i = 1;i<=100;i++)
            {
                if (checkPrime(i)==true)
                {
                    //Console.WriteLine(i);
                    countPrime++;

                }

            }

            Console.WriteLine(countPrime);


        }
        /*
         
        dataType + function_name ( data_type var1, data_type var2,....)
        {

            return value;
        }
         
         */

        static bool checkPrime(int n)
        {

            // == true la SNT
            // == false ko la SNT
            int count = 0;
            if(n<2) return false;

            for(int i = 1; i <= n; i++)
            {
                if(n%i==0) count++;
            }
            if(count == 2) return true;
            return false;
        }

        static int add(int a, int b)
        { 
            return a + b; 
        }
        static int sub(int a, int b)
        {
              return a-b;
        }

        static int mul(int a, int b)
        {
            return a * b;
        }
        static float div(int a, int b)
        {
            return (float)a / b;
        }





    }
}
