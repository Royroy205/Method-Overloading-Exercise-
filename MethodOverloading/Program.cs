namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 12;
            var y = 25;
            var indAdd = Add(x, y);
            Console.WriteLine(indAdd);

            var decAdd = Add(100.00m, 200m);
            Console.WriteLine(decAdd);


            var boolAdd = Add(0, 1, true);
            Console.WriteLine(boolAdd);

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;

        }
        public static string Add(int num1, int num2, bool withDollar)
        {
            int sum = num1 + num2;

            if (withDollar && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (withDollar && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (withDollar && sum < 1)
            {
                return "Not enough money";

            }
            else 
            { 
              return $"{sum}";
            }


        }


    }
}  

    
