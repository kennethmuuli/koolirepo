using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Tund1911
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new StackTraceDemo();
            demo.Run();

            //===============================================
            //using (var inputStream = new FileStream("c:\\Users\\u-469\\Downloads\\17_11_2022-20221119T071956Z-001\\17_11_2022\\Muuli_Kenneth_Kavan3+.html", FileMode.OpenOrCreate))
            //using (var outputStream = new FileStream("c:\\temp\\Muuli_Kenneth_Kavan3+.html", FileMode.OpenOrCreate))
            //{
            //    var bytes = new byte[10000];
            //    var count = 0;

            //    do
            //    {
            //        count = inputStream.Read(bytes, 0, bytes.Length);
            //        outputStream.Write(bytes, 0, count);
            //        outputStream.Flush();
            //    }
            //    while (count > 0);

            //}


            //===============================================
            //var list = new ArrayList();
            //for (var i = 0; i < 100000; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        list.Add(i);
            //    }
            //    else
            //    {
            //        list.Add(i);
            //    }
            //}

            //var watch = new Stopwatch();
            //watch.Start();

            //foreach(var o in list)
            //{
            //    try
            //    {
            //        var s = o.ToString();
            //    }
            //    catch { }
            //}

            //watch.Stop();
            //Console.WriteLine("Long run", watch.Elapsed);

            //watch.Restart();
            //foreach (var o in list)
            //{
            //    if (o == null)
            //    {
            //        continue;
            //    }
            //    var s = o.ToString();

            //}

            //watch.Stop();
            //Console.WriteLine("Short run", watch.Elapsed);

            //===============================================
            //try
            //{
            //    object x = null;
            //    var s = x.ToString();

            //    //throw new DirectoryNotFoundException("Directory not found c:\\temp");
            //    //throw new ArgumentNullException("x");
            //}
            //catch(NullReferenceException nullex)
            //{

            //}
            //catch (FileNotFoundException fnfex)
            //{
            //    Console.WriteLine(fnfex);
            //}
            //catch (IOException ioex)
            //{
            //    Console.WriteLine(ioex);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);

            //    throw ex;
            //}
            //finally
            //{
            //    Console.Write("FINALLY!");
            //}

        }
    }
}
