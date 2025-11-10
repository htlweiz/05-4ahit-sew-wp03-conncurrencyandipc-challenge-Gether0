using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    static int counterUp = 0;
    static int counterDown = 0;

    static string winner = "";

    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");

        Thread threadA = new Thread(() => CountUpThreadA());
        Thread threadB = new Thread(() => CountDownThreadB());

        threadA.Start();
        threadB.Start();

        threadA.Join();
        threadB.Join();

        if (counterUp < 50)
        {
            Console.WriteLine("thread1");
        }
        //...

    }

    private static void CountUpThreadA()
    {
        for (int i = 1; i <= 100; i++)
        {
            counterUp = 1;
            if (counterUp == counterDown)
            {
                break;
            }
            Thread.Sleep(1);
        }

    }

    private static void CountDownThreadB()
    {
        for (int i = 100; i >= 1; i++)
        {
            counterDown = i;
            if (counterUp == counterDown)
            {
                break;
            }
            Thread.Sleep(1);
        }
        

    }
}
