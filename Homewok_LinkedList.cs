using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

class program
{
    static public void Main()
    {
        LinkedList<String> my_list = new LinkedList<String>();

        my_list.AddLast("Natalia");
        my_list.AddLast("Kiril");
        my_list.AddLast("Alexey");
        my_list.AddLast("Valentin");
        my_list.AddLast("Max");
        my_list.AddLast("Natalia");

        Console.WriteLine("Employees of the month " +
                         " in Marсh:");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Employees of the month" +
                         " in April:");

        my_list.Remove(my_list.First);

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Employees of the month" +
                         " in May:");

        my_list.Remove("Alexey");

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Employees of the month" +
                         " in June:");

        my_list.RemoveFirst();

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Employees of the month" +
                         " in July:");

        my_list.RemoveLast();

        foreach (string str in my_list)
        {
            Console.WriteLine(str);
        }

        my_list.Clear();

        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

    }
}

