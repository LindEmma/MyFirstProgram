// Emma Lind, Edugrade.NET23

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* An if else-statement that prints one message if the number is
               greater than 10 and another if it isn't.*/

            int number = 5;
            if (number>10)
            { Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj, lågt tal!");
            }

            /* When the user answer with their name the console
             outputs "Hej" + name. */

            Console.Write("Vad heter du? ");
            String name = Console.ReadLine(); //Users answer is saved as a string in the name-variable.
            Console.WriteLine("Hej " + name +"!");

            /* for-loop that counts from 0-5.
             * i starts at 0, has a max value of 5 (the value of "number")
               and adds 1 for each loop.*/

            for (int i=0; i <= number; i++) 
                                           
            {
                Console.WriteLine(i); //Outputs the value of i as long as it meets the for-loops requirements.
            }
        }
       
    }
}