namespace HappySnailSimpleMath
{
    public class SimpleMath
    {
        public static int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double AddNums(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double DivideNums(double num1, double num2)
        {
            return num1 / num2;
        }

        public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
