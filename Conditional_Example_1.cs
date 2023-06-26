/*
 *  Lecture 1: Conditional Statements (C#)
 */
namespace ISM4300
{
    class Conditional_Example_1
    {
        public static void PracticeConditionals()
        {
            // If, else if, and else statement example.
            Console.WriteLine("Enter an integer number: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i > 1000)
            {
                Console.WriteLine("The input is greater than 1000.");
            }
            else if ((i > 500) && (i <= 1000))
            {
                Console.WriteLine("Input is between 500 and 1000.");
            }
            else
            {
                Console.WriteLine("The input is less than 1000.");
            }

            // Switch statement example.
            Console.WriteLine("Enter a second integer number: ");
            int i2 = int.Parse(Console.ReadLine());

            switch (i2)
            {
                case 0:
                    Console.WriteLine("The input is 0.");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine("The input is 1.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("The input is 2.");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("The specified input is not in range [0, 2].");
                    break;
            }

            // Try-catch block statement.
            try
            {
                Console.WriteLine("Enter a third integer number: ");
                int i3 = int.Parse(Console.ReadLine());
                Console.WriteLine("The input is : " + i3 + ".");
            }
            catch
            {
                Console.WriteLine("Please use an integer number.");
                Console.ReadKey();
            }
        }
    }
}
