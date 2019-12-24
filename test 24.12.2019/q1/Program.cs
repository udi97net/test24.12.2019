using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0; 
            int b=0;
            int c=0;
            string coco;
            bool isprime = false;

                Console.Write("enter a prime number : ");
                coco = Console.ReadLine();
                a = Convert.ToInt32(coco);
                isprime = false;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        isprime = true;

                    }


                }
            Console.WriteLine(isprime == true ? $"***** {a} is no prime number*****" : "");
            if (isprime == false)
            {
                Console.Write("enter a prime number : ");
                coco = Console.ReadLine();
                b = Convert.ToInt32(coco);
                isprime = false;
                for (int i = 2; i < b; i++)
                {
                    if (b % i == 0)
                    {
                        isprime = true;

                    }


                }
                Console.WriteLine(isprime == true ? $"***** {b} is no prime number*****" : "");
            }

            if (isprime == false)
            {
                Console.Write("enter a prime number : ");
                coco = Console.ReadLine();
                c = Convert.ToInt32(coco);
                isprime = false;
                for (int i = 2; i < c; i++)
                {
                    if (c % i == 0)
                    {
                        isprime = true;

                    }


                }
                Console.WriteLine(isprime == true ? $"***** {c} is no prime number*****" : "");
            }
            if (isprime)
            {
                Console.WriteLine("tnx");
            }
            else
            {
                Console.WriteLine(a + b + c);
            }


        }
    }
}
