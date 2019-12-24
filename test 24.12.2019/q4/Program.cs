using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars;
            string coco;
            Console.Write("enter a number:  ");
            coco = Console.ReadLine();
            stars = Convert.ToInt32(coco);
            int cs = stars ;
            if (stars > 0 && stars < 16)
            {
                for (int i = 0; i <= stars; i++)
                {
                    Console.WriteLine("");
                    for (int j = cs; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    cs--;
                    for (int t = 0; t < i; t++)
                    {
                        Console.Write("*");

                    }


                }
            }
           
            Console.WriteLine("");
        }
    }
}
