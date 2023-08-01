namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 12;
            var y = 25;
            var indAdd = add(x, y);
            Console.WriteLine(indAdd);

            var decAdd = add(100.00m, 200m);
            Console.WriteLine(decAdd);


            var boolAdd = add(2, 2, true);
            Console.WriteLine(boolAdd);

        }
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static decimal add(decimal x, decimal y)
        {
            return x + y;

        }
        public static string add(int num1, int num2, bool withDollars)
        {
            int sum = num1 = num2;

            if (withDollars && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (withDollars && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum}";
            }



        }


    }
}  

    
