namespace ISM4300.Deliverable_1
{

    /*
     *  Deliverable 1 - C# Programming: Conditional and Iterative Statements
     * */
    internal class Assignment_1
    {
        public static void DoAssignment1()
        {
            // Request input from the user with specified paramaters. 
            Console.WriteLine("Please enter an integer that is between 1 and 100: ");

            // Validate the input from the user.
            try
            {
                // Read the input and assign it to an integer. 
                int input = int.Parse(Console.ReadLine());

                // Checks if the input is within the range of the specified paramters.
                if ((input >= 1) && (input <= 100))
                {
                    // Acknowledges the input is not only an integer, but within range.
                    Console.WriteLine("You have chosen the integer: " + input + ".");

                    // Request input of series type.
                    Console.WriteLine("Please specify the series type: 'Odd' or 'Even'");

                    try
                    {
                        // Read the input and assign it to a string.
                        string series = Console.ReadLine().ToLower();

                        // Execute if the input is equal to 'odd'.
                        if (series == "odd")
                        {
                            Console.WriteLine("You have selected odd numbers. The odd numbers between 0 and " + input + " are: ");

                            for (int i = 1; i <= input; i += 2)
                            {
                                Console.WriteLine(i);
                            }

                        }
                        // Execute if the input is equal to 'even'.
                        else if (series == "even")
                        {
                            Console.WriteLine("You have selected even numbers. The even numbers between 0 and " + input + " are: ");

                            for (int i = 0; i <= input; i += 2)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        // Execute if the input is a string but neither 'Odd' nor 'Even'.
                        else
                        {
                            Console.WriteLine("Please restart the program and specify 'Odd' or 'Even'. \n" + "" +
                        "Please press any key to exit the program.");
                            Console.ReadKey();
                        }
                    }
                    // Execute if the user inputs a value that is not a string. 
                    catch
                    {
                        Console.WriteLine("Please restart the program and specify 'Odd' or 'Even'.");
                    }
                }
                // Execute if input is a integer but not within range.
                else
                {
                    Console.WriteLine("Please enter an integer that is between 1 and 100. \n" + "" +
                        "Please press any key to exit the program.");
                    Console.ReadKey();
                }

            }
            // If the user inputs a value that is not an integer request one on next attempt. 
            catch
            {
                Console.WriteLine("Please restart the program and enter an integer value.");
            }
        }
    }
}
