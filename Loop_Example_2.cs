namespace ISM4300
{
    /*
     *  Lecture 4: Loops
     */
    class Loop_Example_2
    {
        public static void DoLoops()
        {
            Console.WriteLine("Enter an integer between 0 and 20: ");

            try
            {
                int input = int.Parse(Console.ReadLine());

                if ((input >= 0) && (input <= 5))
                {
                    Console.WriteLine("For Loop Iterations: " + input.ToString());

                    for (int i = 0; i <= input; i++)
                    {
                        Console.WriteLine("The value of the iteration variable is: " + i.ToString());
                    }

                    Console.WriteLine("Please press any key to exit the program.");
                    Console.ReadKey();
                }
                else if ((input > 5) && (input <= 15))
                {
                    Console.WriteLine("While Loop Iterations: " + input.ToString());

                    int j = 0;
                    while (j < input)
                    {
                        Console.WriteLine("The value of the iteration variable is: " + j.ToString());
                        j++;
                    }

                    Console.WriteLine("Please press any key to exit the program.");
                    Console.ReadKey();
                }
                else if ((input > 15) && (input <= 20))
                {
                    Console.WriteLine("Do/While Loop Iterations: " + input.ToString());

                    int k = 0;
                    do
                    {
                        Console.WriteLine("The value of the iteration variable is: " + k.ToString());
                        k++;
                    } while (k <= input);

                    Console.WriteLine("Please press any key to exit the program.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter an integer that is between 0 and 20. \n" + "" +
                        "Please press any key to exit the program.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value.");
            }
        }
    }
}
