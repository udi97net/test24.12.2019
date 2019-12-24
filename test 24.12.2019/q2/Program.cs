using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int days;
            int hours;
            int minutes;
            int seconds;
            string coco;
            Console.WriteLine("enter a number :  ");
            coco = Console.ReadLine();
            num = Convert.ToInt32(coco);
            if (num >= 0 )
            {
                Console.WriteLine($"{num} seconds is");
                days = (num / 86400);
                num = (num % 86400);
                hours = (num / 3600);
                num = (num % 3600);
                minutes = (num / 60);
                num = (num % 60);
                seconds = num;
                Console.WriteLine(days > 0 ? $"days :{days}" :"");
                Console.WriteLine(hours > 0 ? $"hours :{hours}" :"");
                Console.WriteLine(minutes > 0 ? $"minutes :{minutes}" :""); 
                Console.WriteLine(seconds > 0 ? $"seconds :{seconds}" :"");
                Console.WriteLine("press somting to say goodbay");
                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("sorry");
                Console.WriteLine("press somting to say goodbay");
                Console.ReadKey();
            }
        }
            
            
            
        
    }
}
