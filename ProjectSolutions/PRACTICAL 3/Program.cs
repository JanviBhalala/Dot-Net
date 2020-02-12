using System;

namespace PRACTICAL_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int value;
            String s;
            Boolean b;
            Console.WriteLine("1. for Binary To Decimal");
            Console.WriteLine("2. for Decimal To Hex");
            Console.WriteLine("3. for Decimal To Binary");
            Console.WriteLine("4. for Decimal To Octal");
            Console.WriteLine("Enter Your Choice...!!");
            //   char.TryParse(Console.ReadLine(),out choice);
            int ch;
            b = int.TryParse(Console.ReadLine(), out ch);
           
            
            switch (ch)
            {
                case 1 :
                    Console.WriteLine("Enter Binary Value..");
                   // value = 111;
                    b= int.TryParse(Console.ReadLine(), out value);
                    Console.WriteLine("Binary Number:"+ value);
                    binaryToDecimal(value);
                    break;
                case 2:
                    Console.WriteLine("Enter Decimal Value..");
                    b = int.TryParse(Console.ReadLine(), out value);
                    //value = 13;
                    Console.WriteLine("Decimal Number:"+ value);
                    decimalToHex(value);
                    

                    break;
                case 3:
                    Console.WriteLine("Enter Decimal Value..");
                    b = int.TryParse(Console.ReadLine(), out value);
                   // value = 8;
                    Console.WriteLine("Decimal Number:"+ value);
                    decimalToBinary(value);
                    break;
                case 4:
                    Console.WriteLine("Enter Decimal Value..");
                    b = int.TryParse(Console.ReadLine(), out value);
                    //value = 12;
                    Console.WriteLine("Decimal Number:"+ value);
                    decimalToOctal(value);
                    break;
                default:
                    break;
            }
        }
        static void decimalToBinary(int n)
        {
            int  i;
            int[] a = new int[10];
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

        }
        static void binaryToDecimal(int num)
        {
            int binVal, decVal = 0, baseVal = 1, rem;
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
           // Console.Write("Binary Number: " + binVal);
            Console.Write("\nDecimal: " + decVal);
            Console.ReadLine();
        }
        static void decimalToHex(int n)
        {
            int i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[100];
            char temp1;
            while (n != 0)
            {
                temp = n % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                n= n / 16;
            }
            Console.Write("Equivalent HexaDecimal Number is ");
            for (j = i - 1; j > 0; j--)
                Console.Write(hexadecimalNumber[j]);
            Console.Read();
        }
        static void decimalToOctal(int n)
        {
            int   i = 1, j;
            int[] octalVal = new int[80];
           
            while (n != 0)
            {
                octalVal[i++] = n % 8;
                n = n / 8;
            }
            Console.Write("Octal Number: ");
            for (j = i - 1; j > 0; j--)
                Console.Write(octalVal[j]);
            Console.Read();
        }
        
    }
}
