namespace ISM4300
{
    /*
     *  Lecture 5: Methods
     */
    class Method_Example_1
    {
        /*
         *  Demonstrating a function belonging to a class that does not return a value because it is a method. 
         */
        public static void PrintExecutionMethod()
        {
            Console.WriteLine("I have just been executed!");
        }

        /*
         * Demonstrating a method that utilizes arguments. 
         */
        public static void PrintName(string name, int age)
        {
            Console.WriteLine(name + " is " + age + " years old.");
        }

        /*
         * Demonstrating a method that returns a value. 
         */
        public static int DoMultiplication(int x, int y)
        {
            return x * y;
        }

        /*
         * Demonstrating a function that utilizes an array.
         */
        public static void DoArrayExample()
        {
            int[] numbers = { 2, 2, 3, 5, 9 };

            Console.WriteLine("Please enter an integer number: ");

            try
            {
                int input = int.Parse(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int i = DoMultiplication(number, input);
                    Console.WriteLine("\n" + i);
                }
            }
            catch
            {
                Console.WriteLine("Please try again, but with an integer value.");
            }

        }
    }
}
