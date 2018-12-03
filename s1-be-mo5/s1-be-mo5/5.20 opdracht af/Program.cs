using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DisariumNumbers
{
    //length telt hoe veel getalen in het numer zitten  
    public static int length(int ran)
    {
        int length = 0;
        while (ran != 0)
        {
            length = length + 1;
            ran = ran / 10;
        }
        return length;
    }

    //sum berekenen
    public static int sumteken(int num)
    {
        int sum = 0, rem = 0;
        int len = length(num);

        while (num > 0)
        {
            rem = num % 10;
            sum = sum + (int)Math.Pow(rem, len);
            num = num / 10;
            len--;
        }
        return sum;
    }

    public static void Main()
    {
        int result = 0;

        //getallen ivoeren en laten zien  
        Console.WriteLine("Disarium numbers between 10 and 1.000.000 are");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            result = sumteken(i);

            if (result == i)
                Console.Write(i + " ");
        }
        Console.ReadKey();
    }
}

