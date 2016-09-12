using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)

        {
            string cont;

               Console.WriteLine("Welcome to the Grand Circus Casino!\n");
               Console.WriteLine("Roll the dice? (y/n) : \n ");
                string input = Console.ReadLine();
                Console.WriteLine();
                do { {
                    Dice newRun = new Dice();
                    newRun.Roll();
                    Console.WriteLine("Roll:");
                    Console.WriteLine("{0}", newRun.Die1);
                    Console.WriteLine("{0}", newRun.Die2);
                    Console.WriteLine();
                    Console.WriteLine("Roll again? (y/n)\n");
                    cont = Console.ReadLine();
                    Console.WriteLine();
                }
            }

            while (cont == "y");
            Console.WriteLine("Goodbye!\n");
        }
        class Dice
        {
            public int die1;
            public int die2;

            public int Die1
            {
                get { return die1; }
                set { die1 = value; }
            }

            public int Die2
            {
                get { return die2; }
                set { die2 = value; }
            }

            public void Roll()
            {

                Random rand1 = new Random();
                Die1 = rand1.Next(1, 6);
                Die2 = rand1.Next(1, 6);
            }

        }

        class DiceRollerApp
        {
          

        }

    }
}