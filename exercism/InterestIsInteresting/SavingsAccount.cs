using System;

class Program
{
    static void Main()
    {
        decimal balance = 2000m;

        Console.WriteLine("Balance: " + balance);

        Console.WriteLine("Tasa de interés: " +
                          SavingsAccount.InterestRate(balance) + "%");

        Console.WriteLine("Interés anual: " +
                          SavingsAccount.Interest(balance));

        Console.WriteLine("Balance después de un año: " +
                          SavingsAccount.AnnualBalanceUpdate(balance));

        decimal targetBalance = 3000m;

        Console.WriteLine("Años para llegar a " +
                          targetBalance + ": " +
                          SavingsAccount.YearsBeforeDesiredBalance(
                              balance,
                              targetBalance
                          ));
    }
}
