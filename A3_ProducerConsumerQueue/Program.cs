using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace A3_ProducerConsumerQueue;

class Program
{
    public static void Main(string[] args)
    {
        Queue<int> buffer = new Queue<int>();
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");

        // TODO


        Console.WriteLine("Producer und Consumer gestartet...\n");

        for (int i = 1; i <= 5; i++)
        {
            new Producer(i, buffer);
        }

        // Überwachung: Jede Sekunde Queue-Füllstand ausgeben und auf >50 prüfen

        // TODO


        // Alle Producer stoppen


        // Consumer stoppen


    }
}
