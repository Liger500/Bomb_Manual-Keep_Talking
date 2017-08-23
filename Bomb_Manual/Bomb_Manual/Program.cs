using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Manual
{
    class Program
    {
        int strikes = 0;
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
            Console.WriteLine("3) Keypads");
            Console.WriteLine("4) Simon Says");
            Console.WriteLine("5) Who's on First");
            Console.WriteLine("6) Memory");
            Console.WriteLine("7) Morse Code");
            Console.WriteLine("8) Complicated Wires");


            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 666) { Console.WriteLine("I'm going to add a loop and quit later");  }
            //if (menu == 0) { Strikes(strikes); }
            else if (menu == 1) { Wires(); }
            else if (menu == 2) { Button();  }
            else if (menu == 3) { Console.WriteLine("Can't help you there. See the actual manual.");  }
            else if (menu == 4) { SimonSays(); }
            else if (menu == 5) { Console.WriteLine("I'm trying to work out how to do this.  It's a lot of words."); }
            else if (menu == 6) { Memory(); }
            else if (menu == 7) { Console.WriteLine("Gotta figure out how to do a morse code thing.  Maybe just print the whole alphabet?"); }
            else if (menu == 8) { ComplicatedWires(); }
        }  //End Main

        private int Strikes(int strikes)
        {
            Console.WriteLine(strikes);
            Console.WriteLine("Do we need to add a strike?");
            string yn = Console.ReadLine();
            if (yn == "yes")
            {
                strikes++;
                Console.WriteLine(strikes);
            }
            return strikes;
        }

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
            string littext = "words";
            if (lit == "yes")
            {
                Console.WriteLine("What does it say?");
                littext = Console.ReadLine();
            }

            if (color == "blue" && text == "abort")
            {
                StripFinder();
            }
            else if (battery > 1  && text == "detonate")
            {
                Console.WriteLine("Press and release immeadiately.");
            }
            else if (color == "white" && lit =="yes" && littext == "car")
            {
                StripFinder();
            }
            else if (battery > 2 && lit == "yes" && littext == "frk")
            {
                Console.WriteLine("Press and release immeadiately.");
            }
            else if (color == "yellow")
            {
                StripFinder();
            }
            else if (color == "red" && text == "hold")
            {
                Console.WriteLine("Press and release immeadiately.");
            }
            else
            {
                StripFinder();
            }





            Console.ReadLine();
        }  //End of Button

        static void StripFinder()
        {
            Console.WriteLine("Press and HOLD the button.");
            Console.WriteLine("What is the color of the strip?");
            string stripcolor = Console.ReadLine();
            if (stripcolor == "blue")
            {
                Console.WriteLine("Release when countdown timer has a 4 in any position.");
            }
            else if (stripcolor == "white")
            {
                Console.WriteLine("Release when countdown timer has a 1 in any position.");
            }
            else if (stripcolor == "yellow")
            {
                Console.WriteLine("Release when countdown timer has a 5 in any position.");
            }
            else
            {
                Console.WriteLine("Release when countdown timer has a 1 in any position.");
            }
        }  // End StripFinder

        static void SimonSays()
        {
            Console.WriteLine("How many strikes do you have?");
            int strikes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is there a vowel in the serial number? (a/e/i/o/u/y?)");
            string vowel = Console.ReadLine();

            if (strikes == 0 && vowel == "yes")
            {
                Console.WriteLine("If Red click Blue");
                Console.WriteLine("If Blue click Red");
                Console.WriteLine("If Green click Yellow");
                Console.WriteLine("If Yellow click Green");
            }
            else if (strikes == 1 && vowel == "yes")
            {
                Console.WriteLine("If Red click Yellow");
                Console.WriteLine("If Blue click Green");
                Console.WriteLine("If Green click Blue");
                Console.WriteLine("If Yellow click Red");
            }
            else if (strikes == 2 && vowel == "yes")
            {
                Console.WriteLine("If Red click Green");
                Console.WriteLine("If Blue click Red");
                Console.WriteLine("If Green click Yellow");
                Console.WriteLine("If Yellow click Blue");
            }
            else if (strikes == 0 && vowel == "no")
            {
                Console.WriteLine("If Red click Blue");
                Console.WriteLine("If Blue click Yellow");
                Console.WriteLine("If Green click Green");
                Console.WriteLine("If Yellow click Red");
            }
            else if (strikes == 1 && vowel == "no")
            {
                Console.WriteLine("If Red click Red");
                Console.WriteLine("If Blue click Blue");
                Console.WriteLine("If Green click Yellow");
                Console.WriteLine("If Yellow click Green");
            }
            else if (strikes == 2 && vowel == "no")
            {
                Console.WriteLine("If Red click Yellow");
                Console.WriteLine("If Blue click Green");
                Console.WriteLine("If Green click Blue");
                Console.WriteLine("If Yellow click Red");
            }
        }  //End SimonSays

        static void Memory()
        {
            int num = 0; //Big number
            int num1 = 0; //Number on screen 1
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            string pos1 = "blank";
            string pos2 = "blank";
            string pos3 = "blank";
            string pos4 = "blank";
            string x = "blank";

            //Screen 1. There's a better way to do this...
            Console.WriteLine("Stage 1");
            Console.WriteLine("What's the big number?");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1 | num == 2) { x = "second"; }
            else if (num == 3) { x = "third"; }
            else if (num == 4) { x = "fourth"; }

            Console.WriteLine("Press the button in the "+ x +" position.");
            Console.WriteLine("What number was it?");
            num1 = Convert.ToInt32(Console.ReadLine());
            pos1 = x;

            //Screen 2.
            Console.WriteLine("Stage 2");
            Console.WriteLine("What's the big number?");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Press the button labeled 4.");
                Console.WriteLine("What position was it in?");
                num2 = 4;
                pos2 = Console.ReadLine();
            }
            else if (num == 2 | num == 4)
            {
                Console.WriteLine("Press the button in the " + pos1 + " position.");
                Console.WriteLine("What number was it?");
                num2 = Convert.ToInt32(Console.ReadLine());
                pos2 = x;
            }
            else if (num == 3)
            {
                Console.WriteLine("Press the button in the first position.");
                Console.WriteLine("What number was it?");
                num2 = Convert.ToInt32(Console.ReadLine());
                pos2 = "first";
            }

            //Screen 3.
            Console.WriteLine("Stage 3");
            Console.WriteLine("What's the big number?");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Press the number " + num2 + ".");
                Console.WriteLine("What position was it in?");
                num3 = num2;
                pos3 = Console.ReadLine();
            }
            else if (num == 2)
            {
                Console.WriteLine("Press the number " + num1 + ".");
                Console.WriteLine("What position was it in?");
                num3 = num1;
                pos3 = Console.ReadLine();
            }
            else if (num == 3)
            {
                x = "third";
                Console.WriteLine("Press the button in the " + x + " position.");
                Console.WriteLine("What number was it?");
                num3 = Convert.ToInt32(Console.ReadLine());
                pos3 = x;
            }
            else if (num == 4)
            {
                Console.WriteLine("Press the number 4.");
                Console.WriteLine("What position was it in?");
                num3 = 4;
                pos3 = Console.ReadLine();
            }

            //Screen 4.
            Console.WriteLine("Stage 4");
            Console.WriteLine("What's the big number?");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num == 1)
            {
                Console.WriteLine("Press the button in the " + pos1 + " position.");
                Console.WriteLine("What number was it?");
                num4 = Convert.ToInt32(Console.ReadLine());
                pos4 = pos1;
            }
            else if (num == 2)
            {
                Console.WriteLine("Press the button in the first position.");
                Console.WriteLine("What number was it?");
                num4 = Convert.ToInt32(Console.ReadLine());
                pos4 = "first";
            }
            else if (num == 3 | num == 4)
            {
                Console.WriteLine("Press the button in the " + pos2 +" position.");
                Console.WriteLine("What number was it?");
                num4 = Convert.ToInt32(Console.ReadLine());
                pos4 = pos2;
            }

            //Stage 5.
            Console.WriteLine("Stage 5");
            Console.WriteLine("What the big number?");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1) { Console.WriteLine("Press the number " + num1 + "."); }
            else if (num == 2) { Console.WriteLine("Press the numner " + num2 + "."); }
            else if (num == 3) { Console.WriteLine("Press the number " + num4 + "."); }
            else if (num == 4) { Console.WriteLine("Press the number " + num3 + "."); }

            Console.ReadLine();
        } //End Memory

        static void ComplicatedWires()
        {
            string color = "blank";
            string yn = "no";
            bool star = false;
            bool led = false;
            bool even = false;
            bool parallel = false;
            bool battery = false;
            bool again = true;
            string ynm = "yes";

            Console.WriteLine("Is the last digit of the serial number even?");
            yn = Console.ReadLine();
            if (yn == "yes") { even = true; }
            Console.WriteLine("Is there a parallel port on the bomb? (long, pink, has holes in it.)");
            yn = Console.ReadLine();
            if (yn == "yes") { parallel = true; }
            Console.WriteLine("Are there two or more batteries on the bomb?");
            yn = Console.ReadLine();
            if (yn == "yes") { battery = true; }

            do
            {
                Console.WriteLine("What color is the wire? (w = white | r = red | b = blue | wr | wb | rb)");
                color = Console.ReadLine();
                Console.WriteLine("Is there a star?");
                yn = Console.ReadLine();
                if (yn == "yes") { star = true; }
                Console.WriteLine("Is there an LED?");
                yn = Console.ReadLine();
                if (yn == "yes") { led = true; }

                //DoICut(color, star, led, even, parallel, battery);
                //Can't figure this part out.  I'll mess with it later.

                if (color == "w")
                {
                    if (star == false && led == false) { Cut(); }
                    else if (star == true && led == true && battery == true) { Cut(); }
                    else if (star == true) { Cut(); }
                    else if (led == true) { Dont(); }
                }
                else if (color == "b")
                {
                    if (star == false && led == false && even == true) { Cut(); }
                    else if (star == true && led == true && parallel == true) { Cut(); }
                    else if (led == true && parallel == true) { Cut(); }
                    else if (star == true) { Dont(); }
                }
                else if (color == "r")
                {
                    if (star = false && led == false && even == true) { Cut(); }
                    else if (star == true && led == true && battery == true) { Cut(); }
                    else if (led == true && battery == true) { Cut(); }
                    else if (star == true) { Cut(); }
                }
                else if (color == "rb")
                {
                    if (star == false && led == false && even == true) { Cut(); }
                    else if (star == true && led == true) { Dont(); }
                    else if (led == true && even == true) { Cut(); }
                    else if (star == true && parallel == true) { Cut(); }
                }
                
                //if (even == false && parallel == false && battery == false) { }
                //else if (even == false && parallel == false && battery == true) { }
                //else if (even == false && parallel == true && battery == false) { }
                //else if (even == true && parallel == false && battery == false) { }
                //else if (even == false && parallel == true && battery == true) { }
                //else if (even == true && parallel == true && battery == false) { }
                //else if (even == true && parallel == false && battery == true) { }
                //else if (even == true && parallel == true && battery == true) { }

                //For the looping
                Console.WriteLine("Are there more wires?");
                ynm = Console.ReadLine();
                if (ynm == "no") { again = false; }
            } while (again == true);
        } //End Complicated Wires

        static void Cut() { Console.WriteLine("Cut the wire."); }
        static void Dont() { Console.WriteLine("Don't cut the wire."); }

        //static bool DoICut(color, star, led, even, parallel, battery)
        //{
            //bool cut = false;
            //if (led == true)
            //return cut;
        //}

    }  //End Class
}  //End all
