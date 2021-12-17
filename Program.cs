using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetWindowSize(65, 40);
            // door buffer te gebruiken verwijder je de scroll balk
            Console.BufferWidth = 65;
            Console.BufferHeight = 40;
            Console.ReadKey();
            Console.Title = "Black Jack";
            DealCards dc = new DealCards();
            bool quit = false;

            while (!quit) 
            {
                dc.Deal();

                char selection = ' ';
                while (!selection.Equals('J') && !selection.Equals('N'));
                {
                    Console.WriteLine("Opnieuw spelen? J-N");
                    selection = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (selection.Equals('J'))
                    {
                        quit = false;
                    }
                    else if (selection.Equals('N'))
                    {
                        quit = true;
                    }
                    else
                        Console.WriteLine("Foutive slectie. Probeer het opnieuw");
                }
            }
        }
    }
}
