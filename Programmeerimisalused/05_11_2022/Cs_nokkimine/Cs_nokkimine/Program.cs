using System;
using System.Collections;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        var integers = new int[10];

        //Pikem versioon massiivi lahti kirjutamiseks
        integers[0] = 1;
        integers[1] = 2;
        integers[2] = 3;
        integers[3] = 4;
        integers[4] = 5;
        integers[5] = 6;
        integers[6] = 7;
        integers[7] = 8;
        integers[8] = 9;
        integers[9] = 10;

        //Lyhem versioon massiivi lahti kirjutamiseks
        integers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //foreach (int i in integers)
        //{
        //    Console.WriteLine(i);
        //    //Ekraanile rea kirjutamine Console.WriteLine
        //    //Console.WriteLine(Environment.NewLine);
        //    //Alternatiiveselt Console.Write("\r\n");
        //}

        //for(int i = 0; i < integers.Length; i++)
        //{
        //    Console.WriteLine(integers[i]);
        //}

        //for (int counter = 0; counter < integers.Length; counter++)
        //{
        //    var i = integers[counter];
        //    Console.WriteLine(i);
        //}

        //var counter = 0;
        //while (counter < integers.Length)
        //{
        //    var i = integers[counter];
        //    Console.WriteLine(i);
        //    counter++;
        //}


        //foreach (int i in integers)
        //{
        //    //kui i jagamisel 2 = jaak 0 (kehtib paaritute arvude puhul) siis hyppa sellest indeksist yle
        //    if (i % 2 == 0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //foreach (int i in integers)
        //{
        //    if (i > 5)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}

        var integersList = new List<int>();

        //Pikem versioon
        integersList.Add(1);
        integersList.Add(2);
        integersList.Add(3);
        integersList.Add(4);
        integersList.Add(5);
        integersList.Add(6);
        integersList.Add(7);
        integersList.Add(8);
        integersList.Add(9);
        integersList.Add(10);

        //Lyhem versioon, list initializer
        integersList = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        integersList.Insert(0, 0);
        integersList.Remove(10);
        integersList.Add(11);

        //foreach (var i in integersList)
        //{
        //    Console.WriteLine(i);
        //}



        
        var millionList = new List<int>();
        for(var i = 0; i < 1000000; i++)
        {
            millionList.Add(i);
        }

        var millionArrayList = new ArrayList();
        for (var i = 0; i < 1000000; i++)
        {
            millionArrayList.Add(i);
        }

        //HEA NAIDE: Kui kaua votab kood aega. Jalgi ka start, stop valjakutseid ja .Elapsed aega
        var watch = new Stopwatch();
        //HALB NAIDE: Kui kaua votab kood aega.
        var start = DateTime.Now;
        watch.Start();
        foreach (var i in millionArrayList)
        {
            int x = (int)i;
        }
        watch.Stop();
        var end = DateTime.Now;

        Console.WriteLine("Array list");
        Console.WriteLine(end - start);
        Console.WriteLine(watch.Elapsed);

        //HEA NAIDE: Kui kaua votab kood aega. Jalgi ka start, stop valjakutseid ja .Elapsed aega
        watch = new Stopwatch();
        //HALB NAIDE: Kui kaua votab kood aega.
        start = DateTime.Now;
        watch.Restart();
        foreach (var i in millionList)
        {
            var x = i;
        }
        watch.Stop();
        end = DateTime.Now;

        Console.WriteLine(" ");
        Console.WriteLine("List<int>");
        Console.WriteLine(end - start);
        Console.WriteLine(watch.Elapsed);
    }

}