using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
    int counterUp = 0;
    int counterDown = 0;
    
    Thread threadA = new Thread CountUpThreadA();
    Thread threadB = new Thread CountDownThreadB();

    threadA.Start();
    threadB.Start();

    threadA.Join();
    threadB.Join();

   
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        
        
    }
    
    private static void CountUpThreadA()
    {
        for(int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            counterUp++;
        }
        
    }
    
    private static void CountDownThreadB()
    {
        for(int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            counterDown--;
        }
       
    }
}
