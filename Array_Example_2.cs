namespace ISM4300
{
    class Array_Example_2
    {
        /*
         * Lecture 7: Arrays
         */
        public static void DoAnotherArrayExample()
        {
            // Prompt the user for input.
            Console.WriteLine("Please enter an integer between 5 and 20: ");

            // Validate input for nulls.
            try
            {
                // The input value from the user.
                int input = int.Parse(Console.ReadLine());

                // Checking the input is within bounds. 
                if (input >= 5 && input <= 20)
                {
                    // Initializing the series.
                    int[] even = new int[input];
                    int[] odd = new int[input];
                    int[] fibonacci = new int[input];

                    // Additional initialization for the fibonacci series.
                    fibonacci[0] = 0;
                    fibonacci[1] = 1;

                    // Completes this iteration as many times as the input value says.
                    for (int i = 0; i < input; i++)
                    {
                        // Computes the next possible even number based on the iteration. 
                        even[i] = 2 * i;

                        // Computes the next possible odd number based on the iteration.
                        odd[i] = 2 * i + 1;

                        // Computes the next possible fibbonaci number based on the iteration.
                        if (i >= 2)
                        {
                            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                        }
                    }

                    // Outputs the even numbers.
                    Console.WriteLine("Even Numbers: ");
                    foreach (int number in even)
                    {
                        Console.WriteLine(number);
                    }

                    // Outputs the odd numbers.
                    Console.WriteLine("Odd Numbers: ");
                    foreach (int number in odd)
                    {
                        Console.WriteLine(number);
                    }

                    // Outputs the fibbonacci numbers.
                    Console.WriteLine("Fibonacci Numbers: ");
                    foreach (int number in fibonacci)
                    {
                        Console.WriteLine(number);
                    }

                }
                // Handles if the input is out of range. 
                else
                {
                    Console.WriteLine("Please press any key to exit, and try again with an integer within range.");
                    Console.ReadKey();
                }
            }
            // Catches the input if it is a null entry or not an integer.
            catch
            {
                Console.WriteLine("Please try again and enter an integer value.");
            }
        }
    }
}
