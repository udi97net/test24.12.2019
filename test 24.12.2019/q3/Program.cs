using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string coco;
            Console.Write("enter a number:  ");
            coco = Console.ReadLine();
            a = Convert.ToInt32(coco);
            for (int i = 1; i < a+1; i++)
            {
                int v = 1;
                Console.WriteLine("");
                for (int x = 0; x < i; x++)
                {
                    Console.Write(v);
                    v++;
                }
                
                for (int t = 1; t < ((a+1) - i); t++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }
    }
}
