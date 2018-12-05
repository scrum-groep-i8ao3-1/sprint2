using System;
class program
{
    public static void Main()
    {
        Console.Write("Geef een Decimal: ");
        int DecimalNumber = int.Parse(Console.ReadLine());

        int remainder;
        string result = string.Empty;
        while (DecimalNumber > 0)
        {
            remainder = DecimalNumber % 2;
            DecimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary:  {0}", result);
        Console.ReadLine();


        int decimalNumber, quotient;
        int i = 1, j, temp = 0;
        char[] hexadecimalNumber = new char[100];
        char temp1;
        Console.WriteLine("Geef een decimaal:");
        decimalNumber = int.Parse(Console.ReadLine());
        quotient = decimalNumber;
        while (quotient != 0)
        {
            temp = quotient % 16;
            if (temp < 10)
                temp = temp + 48;
            else
                temp = temp + 55;
            temp1 = Convert.ToChar(temp);
            hexadecimalNumber[i++] = temp1;
            quotient = quotient / 16;
        }
        Console.Write("Equivalent HexaDecimal Number is ");
        for (j = i - 1; j > 0; j--)
            Console.Write(hexadecimalNumber[j]);
        Console.Read();

    }
}
