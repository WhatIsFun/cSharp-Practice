namespace cSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Fibonacci(n);

            Console.WriteLine("The " + n + "th Fibonacci number is " + result);
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        //Write a recursive function to calculate the factorial of a given number. The factorial of a non-negative integer n is the product of all positive integers less than or equal to n. 

        //    Console.WriteLine("Enter a number:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    //int res = Factorial(n);




        //    Console.WriteLine("The factorial of " + n + " is " + res);
        //}
    }
}