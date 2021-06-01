using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knock Knock");

            string who = (Console.ReadLine());
            if (who == "who's there?")

            {
                Console.WriteLine("Boo");
            }
            else if (who == "Who is there?")
            {
                Console.WriteLine("Boo");
            }
            else if (who == "who's there")
            {
                Console.WriteLine("Boo");
            }

            else
            {
                Console.WriteLine("Knock Knock");
            }

            //Console.ReadLine();
            if(Console.ReadLine() == "Boo who?")
            {
                Console.WriteLine("Why are you crying?");
            }
            else if (Console.ReadLine() == "boo who")
            {
                Console.WriteLine("Why are you crying?");
            }
            else
            {
                Console.WriteLine("Knock Knock");
            }
        }
    }
}
