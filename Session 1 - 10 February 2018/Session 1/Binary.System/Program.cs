using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary.System
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTransformations();
            Signes();
            //BinaryListing(26);
            Console.ReadKey();
        }

        /*
            https://en.wikipedia.org/wiki/Processor_register 

            How memory works 

            https://en.wikipedia.org/wiki/Computer_memory 

            https://en.wikipedia.org/wiki/Memory_hierarchy 

            ??? GUID VS LONG ???

            https://web.stanford.edu/class/cs101/bits-bytes.html 

            https://www.lifewire.com/the-difference-between-bits-and-bytes-816248 

            https://en.wikipedia.org/wiki/Byte
            
            https://lagunita.stanford.edu/courses/Engineering/CS101/Summer2014/about 

            https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/float 

            https://www.electronics-tutorials.ws/binary/bin_1.html
         */


        /// <summary>
        /// Convert class available 
        /// https://msdn.microsoft.com/en-us/library/system.convert(v=vs.110).aspx
        /// 
        /// LITERALS
        /// https://www.tutorialspoint.com/csharp/csharp_constants.htm
        /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#numeric-literal-syntax-improvements
        /// 
        /// HEXADECIMAL
        /// https://en.wikipedia.org/wiki/Hexadecimal
        /// 
        /// STRING INTERPOLATION
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interpolated-strings
        /// 
        /// 
        /// </summary>
        static void BinaryTransformations()
        {
            Console.WriteLine("BINARY TRANSFORMATIONS:");

            int a = 10;    //<- this is called a decimal literal
            PrintAsDecimalAndAsBinary(a);
            PrintAsDecimalAndAsComplete64BitBinary(a);

            int b = 4000000;
            PrintAsDecimalAndAsBinary(b);
            PrintAsDecimalAndAsHexadecimal(b);

            int c = 0x9a9a9a; //<- this is called a hexadecimal literal
            PrintAsDecimalAndAsBinary(c);

            int One = 0b0101010010101010;   //<- this is called a binary literal 
            PrintAsDecimalAndAsBinary(One);

            int Sixteen = 0b0001_0000;  //<- this is also a binary literal

            PrintAsDecimalAndAsBinary(Sixteen);

            //byte ba = 255;
            ////byte baa = 256;


        }

        static void BinaryListing(int iterations)
        {
            Console.WriteLine("Decimal to binary Listing");
            for(uint i =0; i <= iterations; i++)
            {
                UnsignedPrintAsDecimalAndAsBinary(i);
            }
        }


        private static void PrintAsDecimalAndAsBinary(int number)
        {
            
            Console.WriteLine($"variable has value in decimal:{number} and binary:{Convert.ToString(number, 2),20}");
        }


        private static void PrintAsDecimalAndAsComplete64BitBinary(int number)
        {
            Console.WriteLine("variable has value in decimal:{0} and binary:{1}",number, NumberToBinary(number,64));
        }


        public static string NumberToBinary(int number, int bitsLength = 32)
        {
            string result = Convert.ToString(number, 2).PadLeft(bitsLength, '0');

            return result;
        }


        private static void PrintAsDecimalAndAsHexadecimal(int number)
        {

            Console.WriteLine($"variable has value in decimal:{number} and hexadecimal:0x{Convert.ToString(number, 16)}");
        }


        /// <summary>
        /// https://www.electronics-tutorials.ws/binary/signed-binary-numbers.html
        /// </summary>
        static void Signes()
        {
            Console.WriteLine("SIGNES");

            int a = 255;
            PrintAsDecimalAndAsBinary(a);
            PrintAsDecimalAndAsComplete64BitBinary(a);
            PrintAsDecimalAndAsHexadecimal(a);

            int b = -255;
            PrintAsDecimalAndAsBinary(b);
            PrintAsDecimalAndAsComplete64BitBinary(b);
            PrintAsDecimalAndAsHexadecimal(b);

            uint aa = 255;
            UnsignedPrintAsDecimalAndAsBinary(aa);
            UnsignedPrintAsDecimalAndAsComplete64BitBinary(aa);
            UnsignedPrintAsDecimalAndAsHexadecimal(aa);

        }


        private static void UnsignedPrintAsDecimalAndAsBinary(uint number)
        {

            Console.WriteLine($"variable has value in decimal:{number,10} and binary:{Convert.ToString(number, 2), 20}");
        }


        private static void UnsignedPrintAsDecimalAndAsComplete64BitBinary(uint number)
        {
            Console.WriteLine("variable has value in decimal:{0} and binary:{1}", number, UnsignedNumberToBinary(number, 64));
        }
        public static string UnsignedNumberToBinary(uint number, int bitsLength = 32)
        {
            string result = Convert.ToString(number, 2).PadLeft(bitsLength, '0');
            
            return result;
        }

        private static void UnsignedPrintAsDecimalAndAsHexadecimal(uint number)
        {

            Console.WriteLine($"variable has value in decimal:{number} and hexadecimal:0x{Convert.ToString(number, 16)}");
        }


        /// <summary>
        /// LITTLE ENDIAN VS BIG ENDIAN
        /// 
        /// PADDING BYTES
        /// https://stackoverflow.com/questions/4829366/byte-to-binary-string-c-sharp-display-all-8-digits
        /// </summary>
        private static void BitConverterExample()
        {
            ///https://docs.microsoft.com/en-us/dotnet/api/system.bitconverter?view=netframework-4.7.1
        }


        ///https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-between-hexadecimal-strings-and-numeric-types
    }
}
