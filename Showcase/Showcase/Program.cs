using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase
{
    class Program
    {
        static string kind;
        static string sarcastic;
        static string neutral;
        static string aggresive;
        static bool swer = false;
        /*This is just cause im lazy
          neutral = ("");
          aggresive = ("");
          sarcastic = ("");
          kind = ("");*/
        static void Answers()
        {
            Console.WriteLine("Press 1 for neutral answer");
            Console.WriteLine("Press 2 for sarcastic answer");
            Console.WriteLine("Press 3 for aggressive answer");
            Console.WriteLine("Press 4 for kind answer");
            string answer = Console.ReadLine();
            while (swer == false)
            {
                if (answer == "1")
                {
                    Console.WriteLine(neutral);
                    swer = true;
                }
                else if (answer == "2")
                {
                    Console.WriteLine(sarcastic);
                    swer = true;
                }
                else if (answer == "3")
                {
                    Console.WriteLine(aggresive);
                    swer = true;
                }
                else if (answer == "4")
                {
                    Console.WriteLine(kind);
                    swer = true;
                }
                else
                {
                    continue;
                }
            }
        }

        static void nextDialogue()
        {
            Console.WriteLine("Press space to enter next dialogue");
            string space = Convert.ToString(Console.ReadKey());
            if (space == " ")
            {

            }
        }

        static void clear()
        {
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guardian of Rome!!!");
            Console.WriteLine("You are now playing a line based video game.");
            Console.WriteLine("You will take command of Titanis Maxim.");
            Console.WriteLine("Your player that you are commanding is a legionnaire and you have a company of 100 men to fight with under the command");
            Console.WriteLine("of a centurion and then who is under command of commander Leonitus.");
            Console.WriteLine("You have came back to your family villa after a campaign into the british babarians territory.");
            Console.WriteLine("Your story of a roman legionnaire begins here with you to pick up the story");
            Console.WriteLine("Remember to hit enter after you input your answer.");
            nextDialogue();
            clear();
            Console.WriteLine("Father:Titanis!  I did not expect you to be here already?  Was your trip comfortable?");
            neutral = ("It wasn't the worst ride I've had.");
            aggresive = ("Are you really going to ask me if it was comfortable.  it wasn't.");
            sarcastic = ("Sure was with all the women around if you know what I mean haha.");
            kind = ("They treated me nicely on my way here and its a pleasure to see you again.");
            Answers();

        }
    }
}
