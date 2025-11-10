using System;
using System.Threading;

namespace A2_RaceConditionBank;
public class BankAccount
{
    private int balance;
   
    
    public BankAccount(int initial) 
    { 
        balance = initial; 
    }
    
    public void Deposit(int amount) 
    {
        int newBalanceD = balance;
        balance = newBalanceD + amount;
    }
    
    public void Withdraw(int amount)
    { 
        int newBalanceW = balance;
        balance = newBalanceW - amount;
        
    }
    
    public int GetBalance() 
    {
        return balance;
    }
}
