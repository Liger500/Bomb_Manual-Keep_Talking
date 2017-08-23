using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Manual
{
    class Program
    {
        //int strikes = 3;
        //int sn_vowel;
        //int sn_number;
        //int battery;

        static void Main(string[] args)
        {
            Console.WriteLine("For now, do everything in lowercase.");
            Console.WriteLine("Which module?");
            //Figure out how to just list all modules here
            Console.WriteLine("1) Regular Wires");
            Console.WriteLine("2) Button");


            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1) { Wires(); }
            else if (menu == 2) { Button();  }
        }  //End Main

        static void Wires() {
            Console.WriteLine("How many wires total?");
            int wires = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many white?");
            int white = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many red?");
            int red = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many yellow?");
            int yellow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many blue?");
            int blue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many black?");
            int black = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What color is the last wire?");
            string last = Console.ReadLine();
            //Used in 4 and 5
            Console.WriteLine("Is the last digit of the serial number odd?");
            string sn = Console.ReadLine();

            if (wires == 3)
            {
                if (red == 0)
                {
                    Console.WriteLine("Cut the second wire.");
                }  //Ends red
                else if (last == "white")
                {
                    Console.WriteLine("Cut the last wire.");
                }  //Ends last wire
                else if (blue > 1)
                {
                    Console.WriteLine("Cut the last blue wire.");
                } //End blue more than 1
                else
                {
                    Console.WriteLine("Cut the last wire.");
                } //catch all for 3
            }  //End of 3 wires

            if (wires == 4)
            {
                if (red > 1  && sn == "yes")
                {
                    Console.WriteLine("Cut the last read wire.");
                } //Ends red
                else if (last == "yellow" && red == 0)
                {
                    Console.WriteLine("Cut the first wire.");
                }  //Ends yellow
                else if (blue == 1)
                {
                    Console.WriteLine("Cut the first wire.");
                }
                else if (yellow > 1)
                {
                    Console.WriteLine("Cut the last wire.");
                }
                else
                {
                    Console.WriteLine("Cut the second wire.");
                }
            }  // End of 4 wires

            if (wires == 5)
            {
                if (last == "black" && sn == "yes")
                {
                    Console.WriteLine("Cut the fourth wire.");
                }  //End last
                else if (red == 1 && yellow > 1)
                {
                    Console.WriteLine("Cut the first wire.");
                }  //End red
                else if (black == 0)
                {
                    Console.WriteLine("Cut the second wire.");
                }
                else
                {
                    Console.WriteLine("Cut the fourth wire.");
                }
            }  //End of 5 wires

            if (wires == 6)
            {
                if (yellow == 0 && sn == "yes")
                {
                    Console.WriteLine("Cut the third wire.");
                }
                else if (yellow == 1 && white > 1)
                {
                    Console.WriteLine("Cut the fourth wire.");
                }
                else if (red == 0)
                {
                    Console.WriteLine("Cut the last wire.");
                }
                else
                {
                    Console.WriteLine("Cut the fourth wire.");
                }
            }  //End of 6 wires
            Console.ReadLine();
            Console.WriteLine("Again?");
            string yn = Console.ReadLine();

            if (yn == "yes") { Wires(); }

        }  //Ends wires

        //Start of Button
        static void Button()
        {
            Console.WriteLine("What color is the button?");
            string color = Console.ReadLine();
            Console.WriteLine("What does the button say?");
            string text = Console.ReadLine();
            Console.WriteLine("How many batteries are on the bomb?");
            int battery = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is there a lit indicator on the bomb?");
            string lit = Console.ReadLine();
            if (lit == "yes")
            {
                Console.WriteLine("What does it say?");
                string littext = Console.ReadLine();
            }

            if (color == "blue" && text == "abort")
            {
                Console.WriteLine("Press and hold, what's the colored strip?");
                string strip = Console.ReadLine();
            }
            if (battery > 1  && text == "detonate")
            {
                Console.WriteLine("Press and release immeadiately.");
            }


            //LEAVING OFF ON NUMBER 3.


            Console.ReadLine();
        }  //End of Button

    }  //End Class
}  //End all
