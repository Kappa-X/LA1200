using System;

namespace Zufall
{
    class Program
    {
        static void Main(string[] args)
        

        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            string start = "yes";
            while (start == "yes")
            {
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;


                int lucky = new Random().Next(1, 101);
             
                Console.Write("Enter a number between 1 and 100: ");

                try
                {
                    String userinput = Console.ReadLine();
                    int GuessConvert = Convert.ToInt32(userinput);
                    int tries = 1;
                    while (lucky != GuessConvert)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Beep();

                        if ((GuessConvert > 100) || (GuessConvert < 1))
                        {
                            Console.WriteLine("your number isn't betwenn 1 and 100. Please try again");
                            userinput = Console.ReadLine();
                            GuessConvert = Convert.ToInt32(userinput);
                        }

                        Console.Beep();

                        if (GuessConvert > lucky)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Try a smaller number");
                        }

                        if (GuessConvert < lucky)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Try a bigger number");
                        }
                        userinput = Console.ReadLine();
                        GuessConvert = Convert.ToInt32(userinput);
                        tries = tries + 1;
                    }

                    if (GuessConvert == lucky)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are great You tried " + tries + " time(s)");
                    Console.WriteLine("Do you want to try again? [yes|no]");
                    start =Console.ReadLine();
                    Console.Clear();
                }

                catch
                {
                    Console.ForegroundColor
                     = ConsoleColor.DarkMagenta;
                    Console.WriteLine("This is no number. Please try again");
                }


            }



        
        }
    }
}
