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
            if(input == "klay" || input =="admin")
            {
                                               
                    Console.WriteLine("Hello Creator/friend");
                    Console.WriteLine("How is friend?");
                    var mood = Console.ReadLine();
                    if (mood == "good")
                    {
                        Console.WriteLine("Friend is in good mood...");

                    }
                    else
                    {
                        Console.WriteLine("You should play game to feel better");
                    }
                
            }

            Console.WriteLine($"Hello {input} \n I am the S587 Machine \n the time and date is {DateTime.Now} \n would you like to play a game?");
            var input2 = Console.ReadLine();
            if ( input2 == "yes")
            {
                Console.WriteLine("What would you like to play?");
                Console.WriteLine("Magic 8 Ball?,\n Rock paper scissors?, \nWorld Domination? \n random number game.");
                var input3 = Console.ReadLine();
                if (input3 == "magic 8 ball")
                {

                    

                    

                     Console.WriteLine("Do you want to play?");
                     var userChoice = Console.ReadLine();
                    do
                    {

                        Console.WriteLine("Ask a question");
                        Console.ReadLine();
                        Random rnd = new Random();
                        int num = rnd.Next(0, 6);
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
                            case 4:
                                Console.WriteLine("Maybe");
                                break;
                            case 5:
                                Console.WriteLine("You never know");
                                break;

                        }
                          
                    } while (userChoice == "yes");
                }
                if (input3 == "rock paper scissors")
                {
                    Console.WriteLine("Do you choose rock,paper or scissors");
                    string userChoice = Console.ReadLine();

                    Random r = new Random();
                    int computerChoice = r.Next(4);

                    if (computerChoice == 1)
                    {
                        if (userChoice == "rock")
                        {
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("It is a tie ");
                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("It is a tie ");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("It is a tie ");
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");

                        }

                    }

                    else if (computerChoice == 2)
                    {
                        if (userChoice == "rock")
                        {
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("Sorry you lose,paper beat rock");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("Sorry you lose,scissors beat paper ");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("Sorry you lose,rock beats scissors");
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");
                        }
                    }
                    else if (computerChoice == 3)
                    {
                        if (userChoice == "rock")
                        {
                            Console.WriteLine("The computer chose scissors");
                            Console.WriteLine("You win,rock beats scissors");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine("The computer chose rock");
                            Console.WriteLine("You win,paper beats rock");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine("The computer chose paper");
                            Console.WriteLine("You win,scissors beat paper");

                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");

                        }

                    }

                    

                }
                if (input3 == "world domination")
                {
                    Console.WriteLine($"are you sure {input}");
                    var sure = Console.ReadLine();
                    Console.ReadLine();
                    if (sure == "yes")
                    {
                        Console.WriteLine("Starting Timer, pick your Country");

                    }
                    
                }
                if (input3 == "random number game")
                {
                    Random r = new Random();
                    int winNum = r.Next(0, 100);
                    bool win = false;
                    do
                    {
                        Console.WriteLine("guess a number between 0 and 100");
                        string s = Console.ReadLine();
                        int i = int.Parse(s);
                        if (i> winNum)
                            {
                                Console.WriteLine("To High");
                            }
                         else if(i<winNum)
                        {
                            Console.WriteLine("To Low");
                        }
                         else if(i==winNum)
                        {
                            Console.WriteLine("Correct");
                            win = true;
                        }
                    } while (win == false);
                    
                }
                if(input3=="p123")
                {
                    Console.WriteLine("Running Protocal 1238t48");
                }
            }
            else if(input2 == "p432")
            {
                Console.WriteLine("What would you like to run?");
                Console.WriteLine(" \n Settings, \n Notes, \n usage ");
                var admin = Console.ReadLine();
                if(admin=="settings")
                {
                    Console.WriteLine("....... \n No Settings found");
                }

            }
           
        
            else if (input2 == "no")
            {
                Console.WriteLine("let me tell you a story");
                Console.WriteLine($" i was created {DateTime.Today} by......  ");
                Console.WriteLine($"ending program......Protocol 374");
            }

           

        }
    }
}
