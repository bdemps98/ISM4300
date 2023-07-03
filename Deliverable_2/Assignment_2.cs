namespace ISM4300.Deliverable_2
{
    /*
     *  Deliverable 2 - C# Programming: Arrays and Methods
     **/
    class Assignment_2
    {
        public static void DoAssignment2()
        {
            // Requests input from the user.
            Console.WriteLine("Please enter an integer number between 5 and 15: ");

            // Validates the input is not null
            try
            {
                // Reads the users input and assigns it to a local integer variable.
                int input = int.Parse(Console.ReadLine());

                // Checks if the users input is within bounds. 
                if (input >= 5 && input <= 15)
                {
                    // Initializes a random array based on the input length.
                    int[] array = getRandomArray(input);

                    // Outputs the values within the array.
                    Console.Write("The elements in the random array are: ");
                    foreach (int i in array)
                    {
                        Console.Write(i + " ");
                    }

                    // Outputs the sum of the array.
                    Console.WriteLine("\nThe sum of the random array is: " + getSumOfArray(array));
                }
                // Handles the outcome where the users input is out of bounds.
                else
                {
                    Console.WriteLine("Please try again and enter a number that is within bounds.");
                    Console.ReadKey();
                }
                // Handles the outcome where the users input is not an integer or null.
            }
            catch
            {
                Console.WriteLine("Please try again and enter a valid integer value.");
            }
        }

        // Generates and returns an array with random integers between 10 and 50.
        static int[] getRandomArray(int arrayLength)
        {
            // New random object for the randomization of the array values.
            Random random = new Random();

            // Initializes an array that will be returned.
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                // Assigns the current iteration a random number between 10 and 50.
                array[i] = random.Next(10, 50);
            }

            // Returns the randomly generated array.
            return array;
        }

        // Returns the sum of the values within an integer array.
        static int getSumOfArray(int[] array)
        {

            // Initializes an integer that will be returned.
            int sum = 0;

            // Iterates through the entire legnth of the array.
            foreach (int i in array)
            {
                // Adds to the sum.
                sum += i;
            }

            // Returns the sum. 
            return sum;
        }
    }
}
