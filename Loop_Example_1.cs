namespace ISM4300
{
    /*
     *  Lecture 3: Loops
     */
    class Loop_Example_1
    {
        public static void GetEvenAndOddNumbers()
        {
            Console.WriteLine("Enter a positive integer: ");
            Boolean done = false;

            while (!done)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The input is: " + input);

                    Console.WriteLine("\nList of " + input + " even numbers: ");
                    for (int i = 0; i < input; i++)
                    {
                        int even = 2 * i;
                        Console.WriteLine(even + " is an even number.");
                    }

                    Console.WriteLine("\nList of " + input + " odd numbers: ");
                    int odd = 1;
                    int counter = 0;
                    do
                    {
                        Console.WriteLine(odd + " is an odd number.");
                        odd = odd + 2;
                        counter++;
                    } while (counter < input);

                    done = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
        }
    }
}
