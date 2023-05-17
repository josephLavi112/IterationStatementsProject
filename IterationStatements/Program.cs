using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0

            var myNum = 0;



            // Create a do-while loop and use the template below:
            

            do
            {
                 myNum++;
                // Increment num by 1

                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(myNum);

            } while (myNum < 100); // <---- While your variable is less than 100


                        // Create a while loop
            
             while(myNum<200)           // <--- While num is less than 200
            {
                myNum++;
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop
                numbers.Add(myNum);

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers

            foreach (var myNumbers in numbers)
            {
                Console.WriteLine(numbers);
                //In the scope of the foreach loop, print each number in numbers
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
             {
                Console.WriteLine(i);
             }
          
            //------------End of exercise
        }
    }
}
