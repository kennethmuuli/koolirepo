using System;
using System.Linq;
using System.Xml.Serialization;

public class Program
{
    public static void Main()
    {   
        var integers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Vaikseim vaartus
        //Console.WriteLine("Massiivi suurim vaartus on ");
        //Console.WriteLine(integers[integers.Length - 1]);
        //Console.WriteLine("\r\n");
        //var min = integers.Min();

        var min = int.MaxValue;
        foreach (var i in integers)
        {
            if (i < min)
            {
                min = i;
            }
        }
        Console.WriteLine("Min = " + min);

        //Suurim vaartus
        //Console.WriteLine("Massiivi vaikseim vaartus on ");
        //Console.WriteLine(integers[0]);
        //Console.WriteLine("\r\n");
        //var max = integers.Max();

        var max = int.MinValue;
        foreach (var i in integers)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("Max = " + max);

        //VAIKSEM JA SUURIM VAARTUS KORRAGA
        Console.WriteLine("Massiivi vaikseim ja suurim vaartus on ");

        min = int.MaxValue;
        max = int.MinValue;
        foreach (var i in integers)
        {
            if(i < min)
            {
                min = i;
            }
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("\r\n");

        integers.Min();


        //MASSIIVI ELEMENTIDE ARITMEETILINE KESKMINE
        Console.WriteLine("massiivi artimeetiline keskmine on ");
        int average = (int)integers.Average();
        Console.WriteLine(average);
        Console.WriteLine("\r\n");

        //Pikemalt
        //var sum = 0;
        //foreach (int i in integers)
        //{
        //    sum += i;
        //}
        //var average = sum / (double)integers.Length;
        //Console.WriteLine("Average: " + average);


        //PAARISARVUDE EEMALDAMINE LOENDIST
        Console.WriteLine("Paaritud arvud massivis on ");
        var integersList = new List<int>();

        integersList = new List<int>
        {
            1,2,3,4,5,6,7,8,9,10
        };

        for (var i = integersList.Count - 1; i >= 0; i--)
        {
            if (integersList[i] % 2 == 0)
            {
                integersList.RemoveAt(i);

            }       
        }

        foreach (var i in integersList)
        {
            Console.WriteLine(i);
        }




    }
} 
