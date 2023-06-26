namespace ISM4300
{
    /*
     *  Lecture 2: Conditional Statements (C#)
     */
    class Conditional_Example_2
    {
        public static void GetGrade()
        {
            try
            {
                Console.WriteLine("Enter the grade you believe you will get in ISM 4300: ");
                int grade = int.Parse(Console.ReadLine());

                if ((grade >= 0) && (grade <= 100))
                {
                    if (grade < 60)
                    {
                        Console.WriteLine("Your letter grade is F.");
                    }
                    else if (grade < 70)
                    {
                        Console.WriteLine("Your letter grade is D.");
                    }
                    else if (grade < 80)
                    {
                        Console.WriteLine("Your letter grade is C.");
                    }
                    else if (grade < 90)
                    {
                        Console.WriteLine("Your letter grade is B.");
                    }
                }
                else
                {
                    Console.WriteLine("Your letter grade is A.");
                }

                Console.WriteLine("Please press any key to exit.");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 0 and 100.");
            }
        }
    }
}
