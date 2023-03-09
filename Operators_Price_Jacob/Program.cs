using System;

namespace Operators_Price_Jacob
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // int set
            
            //sets the two variables
            int fNumber1 = 1 * 1;
            int sNumber1 = 1 + 3;

            //prints out min a max of the two numbers
            Console.WriteLine("Min Number of Int Set" + Math.Min(fNumber1, sNumber1));
            Console.WriteLine("Max Number of Int Set" + Math.Max(fNumber1, sNumber1));

            //declares a bool for checking if the first num is greater than the second
            bool isIntGreater;

            //checks if the first num is greater than the second
            if (fNumber1 > sNumber1) isIntGreater = true;
            else
                isIntGreater = false;

            //write out the check
            Console.WriteLine(fNumber1 + " is greater than " + sNumber1 + ", " + isIntGreater);

            //creates an empty line
            Console.WriteLine();


            // short set
            short fNumber2 = 2 * 4;
            short sNumber2 = 1 + 3;

            Console.WriteLine("Min Number of short Set" + Math.Min(fNumber2, sNumber2));
            Console.WriteLine("Max Number of short Set" + Math.Max(fNumber2, sNumber2));

            bool isIntGreater2;

            if (fNumber2 > sNumber2) isIntGreater2 = true;
            else
                isIntGreater2 = false;

            Console.WriteLine(fNumber2 + " is greater than " + sNumber2 + ", " + isIntGreater2);
            Console.WriteLine();
            // long set
            long fNumber3 = 16 * 1;
            long sNumber3 = 1 + 3;

            Console.WriteLine("Min Number of long Set" + Math.Min(fNumber3, sNumber3));
            Console.WriteLine("Max Number of long Set" + Math.Max(fNumber3, sNumber3));

            bool isIntGreater3;

            if (fNumber3 > sNumber3) isIntGreater3 = true;
            else
                isIntGreater3 = false;

            Console.WriteLine(fNumber3 + " is greater than " + sNumber3 + ", " + isIntGreater3);
            Console.WriteLine();
            // float set
            float fNumber4 = 2.1f * 1;
            float sNumber4 = 5 + 3.25f;

            Console.WriteLine("Min Number of float Set" + Math.Min(fNumber4, sNumber4));
            Console.WriteLine("Max Number of float Set" + Math.Max(fNumber4, sNumber4));

            bool isIntGreater4;

            if (fNumber4 > sNumber4) isIntGreater4 = true;
            else
                isIntGreater4 = false;

            Console.WriteLine(fNumber4 + " is greater than " + sNumber4 + ", " + isIntGreater4);
            Console.WriteLine();

            // double set
            double fNumber5 = 7.1111111 * 1;
            double sNumber5 = 1 + 5.222222;

            Console.WriteLine("Min Number of Double Set" + Math.Min(fNumber5, sNumber5));
            Console.WriteLine("Max Number of Double Set" + Math.Max(fNumber5, sNumber5));

            bool isIntGreater5;

            if (fNumber5 > sNumber5) isIntGreater5 = true;
            else
                isIntGreater5 = false;

            Console.WriteLine(fNumber5 + " is greater than " + sNumber5 + ", " + isIntGreater5);

            Console.WriteLine();

            // decimal set
            decimal fNumber6 = 7.31m * 1;
            decimal sNumber6 = 1 + 6.75m;

            Console.WriteLine("Min Number of Decimal Set" + Math.Min(fNumber6, sNumber6));
            Console.WriteLine("Max Number of Decimal Set" + Math.Max(fNumber6, sNumber6));

            bool isIntGreater6;

            if (fNumber6 > sNumber6) isIntGreater6 = true;
            else
                isIntGreater6 = false;

            Console.WriteLine(fNumber6 + " is greater than " + sNumber6 + ", " + isIntGreater6);

        }
    }
}
