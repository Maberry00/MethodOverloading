namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add(10, 20);
            //Add(2.2, 5.5);
            //Add(5, 3, true);
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(double num1, double num2)
        { 
            Console.WriteLine(num1 + num2);
        }

        public static void Add(int num1, int num2, bool Dollars)
        {
            if (Dollars && (num1 + num2) !=1)
            {
                Console.WriteLine($"{num1 + num2} dollars");
            }
            else if (Dollars && (num1 + num2) ==1) 
            {
                Console.WriteLine($"{num1+num2} dollars");
            }
            else 
            {
                Console.WriteLine($"{num1+num2}");
            }

        }

    }
}
