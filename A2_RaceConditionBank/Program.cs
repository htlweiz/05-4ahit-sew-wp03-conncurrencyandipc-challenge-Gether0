using System;
using System.Threading;

namespace A2_RaceConditionBank;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
        
        // Bankkonto mit Startwert 1000 EUR erstellen
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");
        
    }
    
    private static void PerformBankOperations(BankAccount account)
    {
        Thread thread1 = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
            account.Deposit(500);
            Thread.Sleep(10);
            }
        });

        Thread thread2 = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
            account.Withdraw(300);
            Thread.Sleep(10);
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
        
    }
}

