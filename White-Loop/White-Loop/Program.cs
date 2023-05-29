using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace White_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count_SNT = 0;
            int n = 2;
            while (count_SNT <= 10)
            {
                int count = 0;

                for(int i = 1;i <= n; i++)
                {
                    if(n%i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    count_SNT++;
                    Console.WriteLine(n);
                }
                n++;
            }
            Console.ReadLine();

        }
    }
}
