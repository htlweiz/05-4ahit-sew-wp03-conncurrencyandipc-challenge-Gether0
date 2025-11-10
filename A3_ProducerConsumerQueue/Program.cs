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
        List<Producer> AllProducer = new List<Producer>();
        Console.WriteLine("Übung 3: Producer-Consumer");
        Console.WriteLine("==========================================\n");

        Console.WriteLine("Producer und Consumer gestartet...\n");

        for (int i = 1; i <= 5; i++)
        {
            AllProducer.Add(new Producer(i, buffer));
        }

        if (buffer.Count > 10)
        {
            foreach (var producer in AllProducer)
            {
                producer.Stop();
            }
        }

        Consumer consumer = new Consumer(buffer);


        // Überwachung: Jede Sekunde Queue-Füllstand ausgeben und auf >50 prüfen

        // TODO


        // Alle Producer stoppen


        // Consumer stoppen


    }
}
