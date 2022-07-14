using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation;

public class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount; //if the beginning balance was anyything other than zero, balance = amount wouldn't work
    }                      // so used += instead. redundant if balance stays zero             

    public double GetBalance()
    {
        return balance;
    }
}
