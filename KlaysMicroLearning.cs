using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kdowelearningapp
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, who are you");
            var input = Console.ReadLine();
            Console.WriteLine($"Hello {input} the time and date is {DateTime.Now} \n would you like to play a game?");
            var input2 = Console.ReadLine();
            if ( input2 == "yes")
            {
                Console.WriteLine("What would you like to play?");
                Console.WriteLine("Magic 8 Ball?, Rock paper scissors?, World Domination?");
                var input3 = Console.ReadLine();
                if (input3 == "magic 8 ball")
                {
                    Console.WriteLine("Ask a question");
                    Console.ReadLine();
                    Random rnd =new Random();
                    int num = rnd.Next(1, 4);
                    switch (num)
                    {
                        case 0:
                            Console.WriteLine("Yes");
                            break;
                        case 1:
                            Console.WriteLine("No"); 
                            break;
                        case 2:
                            Console.WriteLine("Ask again later"); 
                            break;
                        case 3:
                            Console.WriteLine("Not Very Likely");
                            break;

                    }
                }
                if (input3 == "rock paper scissors")
                {

                }
                if (input == "world domination")
                {

                }
            }
           
        
            else if (input2 == "no")
            {
                Console.WriteLine("then what would you like to do?");
            }

           

        }
    }
}
