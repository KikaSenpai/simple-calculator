using System;
using System.Reflection.Emit;

class Program
{

    static double Add(double firstnumber, double secondnumber)
    {
        return firstnumber + secondnumber;
    }

    static double Subtract(double firstnumber, double secondnumber)
    {
        return firstnumber - secondnumber;
    }

    static double Multiply(double firstnumber, double secondnumber)
    {
        return (firstnumber * secondnumber);
    }

    static double Divide(double firstnumber, double secondnumber)
    {
        return firstnumber / secondnumber;
    }


    static void Main()
    {
        double answer = 0;

        while (true)
        {

            Console.WriteLine("Please input your first number.");
            double firstnumber;
            while (!double.TryParse(Console.ReadLine(), out firstnumber))
            {
                Console.WriteLine("Please input a valid number.");
            }
       
                Console.WriteLine("Please input your second number.");
            bool completion = false;
            while (!completion)
            {
                double secondnumber;
                while (!double.TryParse(Console.ReadLine(), out secondnumber))
                {
                    Console.WriteLine("Please input a valid number.");
                }

                    Console.WriteLine("Please select an operation.\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
                while (true)
                {

                    int response;

                    {
                        while (!int.TryParse(Console.ReadLine(), out response))
                        {
                            Console.WriteLine("Please input a valid option.(1-4)");
                            continue;
                        }
                    }

                    if (response == 4 && secondnumber == 0)
                    {
                        Console.WriteLine("Cannot divide by 0. Please input a different second number.");
                        break;
                    }

                    switch (response)
                    {
                        case 1:
                            answer = Add(firstnumber, secondnumber);
                            break;

                        case 2:
                            answer = Subtract(firstnumber, secondnumber);
                            break;

                        case 3:
                            answer = Multiply(firstnumber, secondnumber);
                            break;

                        case 4:
                            answer = Divide(firstnumber, secondnumber);
                            break;

                        default:
                            Console.WriteLine("Please input a valid option.(1-4)");
                            continue;

                    }


                    Console.WriteLine($"Your answer is {answer:0.##}.");

                    completion = true;
                    break;
                }
                
            }

            string answer2;

            do
            {
                Console.WriteLine("Would you like to continue?");
                answer2 = Console.ReadLine().ToUpper();

                if (answer2 != "YES" && answer2 != "NO")
                {
                    Console.WriteLine("Please input a valid response. (Yes or no)");
                }

            } while (answer2 != "YES" && answer2 != "NO");

            if (answer2 == "NO")
            {
                Console.WriteLine("Thank you for using my calculator.");
                break;
            }

        }
    }
}
    


   