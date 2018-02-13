using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integers();
            //MathematicalFunctions();
            BigIntegerStructure();
            Console.ReadKey();
        }

        /// <summary>
        /// INT
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/int
        /// 
        /// CONVERSIONS
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/explicit-numeric-conversions-table
        /// 
        /// DATA TYPE RANGES
        /// https://msdn.microsoft.com/en-us/library/s3f49ktz.aspx
        /// 
        /// 
        /// WHAT DOES ++ AND -- DO EXACTLY?
        /// </summary>
        static void Integers()
        {

            uint a = 10;
            int b = -10;

            short c = 6000;
            ushort cc = 6000;

            long d = 340285903466547567;
            ulong dd = 340285903466547567L;

            long aLong = 22;
            //int i1 = aLong;       // Error: no implicit conversion from long.  
            int i2 = (int)aLong;  // OK: explicit conversion.  

            Console.WriteLine(Int16.MaxValue);   // ?what will output
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(Int64.MaxValue);
            Console.WriteLine(UInt16.MaxValue);   // ?what will output
            Console.WriteLine(UInt32.MaxValue);
            Console.WriteLine(UInt64.MaxValue);


            Console.WriteLine(Int16.MinValue);   // ?what will output
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(UInt16.MinValue);   // ?what will output
            Console.WriteLine(UInt32.MinValue);
            Console.WriteLine(UInt64.MinValue);

           int result = Int32.Parse("223435s");

            int outresult;
            bool s = Int32.TryParse("4235346", out outresult);

            Console.WriteLine($"value of parse{result}");

            int secondResult;
            bool actionResult = Int32.TryParse("9203845W345", out secondResult);
        }


        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/float
        /// </summary>
        static void FloatingPointOperators()
        {

            float a = 3.5F;  //<- always needs literal

            float f = 123; // ?? what happens

            double b = 3.5;  //doesnt need literal, default literal with . dot sign is a double always

            //float c = 3.5;   // <- compiler error

            //int x = 3.0;         // Error: no implicit conversion from double.  
            int y = (int)3.0;    // OK: explicit conversion.
        }


        static void Binary()
        {
            byte a = 0;

            char b = 'a';
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
        /// </summary>
        static void ConvertNumberToString()
        {
            
        }


        /// <summary>
        /// https://www.ict.social/csharp/basics/mathematical-functions-in-csharp-net-math-library
        /// </summary>
        static void MathematicalFunctions()
        {
            //mathematical operators + - * / % 

            int a = 3 % 2;

            int b = 6 % 2;

            int c = 9 % 3;

            Console.WriteLine($"3 % 2 is {a}");

            Console.WriteLine($"6 % 2 is {b}");

            Console.WriteLine($"9 % 3 is {b}");


            Console.WriteLine($"PI VALUE: {Math.PI}");
            Console.WriteLine($"e VALUE: {Math.E}");

            Console.WriteLine($"");
            // N, Z , Q,  R, C, Z()

            //Round(), Ceiling(), Floor() and Truncate()
            // 0.6   Ceiling() 1  F 
            // 0.4
            double mathround = 0.6;
            Console.WriteLine("Ceiling, FLOOR, ROUNd, truncate");
            Console.WriteLine(Math.Ceiling(mathround));
            Console.WriteLine(Math.Floor(mathround));
            Console.WriteLine(Math.Round(mathround));
            Console.WriteLine(Math.Truncate(mathround));

            mathround = 0.4;
            Console.WriteLine("Ceiling, FLOOR, ROUNd,truncate");
            Console.WriteLine(Math.Ceiling(mathround));
            Console.WriteLine(Math.Floor(mathround));
            Console.WriteLine(Math.Round(mathround));
            Console.WriteLine(Math.Truncate(mathround));

            mathround = -0.6;
            Console.WriteLine("Ceiling, FLOOR, ROUNd,truncate");
            Console.WriteLine(Math.Ceiling(mathround));
            Console.WriteLine(Math.Floor(mathround));
            Console.WriteLine(Math.Round(mathround));
            Console.WriteLine(Math.Truncate(mathround));

            mathround = -0.4;
            Console.WriteLine("Ceiling, FLOOR, ROUNd,truncate");
            Console.WriteLine(Math.Ceiling(mathround));
            Console.WriteLine(Math.Floor(mathround));
            Console.WriteLine(Math.Round(mathround));
            Console.WriteLine(Math.Truncate(mathround));


            double e = 2.72;
            int f = (int)Math.Round(e);

            decimal decimalNumber;

            decimalNumber = 32.7865m;
            // Displays 32
            Console.WriteLine(Math.Truncate(decimalNumber));

            decimalNumber = -32.9012m;
            // Displays -32         
            Console.WriteLine(Math.Truncate(decimalNumber));
        }

        /// <summary>
        /// https://msdn.microsoft.com/en-us/library/system.numerics.biginteger(v=vs.110).aspx
        /// </summary>
        static void BigIntegerStructure()
        {
            BigInteger bigIntFromDouble = new BigInteger(179032.6541);
            Console.WriteLine(bigIntFromDouble);
            BigInteger bigIntFromInt64 = new BigInteger(934157136952);
            Console.WriteLine(bigIntFromInt64);
            // The example displays the following output:
            //   179032
            //   934157136952

            string positiveString = "91389681247993671255432112000000";
            BigInteger a = BigInteger.Parse(positiveString);
            Console.WriteLine(a);

            BigInteger c;

            c = bigIntFromDouble + bigIntFromInt64;
            c = BigInteger.Add(bigIntFromDouble, bigIntFromInt64);
        }
    }
}
