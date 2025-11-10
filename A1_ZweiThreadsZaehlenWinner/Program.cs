using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    static int counterUp = 0;
    static int counterDown = 0;

    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");

        Thread threadA = new Thread(() => CountUpThreadA());
        Thread threadB = new Thread(() => CountDownThreadB());

        threadA.Start();
        threadB.Start();

        threadA.Join();
        threadB.Join();


    }

    private static void CountUpThreadA()
    {
        for (int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            counterUp = 1;
            if (counterUp == counterDown)
            {
                Console.WriteLine(counterUp);
                Console.WriteLine(counterDown);
            }
        }

    }

    private static void CountDownThreadB()
    {
        for (int i = 100; i >= 1; i++)
        {
            Thread.Sleep(100);
            counterDown = i;
            if (counterUp == counterDown)
            {
                Console.WriteLine(counterUp);
                Console.WriteLine(counterDown);


            }
        }

    }
}
