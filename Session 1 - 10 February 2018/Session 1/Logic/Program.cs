using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicLogicalOperators();
            //PerformBooleanOperation();
            //BitWiseOperators();
            BitWiseShifting();
            Console.ReadKey();
        }

        /// <summary>
        /// https://en.wikipedia.org/wiki/Truth_table
        /// </summary>
        static void BasicLogicalOperators()
        {
            bool a = true;
            Console.WriteLine($"boolean value is {a} and negated is {!a}");  // ! is NEGATION OPERATOR

            //other operators 
        }

        static void PerformBooleanOperation()
        {

            bool first;
            bool second;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Operations: and, or, negate");
                var operation = Console.ReadLine();

                switch (operation)
                {
                    case "and":
                        {
                            Console.WriteLine("Values: true,false");
                            try
                            {
                                first = Boolean.Parse(Console.ReadLine());
                                second = Boolean.Parse(Console.ReadLine());
                            }
                            catch 
                            {
                                break;
                            }
                            

                            Console.WriteLine($"{first} and {second} is {first && second}");
                            break;
                        }
                    case "or":
                        {
                            Console.WriteLine("Values: true,false");
                            try
                            {
                                first = Boolean.Parse(Console.ReadLine());
                                second = Boolean.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                break;
                            }

                            Console.WriteLine($"{first} and {second} is {first || second}");
                            break;
                        }

                    case "negate":
                        {
                            try
                            {
                                first = Boolean.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                break;
                            }

                            Console.WriteLine($"{first} negated is {!first}");
                            break;
                        }
                    default:Console.Clear();
                        continue;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        /// <summary>
        /// https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm 
        /// 
        /// https://msdn.microsoft.com/en-us/library/17zwb64t.aspx
        /// </summary>
        static void BitWiseOperators()
        {
            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;             /* 0  = 0000 0000 */

            PrintAsDecimalAndAsBinary(a);
            PrintAsDecimalAndAsBinary(b);

            Console.WriteLine("Bitwise and");
            c = a & b;             /* 12 = 0000 1100 */
            PrintAsDecimalAndAsBinary(c);

            Console.WriteLine("Bitwise or");
            c = a | b;             /*      0011 1101 */
            PrintAsDecimalAndAsBinary(c);

            Console.WriteLine("Bitwise xor");
            c = a ^ b;
            PrintAsDecimalAndAsBinary(c);

            Console.WriteLine("Bitwise not");

            PrintAsDecimalAndAsBinary(a,32);
            c = ~a;
            PrintAsDecimalAndAsBinary(c,32);


            int on = 0b0001;
            int off = 0b0010;
            int sleep = 0b1010; 

            int state = 0b0010;

            PrintAsDecimalAndAsBinary(on);
            PrintAsDecimalAndAsBinary(off);
            PrintAsDecimalAndAsBinary(state);
            PrintAsDecimalAndAsBinary(state ^ on);
            PrintAsDecimalAndAsBinary(state ^ off);
            PrintAsDecimalAndAsBinary(state ^ sleep);

            //xor tricks
        }


        private static void PrintAsDecimalAndAsBinary(int number, int padding = 8)
        {

            Console.WriteLine($"variable has value in decimal:{number,3} and binary:{NumberToBinary(number, padding),8}");
        }

        public static string NumberToBinary(int number, int bitsLength = 32)
        {
            string result = Convert.ToString(number, 2).PadLeft(bitsLength, '0');

            return result;
        }
        
        static void BitWiseShifting()
        {
            ///todo
            int a = 0b0011_1100;  /* 60  = 0011 1100 */
            int c = a << 2;       /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - Value of c is {0}", c);

            c = a >> 2;      /* 15 = 0000 1111 */

            int d = 0b11;
            int e = d << 62 | d >> 2; ;
            PrintAsDecimalAndAsBinary(d, 32);
            PrintAsDecimalAndAsBinary(d >> 4, 32);
            PrintAsDecimalAndAsBinary(e, 32);

        }

        public static void Expressions()
        {
            int a = 3;
            int b = 4;
            int c = 5;

            bool d = (a > b) || (a > c) || (c < b);   // expression evaluated and returned a boolean result
        }


        public static void ConditionalOperator()
        {
            //what is the conditional operator?

            int a = 3;

            int b = (a > 2) ? (a < 3)? 3 : 5 : 5;
        }
    }
}
