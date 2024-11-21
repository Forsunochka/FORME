using LABA_4._1;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Wallet wallet1 = new Wallet();
        Wallet wallet2 = new Wallet();

        Pound pound1 = new Pound
        {
            AvailableDenominations = new int[] { 5, 10, 20 },
            Denomination = 10,
            IssueDate = DateTime.Now.AddYears(-2),
            SerialNumber = "f892"
        };
        wallet1.AddToWallet(pound1);

        Pound pound2 = new Pound
        {
            AvailableDenominations = new int[] { 5, 10, 20 },
            Denomination = 20,
            IssueDate = DateTime.Now.AddYears(-5),
            SerialNumber = "hh555"
        };
        wallet2.AddToWallet(pound2);
        
        

        Ruble ruble1 = new Ruble
        {
            AvailableDenominations = new int[] { 50, 100, 200 },
            Denomination = 100,
            IssueDate = DateTime.Now.AddYears(-1),
            SerialNumber = "po888",
            Course = 0.015
        };
        wallet1.AddToWallet(ruble1);

        Tugrik tugrik1 = new Tugrik
        {
            AvailableDenominations = new int[] { 1000, 5000, 10000 },
            Denomination = 5000,
            IssueDate = DateTime.Now.AddYears(-3),
            SerialNumber = "duurac2"
        };
        Ruble ruble2 = new Ruble
        {
            AvailableDenominations = new int[] { 60, 2000, 5000 },
            Denomination = 100,
            IssueDate = DateTime.Now.AddYears(-1),
            SerialNumber = "5698",
            Course = 0.015
        };
        wallet2.AddToWallet(tugrik1);
        wallet2.AddToWallet(ruble2);

        Console.WriteLine("Wallet 1 contents:");
        Console.WriteLine(wallet1);

        Console.WriteLine("Wallet 2 contents:");
        Console.WriteLine(wallet2);

        double wallet1Sum = wallet1.SumInUSD();
        Console.WriteLine($"Wallet 1 sum in USD: {wallet1Sum}");

        double wallet2Sum = wallet2.SumInUSD();
        Console.WriteLine($"Wallet 2 sum in USD: {wallet2Sum}");

        Console.WriteLine($"Wallet 1 and Wallet 2 are equal: {wallet1 == wallet2}");

        Console.ReadLine();
    }
}
