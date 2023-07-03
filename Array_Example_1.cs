namespace ISM4300
{
    /*
     * Lecture 6: Arrays
     */
    class Array_Example_1
    {
        public static void DoArrayExamples()
        {
            // An array of integer numbers. 
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Displays the first number in the numbers integer array.
            Console.WriteLine(numbers[0]);

            // An array of string values.
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            // Displays the first value in the cars string array.
            Console.WriteLine(cars[0]);

            // Demonstrating the ability to udpate array values.
            cars[0] = "Kia";
            Console.WriteLine(cars[1]);

            // A multidimensional array.
            int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(multiDimensionalArray[0, 0]);

            // Array property features.
            int length = numbers.Length;
            Console.WriteLine("The 'numbers' array length is: " + length.ToString());

            // Multidimensional array properties. 
            int dimension = multiDimensionalArray.Rank;
            Console.WriteLine("The 'multiDimensionaArray dimensions are: " + dimension.ToString());

            // Looping through an array.
            for (int k = 0; k < cars.Length; k++)
            {
                Console.WriteLine(cars[k]);
            }

            // Exclusive loop for arrays.
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int i = 0;
            foreach (int number in numbers)
            {
                numbers[i] = 2 * number + 1;
                Console.WriteLine(numbers[i]);
                i++;
            }

            // Sorting an array of string values.
            Array.Sort(cars);
            foreach (string l in cars)
            {
                Console.WriteLine(l);
            }

            // Sorting an array of integer values.
            int[] moreNumbers = { 5, 1, 8, 9 };
            Array.Sort(moreNumbers);
            foreach (int j in moreNumbers)
            {
                Console.WriteLine(j);
            }

            // Returns the largest value in the array.
            Console.WriteLine("The max value in 'moreNumbers' is: " + moreNumbers.Max().ToString());

            // Returns the lowest value in the array.
            Console.WriteLine("The minimum value in 'moreNumbers' is: " + moreNumbers.Min());

            // Returns the sum of the array.
            Console.WriteLine("The sum of 'moreNumbers' is: " + moreNumbers.Sum());
        }
    }
}
