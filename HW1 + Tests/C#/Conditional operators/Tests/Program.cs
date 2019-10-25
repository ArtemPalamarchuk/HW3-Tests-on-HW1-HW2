using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }

    public class SomeClass
    {

        public static int Logic(int a, int b)
        {
            checked
            {
                if (a % 2 == 0)
                {
                    return (a * b);
                }
                else
                {
                    return (a + b);
                }
            }
        }

        public static String Task12(int x, int y)
        {
            String result = "";

            if (x > 0 && y > 0)
            {
                result = "I";
            }

            if (x > 0 && y < 0)
            {
                result = "IV";
            }

            if (x < 0 && y < 0)
            {
                result = "III";
            }

            if (x < 0 && y > 0)
            {
                result = "II";
            }

            if (x == 0 && y == 0)
            {
                result = "початок координат";
            }

            if (x == 0 && y != 0)
            {
                result = "Oy";
            }

            if (x != 0 && y == 0)
            {
                result = "Ox";
            }

            return result;
        }

        public static int Task13(int a, int b, int c)
        {
            int result = 0;

            if (a > 0)
            {
                result = result + a;
            }

            if (b > 0)
            {
                result = result + b;
            }

            if (c > 0)
            {
                result = result + c;
            }

            return result;
        }

        public static int Task14(int a, int b, int c)
        {
            int sum = a + b + c;
            int product = a * b * c;

            return (sum > product ? sum : product) + 3;
        }

        public static String Task15(int a)
        {
            String result = "";
            if (a >= 0 && a <= 19)
            {
                result = "F";
            }
            if (a >= 20 && a <= 39)
            {
                result = "E";
            }
            if (a >= 40 && a <= 59)
            {
                result = "D";
            }
            if (a >= 60 && a <= 74)
            {
                result = "C";
            }
            if (a >= 75 && a <= 89)
            {
                result = "B";
            }
            if (a >= 90 && a <= 100)
            {
                result = "A";
            }
            return result;
        }
    }

}
